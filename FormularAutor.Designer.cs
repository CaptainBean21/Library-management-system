namespace ProiectMSOA
{
    partial class FormularAutor
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
            lblNume = new Label();
            txtboxNume = new TextBox();
            label1 = new Label();
            txtboxBio = new TextBox();
            btnSalveaza = new Button();
            btnInapoi = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNume
            // 
            lblNume.AutoSize = true;
            lblNume.Location = new Point(122, 56);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(85, 32);
            lblNume.TabIndex = 0;
            lblNume.Text = "Nume:";
            // 
            // txtboxNume
            // 
            txtboxNume.Location = new Point(213, 56);
            txtboxNume.Name = "txtboxNume";
            txtboxNume.Size = new Size(367, 39);
            txtboxNume.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 122);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 2;
            label1.Text = "Biografie:";
            // 
            // txtboxBio
            // 
            txtboxBio.Location = new Point(213, 122);
            txtboxBio.Multiline = true;
            txtboxBio.Name = "txtboxBio";
            txtboxBio.Size = new Size(367, 179);
            txtboxBio.TabIndex = 3;
            // 
            // btnSalveaza
            // 
            btnSalveaza.Location = new Point(213, 363);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(150, 46);
            btnSalveaza.TabIndex = 4;
            btnSalveaza.Text = "Salvează";
            btnSalveaza.UseVisualStyleBackColor = true;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(430, 363);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(150, 46);
            btnInapoi.TabIndex = 5;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 154);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 6;
            label2.Text = "(Opțional)";
            // 
            // FormularAutor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnInapoi);
            Controls.Add(btnSalveaza);
            Controls.Add(txtboxBio);
            Controls.Add(label1);
            Controls.Add(txtboxNume);
            Controls.Add(lblNume);
            Name = "FormularAutor";
            Text = "FormularAutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNume;
        private TextBox txtboxNume;
        private Label label1;
        private TextBox txtboxBio;
        private Button btnSalveaza;
        private Button btnInapoi;
        private Label label2;
    }
}