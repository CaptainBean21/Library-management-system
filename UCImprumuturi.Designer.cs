namespace ProiectMSOA
{
    partial class UCImprumuturi
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
            btnPlateste = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImprumuturi).BeginInit();
            SuspendLayout();
            // 
            // dgvImprumuturi
            // 
            dgvImprumuturi.AllowUserToAddRows = false;
            dgvImprumuturi.AllowUserToDeleteRows = false;
            dgvImprumuturi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImprumuturi.BackgroundColor = SystemColors.Menu;
            dgvImprumuturi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImprumuturi.Location = new Point(0, 0);
            dgvImprumuturi.MultiSelect = false;
            dgvImprumuturi.Name = "dgvImprumuturi";
            dgvImprumuturi.ReadOnly = true;
            dgvImprumuturi.RowHeadersWidth = 82;
            dgvImprumuturi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImprumuturi.Size = new Size(970, 509);
            dgvImprumuturi.TabIndex = 0;
            dgvImprumuturi.DataBindingComplete += dgvImprumuturi_DataBindingComplete;
            dgvImprumuturi.RowPostPaint += dgvImprumuturi_RowPostPaint;
            dgvImprumuturi.SelectionChanged += dgvImprumuturi_SelectionChanged;
            // 
            // btnPlateste
            // 
            btnPlateste.Location = new Point(799, 532);
            btnPlateste.Name = "btnPlateste";
            btnPlateste.Size = new Size(150, 46);
            btnPlateste.TabIndex = 1;
            btnPlateste.Text = "Plateste";
            btnPlateste.UseVisualStyleBackColor = true;
            btnPlateste.Click += btnPlateste_Click;
            // 
            // UCImprumuturi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPlateste);
            Controls.Add(dgvImprumuturi);
            Name = "UCImprumuturi";
            Size = new Size(970, 600);
            Load += UCImprumuturi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImprumuturi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvImprumuturi;
        private Button btnPlateste;
    }
}
