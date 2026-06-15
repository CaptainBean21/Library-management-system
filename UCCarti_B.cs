using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProiectMSOA
{
    public partial class UCCarti_B : UserControl
    {
        private enum Criterii
        {
            Titlu,
            Autor,
            Editura,
            Categorie,
            Stoc,
            Retrase
        }

        public UCCarti_B()
        {
            InitializeComponent();
            cboxOrdoneaza.DataSource = Enum.GetValues(typeof(Criterii));
            cboxFiltrare.DataSource = Enum.GetValues(typeof(Criterii));
            btnModifica.Enabled = false;
            btnSterge.Enabled = false;
            ActualizeazaListaCarti();
        }

        public void ActualizeazaListaCarti()
        {

            using (var context = new AppDbContext())
            {
                var interogare = context.Carti.Include(c => c.Autor).AsQueryable();


                if (cboxFiltrare.SelectedItem is Criterii criteriuFiltru)
                {
                    string textCautat = txtboxFiltrare.Text.Trim().ToLower();

                    if (!string.IsNullOrWhiteSpace(textCautat))
                    {
                        switch (criteriuFiltru)
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
                                if (int.TryParse(textCautat, out int stocCautat))
                                    interogare = interogare.Where(c => c.Stoc >= stocCautat);
                                break;

                            case Criterii.Retrase:
                                interogare = interogare.Where(c => c.Retrasa);
                                break;
                        }
                    }
                }

                if (cboxOrdoneaza.SelectedItem is Criterii criteriuOrdonare)
                {
                    switch (criteriuOrdonare)
                    {
                        case Criterii.Titlu:
                            interogare = interogare.OrderBy(c => c.Titlu);
                            break;

                        case Criterii.Autor:
                            interogare = interogare.OrderBy(c => c.Autor);
                            break;

                        case Criterii.Editura:
                            interogare = interogare.OrderBy(c => c.Editura);
                            break;

                        case Criterii.Categorie:
                            interogare = interogare.OrderBy(c => c.Categorie);
                            break;

                        case Criterii.Stoc:
                            interogare = interogare.OrderByDescending(c => c.Stoc);
                            break;

                        case Criterii.Retrase:
                            interogare = interogare.OrderByDescending(c => c.Retrasa);
                            break;
                    }
                }


                var listaFinala = interogare.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Titlu");
                dt.Columns.Add("Autor");
                dt.Columns.Add("Editura");
                dt.Columns.Add("Categorie");
                dt.Columns.Add("Stoc");
                dt.Columns.Add("Retrasa");

                foreach (var carte in listaFinala)
                {
                    dt.Rows.Add(
                        carte.Id,
                        carte.Titlu,
                        carte.Autor.Nume,
                        carte.Editura,
                        carte.Categorie,
                        carte.Stoc,
                        carte.Retrasa.ToString()
                    );
                }

                dgvCarti.DataSource = dt;
            }
        }

        private void dgvCarti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCarti.SelectedRows.Count > 0)
            {
                var randSelectat = dgvCarti.SelectedRows[0];
                string esteRetrasa = randSelectat.Cells["Retrasa"].Value?.ToString() ?? "False";

                btnModifica.Enabled = (esteRetrasa == "False");
                btnSterge.Enabled = (esteRetrasa == "False");
            }
            else
            {
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
            }
        }

        private void dgvCarti_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCarti.Rows)
            {
                if (row.Cells["Retrasa"].Value != null)
                {
                    string esteRetrasa = row.Cells["Retrasa"].Value.ToString();

                    if (esteRetrasa == "True")
                    {
                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        row.DefaultCellStyle.ForeColor = Color.SaddleBrown;
                        row.DefaultCellStyle.SelectionBackColor = Color.Khaki;
                        row.DefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
                    }
                    else
                    {
                        row.DefaultCellStyle.SelectionBackColor = dgvCarti.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.SelectionForeColor = dgvCarti.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }

        private void dgvCarti_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
            {
                int latimeTabel = dgvCarti.RowHeadersVisible ?
                    dgvCarti.Width - dgvCarti.RowHeadersWidth : dgvCarti.Width;

                int coordonataX = dgvCarti.RowHeadersVisible ? dgvCarti.RowHeadersWidth : 0;

                Rectangle bounds = new Rectangle(coordonataX, e.RowBounds.Top, latimeTabel - 2, e.RowBounds.Height - 2);

                using (Pen pen = new Pen(Color.FromArgb(64, 64, 64), 4))
                {
                    e.Graphics.DrawRectangle(pen, bounds);
                }
            }
        }

        private void txtboxFiltrare_TextChanged(object sender, EventArgs e)
        { ActualizeazaListaCarti(); }

        private void btnAplica_Click(object sender, EventArgs e)
        { ActualizeazaListaCarti(); }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvCarti.SelectedRows.Count > 0)
            {
                int idCarte = Convert.ToInt32(dgvCarti.SelectedRows[0].Cells["ID"].Value);

                using (FormularCarte frm = new FormularCarte(idCarte))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        ActualizeazaListaCarti();
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormularCarte frm = new FormularCarte())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    ActualizeazaListaCarti();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvCarti.SelectedRows.Count > 0)
            {
                int idCarte = Convert.ToInt32(dgvCarti.SelectedRows[0].Cells["ID"].Value);
                string titlu = dgvCarti.SelectedRows[0].Cells["Titlu"].Value?.ToString() ?? "Carte";

                var raspuns = MessageBox.Show($"Ești sigur că vrei să retragi/ștergi cartea '{titlu}'?",
                    "Confirmare Ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (raspuns == DialogResult.No) return;

                using (var context = new AppDbContext())
                {
                    var carte = context.Carti.FirstOrDefault(c => c.Id == idCarte);
                    if (carte == null) return;

                    bool areImprumuturi = context.Imprumuturi.Any(i => i.Carte.Id == idCarte && i.DataReturnare == null);

                    if (areImprumuturi)
                    {
                        carte.Retrasa = true;
                        carte.Stoc = 0;

                        context.SaveChanges();
                        MessageBox.Show("Cartea este împrumutată! A fost marcată ca Retrasă. Se va șterge automat din baza de date la ultima returnare.",
                            "Retrasă din circulație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        context.Carti.Remove(carte);
                        context.SaveChanges();
                        MessageBox.Show("Cartea a fost ștearsă definitiv.",
                            "Ștearsă cu succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ActualizeazaListaCarti();
                    dgvCarti.ClearSelection();
                }
            }
        }
    }
}