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
    public partial class DashboardAdmin : Form
    {
        private Form1 LogIn;
        private Utilizator utilizatorLogat;

        public DashboardAdmin(Form1 logIn, Utilizator utilizator)
        {
            InitializeComponent();
            LogIn = logIn;
            utilizatorLogat = utilizator;
        }

        private void DashboardAdmin_Shown(object sender, EventArgs e) { btnUtilizatori.PerformClick(); }

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

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            UCUtilizatori ecranUtilizatori = new UCUtilizatori(utilizatorLogat);
            AfiseazaEcran(ecranUtilizatori, btnUtilizatori);
        }

        private void btnStatistici_Click(object sender, EventArgs e)
        {
            UCStatistici ecranStatistici = new UCStatistici();
            AfiseazaEcran(ecranStatistici, btnStatistici);  
        }

        private void btnImpMele_Click(object sender, EventArgs e)
        {
            UCImprumuturi ecranImprumuturi = new UCImprumuturi(utilizatorLogat);
            AfiseazaEcran(ecranImprumuturi, btnImpMele);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            LogIn.Show();
            Close();
        }
    }
}
