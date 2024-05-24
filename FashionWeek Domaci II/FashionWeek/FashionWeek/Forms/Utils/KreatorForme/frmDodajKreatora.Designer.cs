namespace FashionWeek.Forms.Utils.KreatorForme
{
    partial class frmDodajKreatora
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
            txtZemljaPorekla = new TextBox();
            cmbPol = new ComboBox();
            dtpDatumRodjenja = new DateTimePicker();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtMBR = new TextBox();
            lblDatumRodjenja = new Label();
            lblPol = new Label();
            lblZemljaPorekla = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            lblMBR = new Label();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // txtZemljaPorekla
            // 
            txtZemljaPorekla.Location = new Point(108, 150);
            txtZemljaPorekla.Name = "txtZemljaPorekla";
            txtZemljaPorekla.Size = new Size(116, 23);
            txtZemljaPorekla.TabIndex = 30;
            // 
            // cmbPol
            // 
            cmbPol.FormattingEnabled = true;
            cmbPol.Items.AddRange(new object[] { "M", "Z" });
            cmbPol.Location = new Point(108, 121);
            cmbPol.Name = "cmbPol";
            cmbPol.Size = new Size(116, 23);
            cmbPol.TabIndex = 28;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(107, 93);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 27;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(108, 38);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(116, 23);
            txtIme.TabIndex = 26;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(108, 67);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(116, 23);
            txtPrezime.TabIndex = 25;
            // 
            // txtMBR
            // 
            txtMBR.Location = new Point(108, 9);
            txtMBR.Name = "txtMBR";
            txtMBR.Size = new Size(148, 23);
            txtMBR.TabIndex = 24;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.BackColor = Color.Red;
            lblDatumRodjenja.Location = new Point(12, 99);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(89, 15);
            lblDatumRodjenja.TabIndex = 23;
            lblDatumRodjenja.Text = "Datum rođenja:";
            lblDatumRodjenja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPol
            // 
            lblPol.AutoSize = true;
            lblPol.BackColor = Color.Red;
            lblPol.Location = new Point(12, 124);
            lblPol.Name = "lblPol";
            lblPol.Size = new Size(27, 15);
            lblPol.TabIndex = 22;
            lblPol.Text = "Pol:";
            lblPol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZemljaPorekla
            // 
            lblZemljaPorekla.AutoSize = true;
            lblZemljaPorekla.Location = new Point(12, 153);
            lblZemljaPorekla.Name = "lblZemljaPorekla";
            lblZemljaPorekla.Size = new Size(88, 15);
            lblZemljaPorekla.TabIndex = 21;
            lblZemljaPorekla.Text = "Zemlja porekla:";
            lblZemljaPorekla.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.BackColor = Color.Red;
            lblIme.Location = new Point(12, 41);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 19;
            lblIme.Text = "Ime:";
            lblIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.BackColor = Color.Red;
            lblPrezime.Location = new Point(12, 70);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 18;
            lblPrezime.Text = "Prezime:";
            lblPrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMBR
            // 
            lblMBR.AutoSize = true;
            lblMBR.BackColor = Color.Red;
            lblMBR.Location = new Point(12, 9);
            lblMBR.Name = "lblMBR";
            lblMBR.Size = new Size(35, 15);
            lblMBR.TabIndex = 17;
            lblMBR.Text = "MBR:";
            lblMBR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(313, 145);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 32;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(313, 116);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 31;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmDodajKreatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 181);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtZemljaPorekla);
            Controls.Add(cmbPol);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtIme);
            Controls.Add(txtPrezime);
            Controls.Add(txtMBR);
            Controls.Add(lblDatumRodjenja);
            Controls.Add(lblPol);
            Controls.Add(lblZemljaPorekla);
            Controls.Add(lblIme);
            Controls.Add(lblPrezime);
            Controls.Add(lblMBR);
            Name = "frmDodajKreatora";
            Text = "KREATOR - Dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZemljaPorekla;
        private ComboBox cmbPol;
        private DateTimePicker dtpDatumRodjenja;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtMBR;
        private Label lblDatumRodjenja;
        private Label lblPol;
        private Label lblZemljaPorekla;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblMBR;
        private Button btnOdustani;
        private Button btnSacuvaj;
    }
}