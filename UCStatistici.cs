using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectMSOA
{
    public partial class UCStatistici : UserControl
    {
        public UCStatistici()
        {
            InitializeComponent();
            LoadStats();
        }

        public void LoadStats()
        {
            using (var context = new AppDbContext())
            {
                lblAdmini.Text = context.Utilizatori.Where(u => u.Rol == "Admin")
                                                    .Count().ToString();
                lblBib.Text = context.Utilizatori.Where(u => u.Rol == "Bibliotecar")
                                                 .Count().ToString();
                lblClienti.Text = context.Utilizatori.Where(u => u.Rol == "Client")
                                                     .Count().ToString();
                lblImp.Text = context.Imprumuturi.Count().ToString();
                lblCarti.Text = context.Carti.Count().ToString();
            }
        }
    }
}
