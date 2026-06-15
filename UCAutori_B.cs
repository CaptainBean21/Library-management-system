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
    public partial class UCAutori_B : UserControl
    {
        public UCAutori_B()
        {
            InitializeComponent();
            gboxDateAutori.Visible = false;
            btnModifica.Enabled = false;
            btnSterge.Enabled = false;
            ActualizeazaLista();
        }

        public void ActualizeazaLista()
        {
            using (var context = new AppDbContext())
            {
                var listaAutori = context.Autori.OrderBy(a => a.Nume).ToList();

                lboxAutori.DataSource = listaAutori;
                lboxAutori.DisplayMember = "Nume";

                lboxAutori.SelectedIndex = -1;
            }
        }

        private void lboxAutori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAutori.SelectedItem is Autor autorSelectat)
            {
                gboxDateAutori.Visible = true;
                lblNume.Text = autorSelectat.Nume;
                lblBiografie.Text = !string.IsNullOrWhiteSpace(autorSelectat.Biografie)
                    ? autorSelectat.Biografie
                    : "Acest autor nu are o biografie adăugată.";

                btnModifica.Enabled = true;
                using (var context = new AppDbContext())
                    btnSterge.Enabled = !(context.Carti.Any(c => c.AutorId == autorSelectat.Id));
            }
            else
            {
                gboxDateAutori.Visible = false;
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lboxAutori.SelectedItem is Autor autorSelectat)
            {
                using (var context = new AppDbContext())
                {
                    var autorDeSters = context.Autori.FirstOrDefault(a => a.Id == autorSelectat.Id);
                    if (autorDeSters != null)
                    {
                        context.Autori.Remove(autorDeSters);
                        context.SaveChanges();

                        MessageBox.Show("Autorul a fost șters!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizeazaLista();
                    }
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lboxAutori.SelectedItem is Autor autorSelectat)
                using (FormularAutor frm = new FormularAutor(autorSelectat.Id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        ActualizeazaLista();
                }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormularAutor frm = new FormularAutor())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    ActualizeazaLista();
            }
        }
    }
}
