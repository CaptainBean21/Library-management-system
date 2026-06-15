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
    public partial class UCImprumuturi : UserControl
    {
        public Utilizator CititorLogat;

        public UCImprumuturi(Utilizator cititorLogat)
        {
            InitializeComponent();
            CititorLogat = cititorLogat;
        }

        private void UCImprumuturi_Load(object sender, EventArgs e)
        {
            IncarcaImprumuturi();
            btnPlateste.Enabled = false;
        }

        private void dgvImprumuturi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColoreazaRanduri();
        }

        private void dgvImprumuturi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImprumuturi.SelectedRows.Count > 0)
            {
                var randSelectat = dgvImprumuturi.SelectedRows[0];
                string status = randSelectat.Cells["Status"].Value?.ToString() ?? "";
                decimal penalizare = 0;
                if (randSelectat.Cells["Penalizare (lei)"].Value != null)
                    decimal.TryParse(randSelectat.Cells["Penalizare (lei)"].Value.ToString(), out penalizare);

                btnPlateste.Enabled = (status == "Intarziat" && penalizare > 0);
            }
            else btnPlateste.Enabled = false;
        }

        public void IncarcaImprumuturi()
        {
            using(var context = new AppDbContext())
            {
                var listaImprumuturi = context.Imprumuturi
                .Include(i => i.Carte)
                .Where(i => i.UtilizatorId == CititorLogat.Id)
                .ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Titlu Carte");
                dt.Columns.Add("Data Împrumut");
                dt.Columns.Add("Data Scadență");
                dt.Columns.Add("Data Returnării");
                dt.Columns.Add("Status");
                dt.Columns.Add("Penalizare (Lei)");

                foreach (var imp in listaImprumuturi)
                {
                    dt.Rows.Add(
                        imp.Id,
                        imp.Carte != null ? imp.Carte.Titlu : "Carte necunoscută",
                        imp.DataImprumut.ToShortDateString(),
                        imp.DataScadenta.ToShortDateString(),
                        imp.DataReturnare.HasValue ? imp.DataReturnare.Value.ToShortDateString() : "-",
                        imp.Status,
                        imp.Penalizare.ToString("0.00")
                    );
                }

                dgvImprumuturi.DataSource = dt;
            }
        }

        private void ColoreazaRanduri()
        {
            foreach (DataGridViewRow row in dgvImprumuturi.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    switch (status)
                    {
                        case "Returnat":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.DefaultCellStyle.ForeColor = Color.DimGray;
                            row.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                            row.DefaultCellStyle.SelectionForeColor = Color.DimGray;
                            break;

                        case "Intarziat":
                            row.DefaultCellStyle.BackColor = Color.MistyRose;
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                            row.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
                            row.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                            break;

                        case "Activ":
                            row.DefaultCellStyle.BackColor = Color.LightCyan;
                            row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                            row.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
                            row.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                            break;

                        case "Platit":
                            row.DefaultCellStyle.BackColor = Color.Khaki;
                            row.DefaultCellStyle.ForeColor = Color.SaddleBrown;
                            row.DefaultCellStyle.SelectionBackColor = Color.Khaki;
                            row.DefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
                            break;
                    }
                }
            }
        }

        private void btnPlateste_Click(object sender, EventArgs e)
        {
            if (dgvImprumuturi.SelectedRows.Count > 0)
            {
                int idImprumut = Convert.ToInt32(dgvImprumuturi.SelectedRows[0].Cells["ID"].Value);

                using (var context = new AppDbContext())
                {
                    var imprumut = context.Imprumuturi.FirstOrDefault(i => i.Id == idImprumut);

                    if (imprumut != null)
                    {
                        imprumut.Platit = true;
                        imprumut.DataUltimeiPlati = DateTime.Now;

                        context.SaveChanges();

                        MessageBox.Show("Plata a fost procesată cu succes! Penalizarea curentă a fost resetată.",
                                        "Plată Reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        IncarcaImprumuturi();

                        dgvImprumuturi.ClearSelection();
                        btnPlateste.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Împrumutul selectat nu a fost găsit în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvImprumuturi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                int latimeTabel = dgvImprumuturi.RowHeadersVisible ?
                    dgvImprumuturi.Width - dgvImprumuturi.RowHeadersWidth : dgvImprumuturi.Width;

                int coordonataX = dgvImprumuturi.RowHeadersVisible ? dgvImprumuturi.RowHeadersWidth : 0;

                Rectangle bounds = new Rectangle(coordonataX, e.RowBounds.Top, latimeTabel - 2, e.RowBounds.Height - 2);

                using (Pen pen = new Pen(Color.FromArgb(64, 64, 64), 4))
                {
                    e.Graphics.DrawRectangle(pen, bounds);
                }
            }
        }
    }
}