namespace ProiectMSOA
{
    partial class DashboardBibliotecar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardBibliotecar));
            btnCarti = new Button();
            btnImprumut = new Button();
            panelCentral = new Panel();
            btnInapoi = new Button();
            btnAutori = new Button();
            btnImpMele = new Button();
            gboxButoane = new GroupBox();
            gboxButoane.SuspendLayout();
            SuspendLayout();
            // 
            // btnCarti
            // 
            btnCarti.Location = new Point(0, 0);
            btnCarti.Name = "btnCarti";
            btnCarti.Size = new Size(189, 46);
            btnCarti.TabIndex = 2;
            btnCarti.Text = "Cărți";
            btnCarti.UseVisualStyleBackColor = true;
            btnCarti.Click += btnCarti_Click;
            // 
            // btnImprumut
            // 
            btnImprumut.Location = new Point(0, 84);
            btnImprumut.Name = "btnImprumut";
            btnImprumut.Size = new Size(189, 46);
            btnImprumut.TabIndex = 3;
            btnImprumut.Text = "Împrumuturi";
            btnImprumut.UseVisualStyleBackColor = true;
            btnImprumut.Click += btnImprumut_Click;
            // 
            // panelCentral
            // 
            panelCentral.Location = new Point(259, 86);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1100, 600);
            panelCentral.TabIndex = 4;
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(1423, 623);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(185, 63);
            btnInapoi.TabIndex = 5;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // btnAutori
            // 
            btnAutori.Location = new Point(0, 40);
            btnAutori.Name = "btnAutori";
            btnAutori.Size = new Size(189, 46);
            btnAutori.TabIndex = 6;
            btnAutori.Text = "Autori";
            btnAutori.UseVisualStyleBackColor = true;
            btnAutori.Click += btnAutori_Click;
            // 
            // btnImpMele
            // 
            btnImpMele.Location = new Point(0, 126);
            btnImpMele.Name = "btnImpMele";
            btnImpMele.Size = new Size(189, 75);
            btnImpMele.TabIndex = 7;
            btnImpMele.Text = "Împrumuturile mele";
            btnImpMele.UseVisualStyleBackColor = true;
            btnImpMele.Click += btnImpMele_Click;
            // 
            // gboxButoane
            // 
            gboxButoane.Controls.Add(btnCarti);
            gboxButoane.Controls.Add(btnImpMele);
            gboxButoane.Controls.Add(btnImprumut);
            gboxButoane.Controls.Add(btnAutori);
            gboxButoane.Location = new Point(68, 88);
            gboxButoane.Name = "gboxButoane";
            gboxButoane.Size = new Size(189, 201);
            gboxButoane.TabIndex = 8;
            gboxButoane.TabStop = false;
            // 
            // DashboardBibliotecar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1677, 764);
            Controls.Add(gboxButoane);
            Controls.Add(btnInapoi);
            Controls.Add(panelCentral);
            Name = "DashboardBibliotecar";
            Text = "DashboardBibliotecar";
            Shown += DashboardBibliotecar_Shown;
            gboxButoane.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarti;
        private Button btnImprumut;
        private Panel panelCentral;
        private Button btnInapoi;
        private Button btnAutori;
        private Button btnImpMele;
        private GroupBox gboxButoane;
    }
}