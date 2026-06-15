namespace ProiectMSOA
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panelCentral = new Panel();
            gboxButoane = new GroupBox();
            btnStatistici = new Button();
            btnImpMele = new Button();
            btnUtilizatori = new Button();
            btnInapoi = new Button();
            gboxButoane.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentral
            // 
            panelCentral.Location = new Point(262, 94);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1100, 600);
            panelCentral.TabIndex = 0;
            // 
            // gboxButoane
            // 
            gboxButoane.Controls.Add(btnStatistici);
            gboxButoane.Controls.Add(btnImpMele);
            gboxButoane.Controls.Add(btnUtilizatori);
            gboxButoane.Location = new Point(63, 94);
            gboxButoane.Name = "gboxButoane";
            gboxButoane.Size = new Size(199, 161);
            gboxButoane.TabIndex = 1;
            gboxButoane.TabStop = false;
            // 
            // btnStatistici
            // 
            btnStatistici.Location = new Point(0, 43);
            btnStatistici.Name = "btnStatistici";
            btnStatistici.Size = new Size(199, 46);
            btnStatistici.TabIndex = 0;
            btnStatistici.Text = "Statistici";
            btnStatistici.UseVisualStyleBackColor = true;
            btnStatistici.Click += btnStatistici_Click;
            // 
            // btnImpMele
            // 
            btnImpMele.Location = new Point(0, 87);
            btnImpMele.Name = "btnImpMele";
            btnImpMele.Size = new Size(199, 74);
            btnImpMele.TabIndex = 2;
            btnImpMele.Text = "Împrumuturile Mele";
            btnImpMele.UseVisualStyleBackColor = true;
            btnImpMele.Click += btnImpMele_Click;
            // 
            // btnUtilizatori
            // 
            btnUtilizatori.Location = new Point(0, 0);
            btnUtilizatori.Name = "btnUtilizatori";
            btnUtilizatori.Size = new Size(199, 46);
            btnUtilizatori.TabIndex = 2;
            btnUtilizatori.Text = "Utilizatori";
            btnUtilizatori.UseVisualStyleBackColor = true;
            btnUtilizatori.Click += btnUtilizatori_Click;
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(1412, 589);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(185, 63);
            btnInapoi.TabIndex = 5;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1677, 764);
            Controls.Add(btnInapoi);
            Controls.Add(gboxButoane);
            Controls.Add(panelCentral);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            Shown += DashboardAdmin_Shown;
            gboxButoane.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCentral;
        private GroupBox gboxButoane;
        private Button btnUtilizatori;
        private Button btnImpMele;
        private Button btnInapoi;
        private Button btnStatistici;
    }
}