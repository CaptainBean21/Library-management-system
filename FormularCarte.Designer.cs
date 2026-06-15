namespace ProiectMSOA
{
    partial class FormularCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularCarte));
            lblTitlu = new Label();
            lblAutor = new Label();
            lblEditura = new Label();
            lblCategorie = new Label();
            lblStoc = new Label();
            txtboxTitlu = new TextBox();
            cboxAutor = new ComboBox();
            txtboxEditura = new TextBox();
            txtboxCategorie = new TextBox();
            nupdStoc = new NumericUpDown();
            btnSalveaza = new Button();
            btnInapoi = new Button();
            ((System.ComponentModel.ISupportInitialize)nupdStoc).BeginInit();
            SuspendLayout();
            // 
            // lblTitlu
            // 
            lblTitlu.AutoSize = true;
            lblTitlu.BackColor = Color.Transparent;
            lblTitlu.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitlu.ForeColor = Color.FromArgb(64, 0, 64);
            lblTitlu.Location = new Point(239, 307);
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Size = new Size(104, 34);
            lblTitlu.TabIndex = 5;
            lblTitlu.Text = "Titlu:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutor.ForeColor = Color.FromArgb(64, 0, 64);
            lblAutor.Location = new Point(226, 389);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(117, 34);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor:";
            // 
            // lblEditura
            // 
            lblEditura.AutoSize = true;
            lblEditura.BackColor = Color.Transparent;
            lblEditura.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditura.ForeColor = Color.FromArgb(64, 0, 64);
            lblEditura.Location = new Point(197, 347);
            lblEditura.Name = "lblEditura";
            lblEditura.Size = new Size(146, 34);
            lblEditura.TabIndex = 7;
            lblEditura.Text = "Editura:";
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.BackColor = Color.Transparent;
            lblCategorie.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategorie.ForeColor = Color.FromArgb(64, 0, 64);
            lblCategorie.Location = new Point(163, 432);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(177, 34);
            lblCategorie.TabIndex = 8;
            lblCategorie.Text = "Categorie:";
            // 
            // lblStoc
            // 
            lblStoc.AutoSize = true;
            lblStoc.BackColor = Color.Transparent;
            lblStoc.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStoc.ForeColor = Color.FromArgb(64, 0, 64);
            lblStoc.Location = new Point(248, 472);
            lblStoc.Name = "lblStoc";
            lblStoc.Size = new Size(92, 34);
            lblStoc.TabIndex = 9;
            lblStoc.Text = "Stoc:";
            // 
            // txtboxTitlu
            // 
            txtboxTitlu.Location = new Point(349, 302);
            txtboxTitlu.Name = "txtboxTitlu";
            txtboxTitlu.Size = new Size(198, 39);
            txtboxTitlu.TabIndex = 10;
            // 
            // cboxAutor
            // 
            cboxAutor.FormattingEnabled = true;
            cboxAutor.Location = new Point(347, 386);
            cboxAutor.Name = "cboxAutor";
            cboxAutor.Size = new Size(174, 40);
            cboxAutor.TabIndex = 11;
            // 
            // txtboxEditura
            // 
            txtboxEditura.Location = new Point(349, 344);
            txtboxEditura.Name = "txtboxEditura";
            txtboxEditura.Size = new Size(198, 39);
            txtboxEditura.TabIndex = 12;
            // 
            // txtboxCategorie
            // 
            txtboxCategorie.Location = new Point(347, 429);
            txtboxCategorie.Name = "txtboxCategorie";
            txtboxCategorie.Size = new Size(198, 39);
            txtboxCategorie.TabIndex = 13;
            // 
            // nupdStoc
            // 
            nupdStoc.Location = new Point(346, 470);
            nupdStoc.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nupdStoc.Name = "nupdStoc";
            nupdStoc.Size = new Size(128, 39);
            nupdStoc.TabIndex = 14;
            // 
            // btnSalveaza
            // 
            btnSalveaza.BackColor = Color.FromArgb(64, 0, 64);
            btnSalveaza.BackgroundImage = (Image)resources.GetObject("btnSalveaza.BackgroundImage");
            btnSalveaza.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnSalveaza.FlatAppearance.BorderSize = 4;
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalveaza.ForeColor = Color.FromArgb(64, 0, 64);
            btnSalveaza.Location = new Point(253, 652);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(226, 46);
            btnSalveaza.TabIndex = 15;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // btnInapoi
            // 
            btnInapoi.BackColor = Color.FromArgb(64, 0, 64);
            btnInapoi.BackgroundImage = (Image)resources.GetObject("btnInapoi.BackgroundImage");
            btnInapoi.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnInapoi.FlatAppearance.BorderSize = 4;
            btnInapoi.FlatStyle = FlatStyle.Flat;
            btnInapoi.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInapoi.ForeColor = Color.FromArgb(64, 0, 64);
            btnInapoi.Location = new Point(284, 743);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(161, 46);
            btnInapoi.TabIndex = 16;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = false;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // FormularCarte
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(721, 1080);
            Controls.Add(btnInapoi);
            Controls.Add(btnSalveaza);
            Controls.Add(nupdStoc);
            Controls.Add(txtboxCategorie);
            Controls.Add(txtboxEditura);
            Controls.Add(cboxAutor);
            Controls.Add(txtboxTitlu);
            Controls.Add(lblStoc);
            Controls.Add(lblCategorie);
            Controls.Add(lblEditura);
            Controls.Add(lblAutor);
            Controls.Add(lblTitlu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormularCarte";
            Text = "FormularCarte";
            ((System.ComponentModel.ISupportInitialize)nupdStoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitlu;
        private Label lblAutor;
        private Label lblEditura;
        private Label lblCategorie;
        private Label lblStoc;
        private TextBox txtboxTitlu;
        private ComboBox cboxAutor;
        private TextBox txtboxEditura;
        private TextBox txtboxCategorie;
        private NumericUpDown nupdStoc;
        private Button btnSalveaza;
        private Button btnInapoi;
    }
}