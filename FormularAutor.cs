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
    public partial class FormularAutor : Form
    {
        private int? autorId = null;

        public FormularAutor()
        {
            InitializeComponent();
            Text = "Adaugă Un Autor Nou";
        }

        public FormularAutor(int Id)
        {
            InitializeComponent();
            autorId = Id;
            Text = "Modifică Detalii";
            IncarcaDateAutor();
        }

        private void IncarcaDateAutor()
        {
            using (var context = new AppDbContext())
            {
                var autor = context.Autori.FirstOrDefault(a => a.Id == autorId);
                if (autor != null)
                {
                    txtboxNume.Text = autor.Nume;
                    txtboxBio.Text = autor.Biografie;
                }
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtboxNume.Text))
                using (var context = new AppDbContext())
                {
                    Autor autor;

                    if (autorId == null)
                    {
                        autor = new Autor();
                        context.Autori.Add(autor);
                    }
                    else autor = context.Autori.FirstOrDefault(a => a.Id == autorId);

                    autor.Nume = txtboxNume.Text.Trim();
                    autor.Biografie = txtboxBio.Text.Trim();

                    try
                    {
                        context.SaveChanges();

                        MessageBox.Show("Datele autorului au fost salvate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A apărut o eroare la salvarea în baza de date: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
