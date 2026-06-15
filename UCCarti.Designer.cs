namespace ProiectMSOA
{
    partial class UCCarti
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
            lstboxCarti = new ListBox();
            cboxOrdonare = new ComboBox();
            lblOrdonare = new Label();
            btnOrdonare = new Button();
            gbox = new GroupBox();
            btnRezerva = new Button();
            label5 = new Label();
            dtpDataRez = new DateTimePicker();
            lblStoc = new Label();
            lblCategorie = new Label();
            lblEditura = new Label();
            lblAutor = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTitlu = new Label();
            lblFiltrare = new Label();
            cboxFiltrare = new ComboBox();
            txtboxFiltrare = new TextBox();
            gbox.SuspendLayout();
            SuspendLayout();
            // 
            // lstboxCarti
            // 
            lstboxCarti.FormattingEnabled = true;
            lstboxCarti.Location = new Point(14, 15);
            lstboxCarti.Name = "lstboxCarti";
            lstboxCarti.Size = new Size(536, 452);
            lstboxCarti.TabIndex = 1;
            lstboxCarti.SelectedIndexChanged += lstboxCarti_SelectedIndexChanged;
            // 
            // cboxOrdonare
            // 
            cboxOrdonare.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxOrdonare.FormattingEnabled = true;
            cboxOrdonare.Location = new Point(216, 491);
            cboxOrdonare.Name = "cboxOrdonare";
            cboxOrdonare.Size = new Size(214, 40);
            cboxOrdonare.TabIndex = 2;
            // 
            // lblOrdonare
            // 
            lblOrdonare.AutoSize = true;
            lblOrdonare.Location = new Point(14, 494);
            lblOrdonare.Name = "lblOrdonare";
            lblOrdonare.Size = new Size(196, 32);
            lblOrdonare.TabIndex = 3;
            lblOrdonare.Text = "Ordonează după:";
            // 
            // btnOrdonare
            // 
            btnOrdonare.Location = new Point(436, 489);
            btnOrdonare.Name = "btnOrdonare";
            btnOrdonare.Size = new Size(114, 42);
            btnOrdonare.TabIndex = 4;
            btnOrdonare.Text = "Aplică";
            btnOrdonare.UseVisualStyleBackColor = true;
            btnOrdonare.Click += btnOrdonare_Click;
            // 
            // gbox
            // 
            gbox.Controls.Add(btnRezerva);
            gbox.Controls.Add(label5);
            gbox.Controls.Add(dtpDataRez);
            gbox.Controls.Add(lblStoc);
            gbox.Controls.Add(lblCategorie);
            gbox.Controls.Add(lblEditura);
            gbox.Controls.Add(lblAutor);
            gbox.Controls.Add(label4);
            gbox.Controls.Add(label3);
            gbox.Controls.Add(label2);
            gbox.Controls.Add(label1);
            gbox.Controls.Add(lblTitlu);
            gbox.Location = new Point(556, 15);
            gbox.Name = "gbox";
            gbox.Size = new Size(400, 516);
            gbox.TabIndex = 5;
            gbox.TabStop = false;
            // 
            // btnRezerva
            // 
            btnRezerva.Location = new Point(127, 447);
            btnRezerva.Name = "btnRezerva";
            btnRezerva.Size = new Size(150, 46);
            btnRezerva.TabIndex = 6;
            btnRezerva.Text = "Rezervă";
            btnRezerva.UseVisualStyleBackColor = true;
            btnRezerva.Click += btnRezerva_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 389);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 10;
            label5.Text = "Data Rezervării:";
            // 
            // dtpDataRez
            // 
            dtpDataRez.Format = DateTimePickerFormat.Short;
            dtpDataRez.Location = new Point(201, 389);
            dtpDataRez.Name = "dtpDataRez";
            dtpDataRez.Size = new Size(193, 39);
            dtpDataRez.TabIndex = 6;
            dtpDataRez.ValueChanged += dtpDataRez_ValueChanged;
            // 
            // lblStoc
            // 
            lblStoc.AutoSize = true;
            lblStoc.Location = new Point(87, 297);
            lblStoc.Name = "lblStoc";
            lblStoc.Size = new Size(29, 32);
            lblStoc.TabIndex = 9;
            lblStoc.Text = "...";
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Location = new Point(145, 242);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(29, 32);
            lblCategorie.TabIndex = 8;
            lblCategorie.Text = "...";
            // 
            // lblEditura
            // 
            lblEditura.AutoSize = true;
            lblEditura.Location = new Point(116, 193);
            lblEditura.Name = "lblEditura";
            lblEditura.Size = new Size(29, 32);
            lblEditura.TabIndex = 7;
            lblEditura.Text = "...";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(101, 144);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(29, 32);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 297);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 4;
            label4.Text = "Stoc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 242);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 3;
            label3.Text = "Categorie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 193);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 2;
            label2.Text = "Editura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 144);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "Autor:";
            // 
            // lblTitlu
            // 
            lblTitlu.AutoSize = true;
            lblTitlu.Dock = DockStyle.Top;
            lblTitlu.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitlu.Location = new Point(3, 35);
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Size = new Size(132, 47);
            lblTitlu.TabIndex = 0;
            lblTitlu.Text = "Titlu";
            // 
            // lblFiltrare
            // 
            lblFiltrare.AutoSize = true;
            lblFiltrare.Location = new Point(42, 550);
            lblFiltrare.Name = "lblFiltrare";
            lblFiltrare.Size = new Size(168, 32);
            lblFiltrare.TabIndex = 6;
            lblFiltrare.Text = "Filtrează după:";
            // 
            // cboxFiltrare
            // 
            cboxFiltrare.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxFiltrare.FormattingEnabled = true;
            cboxFiltrare.Location = new Point(216, 547);
            cboxFiltrare.Name = "cboxFiltrare";
            cboxFiltrare.Size = new Size(214, 40);
            cboxFiltrare.TabIndex = 7;
            // 
            // txtboxFiltrare
            // 
            txtboxFiltrare.Location = new Point(437, 547);
            txtboxFiltrare.Name = "txtboxFiltrare";
            txtboxFiltrare.Size = new Size(200, 39);
            txtboxFiltrare.TabIndex = 8;
            txtboxFiltrare.TextChanged += txtboxFiltrare_TextChanged;
            // 
            // UCCarti
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtboxFiltrare);
            Controls.Add(cboxFiltrare);
            Controls.Add(lblFiltrare);
            Controls.Add(gbox);
            Controls.Add(btnOrdonare);
            Controls.Add(lblOrdonare);
            Controls.Add(cboxOrdonare);
            Controls.Add(lstboxCarti);
            Name = "UCCarti";
            Size = new Size(970, 600);
            gbox.ResumeLayout(false);
            gbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstboxCarti;
        private ComboBox cboxOrdonare;
        private Label lblOrdonare;
        private Button btnOrdonare;
        private GroupBox gbox;
        private Label lblTitlu;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label lblStoc;
        private Label lblCategorie;
        private Label lblEditura;
        private Label lblAutor;
        private Button btnRezerva;
        private Label label5;
        private DateTimePicker dtpDataRez;
        private Label lblFiltrare;
        private ComboBox cboxFiltrare;
        private TextBox txtboxFiltrare;
    }
}
