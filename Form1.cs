using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;
using ProiectMSOA.Models;

namespace ProiectMSOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutentifica_Click(object sender, EventArgs e)
        {
            string nume_email = txtboxNume.Text.Trim();
            string parola = txtboxParola.Text.Trim();

            if (string.IsNullOrWhiteSpace(nume_email) || string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Completează ambele câmpuri!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var dbContext = new AppDbContext())
                {
                    dbContext.Database.EnsureCreated();

                    if (!dbContext.Utilizatori.Any())
                    {
                        dbContext.Utilizatori.Add(new Utilizator
                        {
                            Nume = "Admin",
                            Email = "admin@gmail.com",
                            Parola = "Admin123",
                            Rol = "Admin"
                        });

                        dbContext.Utilizatori.Add(new Utilizator
                        {
                            Nume = "Rodica",
                            Email = "RodicaMareBoss@gmail.com",
                            Parola = "1967",
                            Rol = "Bibliotecar"
                        });

                        dbContext.Utilizatori.Add(new Utilizator
                        {
                            Nume = "Victor",
                            Email = "unemailciudat",
                            Parola = "vic1VUL",
                            Rol = "Client"
                        });

                        dbContext.SaveChanges();
                    }

                    if (!dbContext.Carti.Any())
                    {
                        var autor1 = new Autor { Nume = "George Orwell" };
                        var autor2 = new Autor { Nume = "J.K. Rowling" };

                        dbContext.Autori.AddRange(autor1, autor2);
                        dbContext.SaveChanges();

                        dbContext.Carti.AddRange(
                            new Carte
                            {
                                Titlu = "1984",
                                Editura = "Polirom",
                                Categorie = "Dystopian",
                                Stoc = 13,
                                Autor = autor1
                            },
                            new Carte
                            {
                                Titlu = "Ferma Animalelor",
                                Editura = "Polirom",
                                Categorie = "Satire",
                                Stoc = 10,
                                Autor = autor1
                            },
                            new Carte
                            {
                                Titlu = "Harry Potter și Piatra Filozofală",
                                Editura = "Arthur",
                                Categorie = "Fantasy",
                                Stoc = 15,
                                Autor = autor2
                            }
                        );
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                using (var dbContext = new AppDbContext())
                {
                    var utilizatorLogat = dbContext.Utilizatori
                    .FirstOrDefault(u => ((u.Email == nume_email || u.Nume == nume_email))
                                            && u.Parola == parola);

                    if (utilizatorLogat != null)
                    {
                        Form Dashboard = null!;

                        switch (utilizatorLogat.Rol)
                        {
                            case "Admin":
                                Dashboard = new DashboardAdmin(this, utilizatorLogat);
                                break;

                            case "Bibliotecar":
                                Dashboard = new DashboardBibliotecar(this, utilizatorLogat);
                                break;

                            default:
                                Dashboard = new DashboardClient(this, utilizatorLogat);
                                break;
                        }

                        if (Dashboard != null)
                        {
                            txtboxNume.Clear();
                            txtboxParola.Clear();
                            this.Hide();
                            Dashboard.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email-ul sau parola introduse sunt incorecte!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtboxParola.Clear();
                        txtboxParola.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la accesarea bazei de date: {ex.Message}", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkContNou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInregistrare frmInregistrare = new FormInregistrare();
            frmInregistrare.ShowDialog();
        }
    }
}