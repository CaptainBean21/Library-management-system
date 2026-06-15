using ProiectMSOA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectMSOA
{
    public partial class UCUtilizatori : UserControl
    {
        private Utilizator utilizatorLogat;

        public UCUtilizatori(Utilizator utilizator)
        {
            InitializeComponent();
            utilizatorLogat = utilizator;
            gboxDate.Visible = false;
            btnModifica.Enabled = false;
            btnSterge.Enabled = false;
            ActualizeazaLista();
        }

        private void ActualizeazaLista()
        {
            using (var context = new AppDbContext())
            {
                var listaUtilizatori = context.Utilizatori
                                              .Where(u => u.Id != utilizatorLogat.Id)
                                              .OrderBy(a => a.Nume)
                                              .ToList();

                lboxUtilizatori.DataSource = listaUtilizatori;
                lboxUtilizatori.DisplayMember = "Nume";

                lboxUtilizatori.SelectedIndex = -1;
            }
        }

        private void lboxUtilizatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxUtilizatori.SelectedItem is Utilizator utilizatorSelectat)
            {
                gboxDate.Visible = true;
                lblNume.Text = utilizatorSelectat.Nume;
                lblEmail.Text = utilizatorSelectat.Email;
                lblParola.Text = utilizatorSelectat.Parola;
                lblRol.Text = utilizatorSelectat.Rol;

                btnModifica.Enabled = true;
                btnSterge.Enabled = true;
            }
            else
            {
                gboxDate.Visible = false;
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lboxUtilizatori.SelectedItem is Utilizator utilizatorSelectat)
            {
                using (var context = new AppDbContext())
                {
                    if (context.Imprumuturi.Any(i => i.UtilizatorId == utilizatorSelectat.Id))
                    {
                        MessageBox.Show("Utilizatorul are împrumuturi!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show
                (
                    $"Ești sigur că vrei să ștergi utilizatorul {utilizatorSelectat.Nume}?",
                    "Confirmare Ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    using (var context = new AppDbContext())
                    {
                        var utilizatorDeSters = context.Utilizatori.Find(utilizatorSelectat.Id);

                        if (utilizatorDeSters != null)
                        {
                            context.Utilizatori.Remove(utilizatorDeSters);
                            context.SaveChanges();

                            MessageBox.Show("Utilizatorul a fost șters!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizeazaLista();
                        }
                    }
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lboxUtilizatori.SelectedItem is Utilizator utilizatorSelectat)
                using (FormularUtilizator frm = new FormularUtilizator(utilizatorSelectat.Id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        ActualizeazaLista();
                }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormularUtilizator frm = new FormularUtilizator())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    ActualizeazaLista();
            }
        }
    }
}
