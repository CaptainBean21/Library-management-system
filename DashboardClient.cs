using ProiectMSOA.Models;
using System;
using System.Windows.Forms;

namespace ProiectMSOA
{
    public partial class DashboardClient : Form
    {
        private Form1 LogIn;
        private Utilizator utilizatorLogat;
        public DashboardClient(Form1 logIn, Utilizator utilizator)
        {
            InitializeComponent();
            LogIn = logIn;
            utilizatorLogat = utilizator;
        }

        private void DashboardClient_Shown(object sender, EventArgs e) { btnCarti.PerformClick(); }

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
            UCCarti ecranCarti = new UCCarti(utilizatorLogat);
            AfiseazaEcran(ecranCarti, btnCarti);
        }

        private void btnImprumut_Click(object sender, EventArgs e)
        {
            UCImprumuturi ecranImprumuturi = new UCImprumuturi(utilizatorLogat);
            AfiseazaEcran(ecranImprumuturi, btnImprumut);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            LogIn.Show();
            Close();
        }
    }
}
