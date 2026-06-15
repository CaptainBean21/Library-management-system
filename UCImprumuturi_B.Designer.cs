namespace ProiectMSOA
{
    partial class UCImprumuturi_B
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
            dgvImprumuturi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblNume = new Label();
            lblEmail = new Label();
            btnRestituit = new Button();
            btnPlatit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImprumuturi).BeginInit();
            SuspendLayout();
            // 
            // dgvImprumuturi
            // 
            dgvImprumuturi.AllowUserToAddRows = false;
            dgvImprumuturi.AllowUserToDeleteRows = false;
            dgvImprumuturi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImprumuturi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImprumuturi.Location = new Point(0, 0);
            dgvImprumuturi.MultiSelect = false;
            dgvImprumuturi.Name = "dgvImprumuturi";
            dgvImprumuturi.ReadOnly = true;
            dgvImprumuturi.RowHeadersWidth = 82;
            dgvImprumuturi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImprumuturi.Size = new Size(692, 600);
            dgvImprumuturi.TabIndex = 0;
            dgvImprumuturi.DataBindingComplete += dgvImprumuturi_DataBindingComplete;
            dgvImprumuturi.RowPostPaint += dgvImprumuturi_RowPostPaint;
            dgvImprumuturi.SelectionChanged += dgvImprumuturi_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13F);
            label1.Location = new Point(712, 137);
            label1.Name = "label1";
            label1.Size = new Size(124, 42);
            label1.TabIndex = 1;
            label1.Text = "Nume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13F);
            label2.Location = new Point(704, 190);
            label2.Name = "label2";
            label2.Size = new Size(132, 42);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // lblNume
            // 
            lblNume.AutoSize = true;
            lblNume.Font = new Font("Stencil", 13F);
            lblNume.Location = new Point(842, 137);
            lblNume.Name = "lblNume";
            lblNume.Size = new Size(51, 42);
            lblNume.TabIndex = 3;
            lblNume.Text = "...";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Stencil", 13F);
            lblEmail.Location = new Point(842, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 42);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "...";
            // 
            // btnRestituit
            // 
            btnRestituit.Location = new Point(774, 381);
            btnRestituit.Name = "btnRestituit";
            btnRestituit.Size = new Size(239, 71);
            btnRestituit.TabIndex = 5;
            btnRestituit.Text = "Restituit";
            btnRestituit.UseVisualStyleBackColor = true;
            btnRestituit.Click += btnRestituit_Click;
            // 
            // btnPlatit
            // 
            btnPlatit.Location = new Point(774, 473);
            btnPlatit.Name = "btnPlatit";
            btnPlatit.Size = new Size(239, 71);
            btnPlatit.TabIndex = 6;
            btnPlatit.Text = "Plătit";
            btnPlatit.UseVisualStyleBackColor = true;
            btnPlatit.Click += btnPlatit_Click;
            // 
            // UCImprumuturi_B
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPlatit);
            Controls.Add(btnRestituit);
            Controls.Add(lblEmail);
            Controls.Add(lblNume);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvImprumuturi);
            Name = "UCImprumuturi_B";
            Size = new Size(1100, 600);
            ((System.ComponentModel.ISupportInitialize)dgvImprumuturi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvImprumuturi;
        private Label label1;
        private Label label2;
        private Label lblNume;
        private Label lblEmail;
        private Button btnRestituit;
        private Button btnPlatit;
    }
}
