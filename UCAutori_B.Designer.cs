namespace ProiectMSOA
{
    partial class UCAutori_B
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
            lboxAutori = new ListBox();
            btnAdauga = new Button();
            btnModifica = new Button();
            btnSterge = new Button();
            gboxDateAutori = new GroupBox();
            lblBiografie = new Label();
            lblNume = new Label();
            gboxDateAutori.SuspendLayout();
            SuspendLayout();
            // 
            // lboxAutori
            // 
            lboxAutori.FormattingEnabled = true;
            lboxAutori.Location = new Point(0, 0);
            lboxAutori.Name = "lboxAutori";
            lboxAutori.Size = new Size(525, 516);
            lboxAutori.TabIndex = 0;
            lboxAutori.SelectedIndexChanged += lboxAutori_SelectedIndexChanged;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(375, 533);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 1;
            btnAdauga.Text = "Adaugă";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(196, 533);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 46);
            btnModifica.TabIndex = 2;
            btnModifica.Text = "Modifică";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(20, 533);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(150, 46);
            btnSterge.TabIndex = 3;
            btnSterge.Text = "Șterge";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // gboxDateAutori
            // 
            gboxDateAutori.Controls.Add(lblBiografie);
            gboxDateAutori.Controls.Add(lblNume);
            gboxDateAutori.Location = new Point(531, 3);
            gboxDateAutori.Name = "gboxDateAutori";
            gboxDateAutori.Size = new Size(566, 513);
            gboxDateAutori.TabIndex = 4;
            gboxDateAutori.TabStop = false;
            // 
            // lblBiografie
            // 
            lblBiografie.Location = new Point(6, 127);
            lblBiografie.Name = "lblBiografie";
            lblBiografie.Size = new Size(554, 386);
            lblBiografie.TabIndex = 2;
            lblBiografie.Text = "Biografie";
            // 
            // lblNume
            // 
            lblNume.AutoSize = true;
            lblNume.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNume.Location = new Point(6, 35);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(128, 47);
            lblNume.TabIndex = 1;
            lblNume.Text = "Nume";
            // 
            // UCAutori_B
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gboxDateAutori);
            Controls.Add(btnSterge);
            Controls.Add(btnModifica);
            Controls.Add(btnAdauga);
            Controls.Add(lboxAutori);
            Name = "UCAutori_B";
            Size = new Size(1100, 600);
            gboxDateAutori.ResumeLayout(false);
            gboxDateAutori.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lboxAutori;
        private Button btnAdauga;
        private Button btnModifica;
        private Button btnSterge;
        private GroupBox gboxDateAutori;
        private Label lblBiografie;
        private Label lblNume;
    }
}
