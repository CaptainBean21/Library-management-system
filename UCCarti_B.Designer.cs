namespace ProiectMSOA
{
    partial class UCCarti_B
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
            dgvCarti = new DataGridView();
            btnModifica = new Button();
            btnSterge = new Button();
            btnAdauga = new Button();
            lblOrdoneaza = new Label();
            cboxOrdoneaza = new ComboBox();
            label1 = new Label();
            cboxFiltrare = new ComboBox();
            txtboxFiltrare = new TextBox();
            btnAplica = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarti).BeginInit();
            SuspendLayout();
            // 
            // dgvCarti
            // 
            dgvCarti.AllowUserToAddRows = false;
            dgvCarti.AllowUserToDeleteRows = false;
            dgvCarti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarti.Location = new Point(0, 0);
            dgvCarti.MultiSelect = false;
            dgvCarti.Name = "dgvCarti";
            dgvCarti.ReadOnly = true;
            dgvCarti.RowHeadersWidth = 82;
            dgvCarti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarti.Size = new Size(892, 600);
            dgvCarti.TabIndex = 0;
            dgvCarti.DataBindingComplete += dgvCarti_DataBindingComplete;
            dgvCarti.RowPostPaint += dgvCarti_RowPostPaint;
            dgvCarti.SelectionChanged += dgvCarti_SelectionChanged;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(922, 34);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 46);
            btnModifica.TabIndex = 1;
            btnModifica.Text = "Modifică";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(922, 98);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(150, 46);
            btnSterge.TabIndex = 2;
            btnSterge.Text = "Sterge";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(922, 521);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(150, 46);
            btnAdauga.TabIndex = 3;
            btnAdauga.Text = "Adaugă";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // lblOrdoneaza
            // 
            lblOrdoneaza.AutoSize = true;
            lblOrdoneaza.Location = new Point(898, 207);
            lblOrdoneaza.Name = "lblOrdoneaza";
            lblOrdoneaza.Size = new Size(196, 32);
            lblOrdoneaza.TabIndex = 4;
            lblOrdoneaza.Text = "Ordonează după:";
            // 
            // cboxOrdoneaza
            // 
            cboxOrdoneaza.FormattingEnabled = true;
            cboxOrdoneaza.Location = new Point(895, 242);
            cboxOrdoneaza.Name = "cboxOrdoneaza";
            cboxOrdoneaza.Size = new Size(202, 40);
            cboxOrdoneaza.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(911, 285);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 6;
            label1.Text = "Filtrează după:";
            // 
            // cboxFiltrare
            // 
            cboxFiltrare.FormattingEnabled = true;
            cboxFiltrare.Location = new Point(895, 320);
            cboxFiltrare.Name = "cboxFiltrare";
            cboxFiltrare.Size = new Size(202, 40);
            cboxFiltrare.TabIndex = 7;
            // 
            // txtboxFiltrare
            // 
            txtboxFiltrare.Location = new Point(896, 366);
            txtboxFiltrare.Name = "txtboxFiltrare";
            txtboxFiltrare.Size = new Size(200, 39);
            txtboxFiltrare.TabIndex = 8;
            txtboxFiltrare.TextChanged += txtboxFiltrare_TextChanged;
            // 
            // btnAplica
            // 
            btnAplica.Location = new Point(922, 411);
            btnAplica.Name = "btnAplica";
            btnAplica.Size = new Size(150, 46);
            btnAplica.TabIndex = 9;
            btnAplica.Text = "Aplică";
            btnAplica.UseVisualStyleBackColor = true;
            btnAplica.Click += btnAplica_Click;
            // 
            // UCCarti_B
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAplica);
            Controls.Add(txtboxFiltrare);
            Controls.Add(cboxFiltrare);
            Controls.Add(label1);
            Controls.Add(cboxOrdoneaza);
            Controls.Add(lblOrdoneaza);
            Controls.Add(btnAdauga);
            Controls.Add(btnSterge);
            Controls.Add(btnModifica);
            Controls.Add(dgvCarti);
            Name = "UCCarti_B";
            Size = new Size(1100, 600);
            ((System.ComponentModel.ISupportInitialize)dgvCarti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarti;
        private Button btnModifica;
        private Button btnSterge;
        private Button btnAdauga;
        private Label lblOrdoneaza;
        private ComboBox cboxOrdoneaza;
        private Label label1;
        private ComboBox cboxFiltrare;
        private TextBox txtboxFiltrare;
        private Button btnAplica;
    }
}
