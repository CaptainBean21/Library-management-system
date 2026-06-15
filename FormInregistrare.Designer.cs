namespace ProiectMSOA
{
    partial class FormInregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInregistrare));
            label1 = new Label();
            lblNume = new Label();
            lblEmail = new Label();
            lblParola = new Label();
            txtboxNume = new TextBox();
            txtboxEmail = new TextBox();
            txtboxParola = new TextBox();
            btnConfirm = new Button();
            linkInapoi = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(188, 333);
            label1.Name = "label1";
            label1.Size = new Size(362, 57);
            label1.TabIndex = 0;
            label1.Text = "Bine ai venit!";
            // 
            // lblNume
            // 
            lblNume.AutoSize = true;
            lblNume.BackColor = Color.Transparent;
            lblNume.Font = new Font("Stencil", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNume.ForeColor = Color.FromArgb(64, 0, 64);
            lblNume.Location = new Point(224, 466);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(96, 32);
            lblNume.TabIndex = 1;
            lblNume.Text = "Nume:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Stencil", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(64, 0, 64);
            lblEmail.Location = new Point(218, 526);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(102, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Transparent;
            lblParola.Font = new Font("Stencil", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParola.ForeColor = Color.FromArgb(64, 0, 64);
            lblParola.Location = new Point(196, 583);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(124, 32);
            lblParola.TabIndex = 3;
            lblParola.Text = "Parola:";
            // 
            // txtboxNume
            // 
            txtboxNume.Location = new Point(326, 462);
            txtboxNume.Name = "txtboxNume";
            txtboxNume.Size = new Size(182, 39);
            txtboxNume.TabIndex = 4;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(326, 519);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(182, 39);
            txtboxEmail.TabIndex = 5;
            // 
            // txtboxParola
            // 
            txtboxParola.Location = new Point(326, 576);
            txtboxParola.Name = "txtboxParola";
            txtboxParola.PasswordChar = '*';
            txtboxParola.Size = new Size(182, 39);
            txtboxParola.TabIndex = 6;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(64, 0, 64);
            btnConfirm.BackgroundImage = (Image)resources.GetObject("btnConfirm.BackgroundImage");
            btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnConfirm.FlatAppearance.BorderSize = 4;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.FromArgb(64, 0, 64);
            btnConfirm.Location = new Point(231, 688);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(267, 46);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // linkInapoi
            // 
            linkInapoi.AutoSize = true;
            linkInapoi.BackColor = Color.Transparent;
            linkInapoi.Font = new Font("SimSun-ExtB", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkInapoi.LinkColor = Color.FromArgb(64, 0, 64);
            linkInapoi.Location = new Point(315, 783);
            linkInapoi.Name = "linkInapoi";
            linkInapoi.Size = new Size(102, 27);
            linkInapoi.TabIndex = 10;
            linkInapoi.TabStop = true;
            linkInapoi.Text = "Inapoi";
            linkInapoi.LinkClicked += linkInapoi_LinkClicked;
            // 
            // FormInregistrare
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(721, 1080);
            Controls.Add(linkInapoi);
            Controls.Add(btnConfirm);
            Controls.Add(txtboxParola);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxNume);
            Controls.Add(lblParola);
            Controls.Add(lblEmail);
            Controls.Add(lblNume);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormInregistrare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInregistrare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNume;
        private Label lblEmail;
        private Label lblParola;
        private TextBox txtboxNume;
        private TextBox txtboxEmail;
        private TextBox txtboxParola;
        private Button btnConfirm;
        private LinkLabel linkInapoi;
    }
}