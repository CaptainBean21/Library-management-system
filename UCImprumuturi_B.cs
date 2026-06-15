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
    public partial class UCImprumuturi_B : UserControl
    {
        public UCImprumuturi_B()
        {
            InitializeComponent();
            btnPlatit.Enabled = false;
            btnRestituit.Enabled = false;
            ActualizeazaLista();
        }

        private void ActualizeazaLista()
        {
            using (var context = new AppDbContext())
            {
                var toateImprumuturile = context.Imprumuturi
                    .Include(i => i.Carte)
                    .Include(i => i.Utilizator)
                    .ToList();

                var listaFiltrata = toateImprumuturile.Where(i =>
                    i.DataReturnare == null ||
                    i.Penalizare > 0
                ).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Client");
                dt.Columns.Add("Email");
                dt.Columns.Add("Carte");
                dt.Columns.Add("Data Împrumut");
                dt.Columns.Add("Data Scadentă");
                dt.Columns.Add("Status");
                dt.Columns.Add("Penalizare (Lei)");

                foreach (var imp in listaFiltrata)
                {
                    dt.Rows.Add(
                        imp.Id,
                        imp.Utilizator.Nume,
                        imp.Utilizator.Email,
                        imp.Carte,
                        imp.DataImprumut,
                        imp.DataScadenta,
                        imp.Status,
                        imp.Penalizare
                    );
                }

                dgvImprumuturi.DataSource = dt;
            }
        }

        private void dgvImprumuturi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImprumuturi.SelectedRows.Count > 0)
            {
                var rand = dgvImprumuturi.SelectedRows[0];
                
                decimal.TryParse(rand.Cells["Penalizare (Lei)"].Value?.ToString(), out decimal p);
                btnPlatit.Enabled = (p > 0);
                btnRestituit.Enabled = true;

                lblNume.Text = rand.Cells["Client"].Value?.ToString();
                lblEmail.Text = rand.Cells["Email"].Value?.ToString();
            }
            else
            {
                btnRestituit.Enabled = false;
                btnPlatit.Enabled = false;
            }
        }

        private void dgvImprumuturi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvImprumuturi.Rows)
            {
                string status = row.Cells["Status"].Value.ToString();

                if (status == "Intarziat")
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                }
                else if (status == "Activ")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCyan;
                    row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    row.DefaultCellStyle.ForeColor = Color.SaddleBrown;
                    row.DefaultCellStyle.SelectionBackColor = Color.Khaki;
                    row.DefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
                }
            }
        }

        private void dgvImprumuturi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                int coordonataX = dgvImprumuturi.RowHeadersVisible ? dgvImprumuturi.RowHeadersWidth : 0;
                int latimeVizibila = dgvImprumuturi.ClientSize.Width - coordonataX;

                Rectangle bounds = new Rectangle(coordonataX + 1, e.RowBounds.Top + 1, latimeVizibila - 2, e.RowBounds.Height - 3);

                using (Pen pen = new Pen(Color.FromArgb(64, 64, 64), 4))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawRectangle(pen, bounds);
                }
            }
        }

        private void btnRestituit_Click(object sender, EventArgs e)
        {
            int idImprumut = Convert.ToInt32(dgvImprumuturi.SelectedRows[0].Cells["ID"].Value);

            using (var context = new AppDbContext())
            {
                var imprumut = context.Imprumuturi.Include(i => i.Carte).FirstOrDefault(i => i.Id == idImprumut);
                if (imprumut == null) return;

                imprumut.DataReturnare = DateTime.Now;

                if (imprumut.Carte != null && !imprumut.Carte.Retrasa)
                    imprumut.Carte.Stoc ++;

                context.SaveChanges();

                if (imprumut.Penalizare == 0)
                {
                    MessageBox.Show("Cartea a fost returnată la timp!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Cartea a fost returnată cu întârziere! Clientul are o penalizare de {imprumut.Penalizare:0.00} Lei.", "Penalizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            ActualizeazaLista();
        }

        private void btnPlatit_Click(object sender, EventArgs e)
        {
            int idImprumut = Convert.ToInt32(dgvImprumuturi.SelectedRows[0].Cells["ID"].Value);

            using (var context = new AppDbContext())
            {
                var imprumut = context.Imprumuturi.FirstOrDefault(i => i.Id == idImprumut);
                if (imprumut == null) return;

                imprumut.DataUltimeiPlati = DateTime.Now;

                context.SaveChanges();
                MessageBox.Show("Penalizarea a fost achitată!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActualizeazaLista();
        }
    }
}
