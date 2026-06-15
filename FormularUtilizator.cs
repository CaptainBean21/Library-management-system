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
    public partial class FormularUtilizator : Form
    {
        private int? utilizatorId;

        public FormularUtilizator()
        {
            InitializeComponent();
            Text = "Adaugă Un Utilizator Nou";
        }

        public FormularUtilizator(int Id)
        {
            InitializeComponent();
            utilizatorId = Id;
            Text = "Modifică Utilizatorul";
            IncarcaDateUtilizator();
        }

        private void IncarcaDateUtilizator()
        {
            using (var context = new AppDbContext())
            {
                var utilizator = context.Utilizatori.FirstOrDefault(a => a.Id == utilizatorId);
                if (utilizator != null)
                {
                    txtboxNume.Text = utilizator.Nume;
                    txtboxEmail.Text = utilizator.Email;
                    txtboxParola.Text = utilizator.Parola;
                    cboxRol.SelectedItem = utilizator.Rol;
                }
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxNume.Text) ||
                string.IsNullOrWhiteSpace(txtboxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtboxParola.Text) ||
                cboxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                Utilizator utilizator;

                if (utilizatorId == null)
                {
                    utilizator = new Utilizator();
                    context.Utilizatori.Add(utilizator);
                }
                else utilizator = context.Utilizatori.FirstOrDefault(a => a.Id == utilizatorId);

                utilizator.Nume = txtboxNume.Text.Trim();
                utilizator.Email = txtboxEmail.Text.Trim();
                utilizator.Parola = txtboxParola.Text.Trim();
                utilizator.Rol = cboxRol.SelectedItem.ToString();

                try
                {
                    context.SaveChanges();

                    MessageBox.Show("Datele utilizatorului au fost salvate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
