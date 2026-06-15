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
    public partial class FormInregistrare : Form
    {
        private AppDbContext dbContext = new AppDbContext();

        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string nume = txtboxNume.Text.Trim();
            string email = txtboxEmail.Text.Trim();
            string parola = txtboxParola.Text.Trim();

            if (string.IsNullOrWhiteSpace(nume) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile ferestrei!", "Câmpuri incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool numeExista = dbContext.Utilizatori.Any(u => u.Nume.ToLower() == nume.ToLower());
                if (numeExista)
                {
                    MessageBox.Show("Acest nume de utilizator este deja folosit! Alege altul.", "Nume duplicat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool emailExista = dbContext.Utilizatori.Any(u => u.Email.ToLower() == email.ToLower());
                if (emailExista)
                {
                    MessageBox.Show("Acest email este deja asociat unui cont existent!", "Email duplicat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxEmail.Focus();
                    return;
                }

                Utilizator utilizatorNou = new Utilizator
                {
                    Nume = nume,
                    Email = email,
                    Parola = parola,
                    Rol = "Cititor"
                };

                dbContext.Utilizatori.Add(utilizatorNou);
                dbContext.SaveChanges();

                MessageBox.Show("Contul tău a fost creat cu succes! Te poți autentifica acum.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la accesarea bazei de date: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkInapoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
