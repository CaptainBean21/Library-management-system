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
    public partial class DashboardBibliotecar : Form
    {
        private Form1 LogIn;
        private Utilizator utilizatorLogat;

        public DashboardBibliotecar(Form1 logIn, Utilizator utilizator)
        {
            InitializeComponent();
            LogIn = logIn;
            utilizatorLogat = utilizator;
        }

        private void DashboardBibliotecar_Shown(object sender, EventArgs e) { btnCarti.PerformClick(); }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (LogIn != null && !LogIn.Visible) Application.Exit();
        }

        private void AfiseazaEcran(UserControl ecranNou, Button butonApasat)
        {
            panelCentral.Controls.Clear();
            ecranNou.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(ecranNou);
            ecranNou.BringToFront();

            foreach (Button c in gboxButoane.Controls)
                c.Enabled = true;

            butonApasat.Enabled = false;
        }

        private void btnCarti_Click(object sender, EventArgs e)
        {
            UCCarti_B ecranCarti = new UCCarti_B();
            AfiseazaEcran(ecranCarti, btnCarti);
        }

        private void btnAutori_Click(object sender, EventArgs e)
        {
            UCAutori_B ecranAutori = new UCAutori_B();
            AfiseazaEcran(ecranAutori, btnAutori);
        }

        private void btnImprumut_Click(object sender, EventArgs e)
        {
            UCImprumuturi_B ecranImprumuturi = new UCImprumuturi_B();
            AfiseazaEcran(ecranImprumuturi, btnImprumut);
        }

        private void btnImpMele_Click(object sender, EventArgs e)
        {
            UCImprumuturi ecranImprumuturi = new UCImprumuturi(utilizatorLogat);
            AfiseazaEcran(ecranImprumuturi, btnImpMele);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            LogIn.Show();
            this.Close();
        }
    }
}
