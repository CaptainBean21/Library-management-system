namespace ProiectMSOA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtboxNume = new TextBox();
            btnAutentifica = new Button();
            txtboxParola = new TextBox();
            label3 = new Label();
            linkContNou = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(189, 249);
            label1.MaximumSize = new Size(400, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 114);
            label1.TabIndex = 0;
            label1.Text = "Alege Utilizatorul";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(272, 433);
            label2.Name = "label2";
            label2.Size = new Size(197, 34);
            label2.TabIndex = 4;
            label2.Text = "Nume/email:";
            // 
            // txtboxNume
            // 
            txtboxNume.Location = new Point(232, 470);
            txtboxNume.Name = "txtboxNume";
            txtboxNume.Size = new Size(267, 39);
            txtboxNume.TabIndex = 5;
            // 
            // btnAutentifica
            // 
            btnAutentifica.BackColor = Color.FromArgb(64, 0, 64);
            btnAutentifica.BackgroundImage = (Image)resources.GetObject("btnAutentifica.BackgroundImage");
            btnAutentifica.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnAutentifica.FlatAppearance.BorderSize = 4;
            btnAutentifica.FlatStyle = FlatStyle.Flat;
            btnAutentifica.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAutentifica.ForeColor = Color.FromArgb(64, 0, 64);
            btnAutentifica.Location = new Point(232, 720);
            btnAutentifica.Name = "btnAutentifica";
            btnAutentifica.Size = new Size(267, 46);
            btnAutentifica.TabIndex = 6;
            btnAutentifica.Text = "Autentificare";
            btnAutentifica.UseVisualStyleBackColor = false;
            btnAutentifica.Click += btnAutentifica_Click;
            // 
            // txtboxParola
            // 
            txtboxParola.Location = new Point(232, 568);
            txtboxParola.Name = "txtboxParola";
            txtboxParola.PasswordChar = '*';
            txtboxParola.Size = new Size(267, 39);
            txtboxParola.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 64);
            label3.Location = new Point(298, 531);
            label3.Name = "label3";
            label3.Size = new Size(131, 34);
            label3.TabIndex = 7;
            label3.Text = "Parola:";
            // 
            // linkContNou
            // 
            linkContNou.AutoSize = true;
            linkContNou.BackColor = Color.Transparent;
            linkContNou.Font = new Font("SimSun-ExtB", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkContNou.LinkColor = Color.FromArgb(64, 0, 64);
            linkContNou.Location = new Point(284, 797);
            linkContNou.Name = "linkContNou";
            linkContNou.Size = new Size(162, 27);
            linkContNou.TabIndex = 9;
            linkContNou.TabStop = true;
            linkContNou.Text = "Client Nou";
            linkContNou.LinkClicked += linkContNou_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(721, 1080);
            Controls.Add(linkContNou);
            Controls.Add(txtboxParola);
            Controls.Add(label3);
            Controls.Add(btnAutentifica);
            Controls.Add(txtboxNume);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtboxNume;
        private Button btnAutentifica;
        private TextBox txtboxParola;
        private Label label3;
        private LinkLabel linkContNou;
    }
}
