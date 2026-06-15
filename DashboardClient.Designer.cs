namespace ProiectMSOA
{
    partial class DashboardClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardClient));
            panelCentral = new Panel();
            btnCarti = new Button();
            btnImprumut = new Button();
            btnInapoi = new Button();
            gboxButoane = new GroupBox();
            gboxButoane.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentral
            // 
            panelCentral.Location = new Point(358, 77);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(970, 600);
            panelCentral.TabIndex = 0;
            // 
            // btnCarti
            // 
            btnCarti.Location = new Point(0, 0);
            btnCarti.Name = "btnCarti";
            btnCarti.Size = new Size(173, 46);
            btnCarti.TabIndex = 1;
            btnCarti.Text = "Cărți";
            btnCarti.UseVisualStyleBackColor = true;
            btnCarti.Click += btnCarti_Click;
            // 
            // btnImprumut
            // 
            btnImprumut.Location = new Point(0, 41);
            btnImprumut.Name = "btnImprumut";
            btnImprumut.Size = new Size(173, 46);
            btnImprumut.TabIndex = 2;
            btnImprumut.Text = "Împrumuturi";
            btnImprumut.UseVisualStyleBackColor = true;
            btnImprumut.Click += btnImprumut_Click;
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(1390, 614);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(185, 63);
            btnInapoi.TabIndex = 4;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // gboxButoane
            // 
            gboxButoane.Controls.Add(btnCarti);
            gboxButoane.Controls.Add(btnImprumut);
            gboxButoane.Location = new Point(184, 80);
            gboxButoane.Name = "gboxButoane";
            gboxButoane.Size = new Size(173, 87);
            gboxButoane.TabIndex = 5;
            gboxButoane.TabStop = false;
            // 
            // DashboardClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1677, 764);
            Controls.Add(gboxButoane);
            Controls.Add(btnInapoi);
            Controls.Add(panelCentral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardClient";
            Text = "DashboardClient";
            Shown += DashboardClient_Shown;
            gboxButoane.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentral;
        private Button btnCarti;
        private Button btnImprumut;
        private Button btnInapoi;
        private GroupBox gboxButoane;
    }
}