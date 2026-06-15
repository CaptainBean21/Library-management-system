using Microsoft.EntityFrameworkCore;
using ProiectMSOA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using static ProiectMSOA.UCCarti;

namespace ProiectMSOA
{
    public partial class UCCarti : UserControl
    {
        public Utilizator CititorLogat;

        public UCCarti(Utilizator cititorLogat)
        {
            InitializeComponent();
            cboxOrdonare.DataSource = Enum.GetValues(typeof(Criterii));
            cboxFiltrare.DataSource = Enum.GetValues(typeof(Criterii));
            CititorLogat = cititorLogat;
            gbox.Visible = false;
            //dtpDataRez.MinDate = DateTime.Today.AddDays(1);
            ActualizeazaListaCarti();
        }

        public enum Criterii
        {
            Titlu,
            Autor,
            Editura,
            Categorie,
            Stoc
        }

        public void ActualizeazaListaCarti()
        {
            lstboxCarti.SelectedIndex = -1;
            gbox.Visible = false;

            using (var dbContext = new AppDbContext())
            {
                var interogare = dbContext.Carti.Include(c => c.Autor).AsQueryable();

                if (cboxFiltrare.SelectedItem is Criterii criteriuFiltrare)
                {
                    string textCautat = txtboxFiltrare.Text.Trim().ToLower();

                    if (!string.IsNullOrWhiteSpace(textCautat))
                    {
                        switch (criteriuFiltrare)
                        {
                            case Criterii.Titlu:
                                interogare = interogare.Where(c => c.Titlu.ToLower().Contains(textCautat));
                                break;

                            case Criterii.Autor:
                                interogare = interogare.Where(c => c.Autor.Nume.ToLower().Contains(textCautat));
                                break;

                            case Criterii.Editura:
                                interogare = interogare.Where(c => c.Editura.ToLower().Contains(textCautat));
                                break;

                            case Criterii.Categorie:
                                interogare = interogare.Where(c => c.Categorie.ToLower().Contains(textCautat));
                                break;

                            case Criterii.Stoc:
                                if (int.TryParse(textCautat, out int stocMinim))
                                    interogare = interogare.Where(c => c.Stoc >= stocMinim);
                                break;
                        }
                    }
                }

                if (cboxOrdonare.SelectedItem is Criterii criteriuOrdonare)
                {
                    switch (criteriuOrdonare)
                    {
                        case Criterii.Titlu:
                            interogare = interogare.OrderBy(c => c.Titlu);
                            break;

                        case Criterii.Autor:
                            interogare = interogare.OrderBy(c => c.Autor.Nume);
                            break;

                        case Criterii.Editura:
                            interogare = interogare.OrderBy(c => c.Editura);
                            break;

                        case Criterii.Categorie:
                            interogare = interogare.OrderBy(c => c.Categorie);
                            break;

                        case Criterii.Stoc:
                            interogare = interogare.OrderBy(c => c.Stoc);
                            break;
                    }
                }

                var listaFinala = interogare.ToList();
                lstboxCarti.DataSource = null;
                lstboxCarti.DataSource = listaFinala;
                lstboxCarti.DisplayMember = "Titlu";
            }
        }

        private void lstboxCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxCarti.SelectedItem is Carte carteSelectata)
            {
                gbox.Visible = true;
                btnRezerva.Enabled = false;

                lblTitlu.Text = carteSelectata.Titlu;
                lblAutor.Text = carteSelectata.Autor.Nume;
                lblEditura.Text = carteSelectata.Editura;
                lblCategorie.Text = carteSelectata.Categorie;

                if (!carteSelectata.Disponibilitate)
                {
                    lblStoc.Text = "Indisponibil!";
                    lblStoc.ForeColor = Color.Red;
                }
                else
                {
                    lblStoc.Text = carteSelectata.Stoc.ToString();
                    lblStoc.ForeColor = Color.Green;
                }
            }
        }

        private void dtpDataRez_ValueChanged(object sender, EventArgs e)
        {
            if (lstboxCarti.SelectedItem is Carte carteSelectata && carteSelectata.Disponibilitate)
                btnRezerva.Enabled = true;
        }

        private void btnOrdonare_Click(object sender, EventArgs e)
        { ActualizeazaListaCarti(); }

        private void txtboxFiltrare_TextChanged(object sender, EventArgs e)
        { ActualizeazaListaCarti(); }

        private void btnRezerva_Click(object sender, EventArgs e)
        {
            if (lstboxCarti.SelectedItem is Carte carteSelectata)
            {
                using(var dbContext = new AppDbContext())
                {
                    try
                    {
                        var carteDinDb = dbContext.Carti.Find(carteSelectata.Id);
                        var utilizatorDinDb = dbContext.Utilizatori.Find(CititorLogat.Id);

                        if (carteDinDb == null || utilizatorDinDb == null)
                        {
                            MessageBox.Show("Eroare: Cartea sau utilizatorul nu mai există în baza de date!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (carteDinDb.Stoc <= 0)
                        {
                            MessageBox.Show("Cartea nu mai este disponibilă în stoc!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Imprumut rezervareNoua = new Imprumut
                        {
                            UtilizatorId = utilizatorDinDb.Id,
                            Utilizator = utilizatorDinDb,
                            Carte = carteDinDb,
                            DataImprumut = DateTime.Now,
                            DataScadenta = dtpDataRez.Value.Date,
                            DataUltimeiPlati = dtpDataRez.Value.Date,
                        };

                        dbContext.Imprumuturi.Add(rezervareNoua);
                        carteDinDb.Stoc--;
                        dbContext.SaveChanges();

                        MessageBox.Show($"Rezervarea pentru cartea '{carteDinDb.Titlu}' a fost înregistrată cu succes!\nTermen limită restituire: {dtpDataRez.Value.ToShortDateString()}",
                                        "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizeazaListaCarti();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A apărut o eroare la salvarea rezervării: {ex.Message}", "Eroare Critică", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
