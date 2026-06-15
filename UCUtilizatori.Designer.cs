namespace ProiectMSOA
{
    partial class UCUtilizatori
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
            lboxUtilizatori = new ListBox();
            btnSterge = new Button();
            btnModifica = new Button();
            btnAdauga = new Button();
            gboxDate = new GroupBox();
            lblParola = new Label();
            lblEmail = new Label();
            lblRol = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNume = new Label();
            gboxDate.SuspendLayout();
            SuspendLayout();
            // 
            // lboxUtilizatori
            // 
            lboxUtilizatori.FormattingEnabled = true;
            lboxUtilizatori.Location = new Point(0, 0);
            lboxUtilizatori.Name = "lboxUtilizatori";
            lboxUtilizatori.Size = new Size(651, 452);
            lboxUtilizatori.TabIndex = 0;
            lboxUtilizatori.SelectedIndexChanged += lboxUtilizatori_SelectedIndexChanged;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(23, 476);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(150, 46);
            btnSterge.TabIndex = 1;
            btnSterge.Text = "Șterge";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(200, 476);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 46);
            btnModifica.TabIndex = 2;
            btnModifica.Text = "Modifică";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(376, 476);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 3;
            btnAdauga.Text = "Adaugă";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // gboxDate
            // 
            gboxDate.Controls.Add(lblParola);
            gboxDate.Controls.Add(lblEmail);
            gboxDate.Controls.Add(lblRol);
            gboxDate.Controls.Add(label2);
            gboxDate.Controls.Add(label1);
            gboxDate.Controls.Add(lblNume);
            gboxDate.Location = new Point(657, 3);
            gboxDate.Name = "gboxDate";
            gboxDate.Size = new Size(440, 452);
            gboxDate.TabIndex = 5;
            gboxDate.TabStop = false;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Location = new Point(95, 183);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(29, 32);
            lblParola.TabIndex = 7;
            lblParola.Text = "...";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(29, 32);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "...";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(6, 385);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(94, 47);
            lblRol.TabIndex = 4;
            lblRol.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 183);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 3;
            label2.Text = "Parola:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 127);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 2;
            label1.Text = "Email:";
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
            // UCUtilizatori
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gboxDate);
            Controls.Add(btnAdauga);
            Controls.Add(btnModifica);
            Controls.Add(btnSterge);
            Controls.Add(lboxUtilizatori);
            Name = "UCUtilizatori";
            Size = new Size(1100, 550);
            gboxDate.ResumeLayout(false);
            gboxDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lboxUtilizatori;
        private Button btnSterge;
        private Button btnModifica;
        private Button btnAdauga;
        private GroupBox gboxDate;
        private Label label2;
        private Label label1;
        private Label lblNume;
        private Label lblParola;
        private Label lblEmail;
        private Label lblRol;
    }
}
