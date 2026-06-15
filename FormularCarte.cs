using Microsoft.EntityFrameworkCore;
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
    public partial class FormularCarte : Form
    {
        private int? carteId = null;

        public FormularCarte()
        {
            InitializeComponent();
            this.Text = "Adaugă O Carte";
            InitCbox();
        }

        public FormularCarte(int carteId)
        {
            InitializeComponent();
            this.carteId = carteId;
            this.Text = "Modifică Detalii";
            InitCbox();
            IncarcaDatele();
        }

        private void InitCbox()
        {
            using (var context = new AppDbContext())
            {
                cboxAutor.DataSource = context.Autori.ToList();
                cboxAutor.DisplayMember = "Nume";
                cboxAutor.ValueMember = "Id";
            }
        }

        private void IncarcaDatele()
        {
            using (var context = new AppDbContext())
            {
                var carte = context.Carti.FirstOrDefault(c => c.Id == carteId);
                if (carte != null)
                {
                    txtboxTitlu.Text = carte.Titlu;
                    txtboxEditura.Text = carte.Editura;
                    txtboxCategorie.Text = carte.Categorie;
                    nupdStoc.Text = carte.Stoc.ToString();
                    cboxAutor.SelectedValue = carte.AutorId;
                }
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxTitlu.Text) ||
                string.IsNullOrWhiteSpace(txtboxEditura.Text) ||
                string.IsNullOrWhiteSpace(txtboxCategorie.Text) ||
                cboxAutor.SelectedItem == null)
            {
                MessageBox.Show("Câmpuri invalide!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                Carte carte;

                if (carteId == null)
                {
                    carte = new Carte();
                    context.Carti.Add(carte);
                }
                else
                {
                    carte = context.Carti.FirstOrDefault(c => c.Id == carteId);
                    if (carte == null) return;
                }

                carte.Titlu = txtboxTitlu.Text.Trim();
                carte.Editura = txtboxEditura.Text.Trim();
                carte.Categorie = txtboxCategorie.Text.Trim();
                carte.Stoc = (int)nupdStoc.Value;
                carte.AutorId = (int)cboxAutor.SelectedValue;

                try
                {
                    context.SaveChanges();

                    MessageBox.Show("Cartea a fost salvată în bibliotecă!",
                        "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la salvarea datelor în baza de date: {ex.Message}",
                        "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
