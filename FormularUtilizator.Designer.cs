namespace ProiectMSOA
{
    partial class FormularUtilizator
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
            btnInapoi = new Button();
            btnSalveaza = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtboxNume = new TextBox();
            txtboxEmail = new TextBox();
            txtboxParola = new TextBox();
            cboxRol = new ComboBox();
            SuspendLayout();
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(307, 406);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(150, 46);
            btnInapoi.TabIndex = 7;
            btnInapoi.Text = "Înapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // btnSalveaza
            // 
            btnSalveaza.Location = new Point(90, 406);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(150, 46);
            btnSalveaza.TabIndex = 6;
            btnSalveaza.Text = "Salvează";
            btnSalveaza.UseVisualStyleBackColor = true;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 111);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 8;
            label1.Text = "Nume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 165);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 9;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 222);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 10;
            label3.Text = "Parola:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 279);
            label4.Name = "label4";
            label4.Size = new Size(52, 32);
            label4.TabIndex = 11;
            label4.Text = "Rol:";
            // 
            // txtboxNume
            // 
            txtboxNume.Location = new Point(186, 111);
            txtboxNume.Name = "txtboxNume";
            txtboxNume.Size = new Size(200, 39);
            txtboxNume.TabIndex = 12;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(186, 165);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(200, 39);
            txtboxEmail.TabIndex = 13;
            // 
            // txtboxParola
            // 
            txtboxParola.Location = new Point(186, 222);
            txtboxParola.Name = "txtboxParola";
            txtboxParola.Size = new Size(200, 39);
            txtboxParola.TabIndex = 14;
            // 
            // cboxRol
            // 
            cboxRol.FormattingEnabled = true;
            cboxRol.Items.AddRange(new object[] { "Admin", "Bibliotecar", "Client" });
            cboxRol.Location = new Point(186, 279);
            cboxRol.Name = "cboxRol";
            cboxRol.Size = new Size(200, 40);
            cboxRol.TabIndex = 15;
            // 
            // FormularUtilizator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 532);
            Controls.Add(cboxRol);
            Controls.Add(txtboxParola);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxNume);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInapoi);
            Controls.Add(btnSalveaza);
            Name = "FormularUtilizator";
            Text = "FormularUtilizator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInapoi;
        private Button btnSalveaza;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtboxNume;
        private TextBox txtboxEmail;
        private TextBox txtboxParola;
        private ComboBox cboxRol;
    }
}