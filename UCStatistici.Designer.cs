namespace ProiectMSOA
{
    partial class UCStatistici
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboxUtilizatori = new GroupBox();
            lblClienti = new Label();
            lblBib = new Label();
            lblAdmini = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gboxImprumuturi = new GroupBox();
            lblImp = new Label();
            label4 = new Label();
            gboxCarti = new GroupBox();
            lblCarti = new Label();
            label5 = new Label();
            gboxUtilizatori.SuspendLayout();
            gboxImprumuturi.SuspendLayout();
            gboxCarti.SuspendLayout();
            SuspendLayout();
            // 
            // gboxUtilizatori
            // 
            gboxUtilizatori.Controls.Add(lblClienti);
            gboxUtilizatori.Controls.Add(lblBib);
            gboxUtilizatori.Controls.Add(lblAdmini);
            gboxUtilizatori.Controls.Add(label3);
            gboxUtilizatori.Controls.Add(label2);
            gboxUtilizatori.Controls.Add(label1);
            gboxUtilizatori.Location = new Point(3, 3);
            gboxUtilizatori.Name = "gboxUtilizatori";
            gboxUtilizatori.Size = new Size(366, 594);
            gboxUtilizatori.TabIndex = 0;
            gboxUtilizatori.TabStop = false;
            gboxUtilizatori.Text = "Utilizatori";
            // 
            // lblClienti
            // 
            lblClienti.AutoSize = true;
            lblClienti.Location = new Point(221, 204);
            lblClienti.Name = "lblClienti";
            lblClienti.Size = new Size(29, 32);
            lblClienti.TabIndex = 5;
            lblClienti.Text = "...";
            // 
            // lblBib
            // 
            lblBib.AutoSize = true;
            lblBib.Location = new Point(275, 145);
            lblBib.Name = "lblBib";
            lblBib.Size = new Size(29, 32);
            lblBib.TabIndex = 4;
            lblBib.Text = "...";
            // 
            // lblAdmini
            // 
            lblAdmini.AutoSize = true;
            lblAdmini.Location = new Point(230, 89);
            lblAdmini.Name = "lblAdmini";
            lblAdmini.Size = new Size(29, 32);
            lblAdmini.TabIndex = 3;
            lblAdmini.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 89);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 2;
            label3.Text = "Număr de admini:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 204);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 1;
            label2.Text = "Număr de clienți:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 145);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Număr de bibliotecari:";
            // 
            // gboxImprumuturi
            // 
            gboxImprumuturi.Controls.Add(lblImp);
            gboxImprumuturi.Controls.Add(label4);
            gboxImprumuturi.Location = new Point(369, 3);
            gboxImprumuturi.Name = "gboxImprumuturi";
            gboxImprumuturi.Size = new Size(366, 594);
            gboxImprumuturi.TabIndex = 1;
            gboxImprumuturi.TabStop = false;
            gboxImprumuturi.Text = "Împrumuturi";
            // 
            // lblImp
            // 
            lblImp.AutoSize = true;
            lblImp.Location = new Point(301, 89);
            lblImp.Name = "lblImp";
            lblImp.Size = new Size(29, 32);
            lblImp.TabIndex = 7;
            lblImp.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 89);
            label4.Name = "label4";
            label4.Size = new Size(267, 32);
            label4.TabIndex = 6;
            label4.Text = "Număr de împrumuturi:";
            // 
            // gboxCarti
            // 
            gboxCarti.Controls.Add(lblCarti);
            gboxCarti.Controls.Add(label5);
            gboxCarti.Location = new Point(733, 3);
            gboxCarti.Name = "gboxCarti";
            gboxCarti.Size = new Size(366, 594);
            gboxCarti.TabIndex = 2;
            gboxCarti.TabStop = false;
            gboxCarti.Text = "Cărți";
            // 
            // lblCarti
            // 
            lblCarti.AutoSize = true;
            lblCarti.Location = new Point(241, 89);
            lblCarti.Name = "lblCarti";
            lblCarti.Size = new Size(29, 32);
            lblCarti.TabIndex = 9;
            lblCarti.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 89);
            label5.Name = "label5";
            label5.Size = new Size(206, 32);
            label5.TabIndex = 8;
            label5.Text = "Cărți în bibliotecă:";
            // 
            // UCStatistici
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gboxCarti);
            Controls.Add(gboxImprumuturi);
            Controls.Add(gboxUtilizatori);
            Name = "UCStatistici";
            Size = new Size(1100, 600);
            gboxUtilizatori.ResumeLayout(false);
            gboxUtilizatori.PerformLayout();
            gboxImprumuturi.ResumeLayout(false);
            gboxImprumuturi.PerformLayout();
            gboxCarti.ResumeLayout(false);
            gboxCarti.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxUtilizatori;
        private GroupBox gboxImprumuturi;
        private GroupBox gboxCarti;
        private Label lblBib;
        private Label lblAdmini;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblClienti;
        private Label lblImp;
        private Label label4;
        private Label lblCarti;
        private Label label5;
    }
}
