namespace FashionWeek.Forms.Utils
{
    partial class frmDodajManekena
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
            lblMBR = new Label();
            lblPrezime = new Label();
            lblIme = new Label();
            lblBojaOciju = new Label();
            Tezina = new Label();
            lblVisina = new Label();
            lblPol = new Label();
            lblDatumRodjenja = new Label();
            txtMBR = new TextBox();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            cmbPol = new ComboBox();
            txtTezina = new TextBox();
            txtVisina = new TextBox();
            txtBojaOciju = new TextBox();
            txtZanimanje = new TextBox();
            txtBojaKose = new TextBox();
            txtKonfBroj = new TextBox();
            lblZanimanje = new Label();
            lblKonfBroj = new Label();
            lblBojaKose = new Label();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblMBR
            // 
            lblMBR.AutoSize = true;
            lblMBR.BackColor = Color.Red;
            lblMBR.Location = new Point(12, 18);
            lblMBR.Name = "lblMBR";
            lblMBR.Size = new Size(35, 15);
            lblMBR.TabIndex = 0;
            lblMBR.Text = "MBR:";
            lblMBR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.BackColor = Color.Red;
            lblPrezime.Location = new Point(12, 76);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 1;
            lblPrezime.Text = "Prezime:";
            lblPrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.BackColor = Color.Red;
            lblIme.Location = new Point(12, 47);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 2;
            lblIme.Text = "Ime:";
            lblIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBojaOciju
            // 
            lblBojaOciju.AutoSize = true;
            lblBojaOciju.Location = new Point(12, 217);
            lblBojaOciju.Name = "lblBojaOciju";
            lblBojaOciju.Size = new Size(62, 15);
            lblBojaOciju.TabIndex = 3;
            lblBojaOciju.Text = "Boja očiju:";
            lblBojaOciju.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tezina
            // 
            Tezina.AutoSize = true;
            Tezina.Location = new Point(12, 188);
            Tezina.Name = "Tezina";
            Tezina.Size = new Size(42, 15);
            Tezina.TabIndex = 4;
            Tezina.Text = "Težina:";
            Tezina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisina
            // 
            lblVisina.AutoSize = true;
            lblVisina.Location = new Point(12, 157);
            lblVisina.Name = "lblVisina";
            lblVisina.Size = new Size(41, 15);
            lblVisina.TabIndex = 5;
            lblVisina.Text = "Visina:";
            lblVisina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPol
            // 
            lblPol.AutoSize = true;
            lblPol.BackColor = Color.Red;
            lblPol.Location = new Point(12, 130);
            lblPol.Name = "lblPol";
            lblPol.Size = new Size(27, 15);
            lblPol.TabIndex = 6;
            lblPol.Text = "Pol:";
            lblPol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.BackColor = Color.Red;
            lblDatumRodjenja.Location = new Point(12, 105);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(89, 15);
            lblDatumRodjenja.TabIndex = 7;
            lblDatumRodjenja.Text = "Datum rođenja:";
            lblDatumRodjenja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMBR
            // 
            txtMBR.Location = new Point(108, 15);
            txtMBR.Name = "txtMBR";
            txtMBR.Size = new Size(148, 23);
            txtMBR.TabIndex = 8;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(108, 73);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(116, 23);
            txtPrezime.TabIndex = 10;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(108, 44);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(116, 23);
            txtIme.TabIndex = 11;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(107, 99);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 12;
            // 
            // cmbPol
            // 
            cmbPol.FormattingEnabled = true;
            cmbPol.Items.AddRange(new object[] { "M", "Z" });
            cmbPol.Location = new Point(108, 127);
            cmbPol.Name = "cmbPol";
            cmbPol.Size = new Size(116, 23);
            cmbPol.TabIndex = 14;
            // 
            // txtTezina
            // 
            txtTezina.Location = new Point(108, 185);
            txtTezina.Name = "txtTezina";
            txtTezina.Size = new Size(116, 23);
            txtTezina.TabIndex = 15;
            // 
            // txtVisina
            // 
            txtVisina.Location = new Point(108, 156);
            txtVisina.Name = "txtVisina";
            txtVisina.Size = new Size(116, 23);
            txtVisina.TabIndex = 16;
            // 
            // txtBojaOciju
            // 
            txtBojaOciju.Location = new Point(107, 214);
            txtBojaOciju.Name = "txtBojaOciju";
            txtBojaOciju.Size = new Size(116, 23);
            txtBojaOciju.TabIndex = 17;
            // 
            // txtZanimanje
            // 
            txtZanimanje.Location = new Point(107, 301);
            txtZanimanje.Name = "txtZanimanje";
            txtZanimanje.Size = new Size(116, 23);
            txtZanimanje.TabIndex = 19;
            // 
            // txtBojaKose
            // 
            txtBojaKose.Location = new Point(108, 243);
            txtBojaKose.Name = "txtBojaKose";
            txtBojaKose.Size = new Size(116, 23);
            txtBojaKose.TabIndex = 20;
            // 
            // txtKonfBroj
            // 
            txtKonfBroj.Location = new Point(108, 272);
            txtKonfBroj.Name = "txtKonfBroj";
            txtKonfBroj.Size = new Size(116, 23);
            txtKonfBroj.TabIndex = 21;
            // 
            // lblZanimanje
            // 
            lblZanimanje.AutoSize = true;
            lblZanimanje.Location = new Point(12, 304);
            lblZanimanje.Name = "lblZanimanje";
            lblZanimanje.Size = new Size(66, 15);
            lblZanimanje.TabIndex = 22;
            lblZanimanje.Text = "Zanimanje:";
            lblZanimanje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKonfBroj
            // 
            lblKonfBroj.AutoSize = true;
            lblKonfBroj.Location = new Point(12, 275);
            lblKonfBroj.Name = "lblKonfBroj";
            lblKonfBroj.Size = new Size(50, 15);
            lblKonfBroj.TabIndex = 23;
            lblKonfBroj.Text = "Veličina:";
            lblKonfBroj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBojaKose
            // 
            lblBojaKose.AutoSize = true;
            lblBojaKose.Location = new Point(12, 246);
            lblBojaKose.Name = "lblBojaKose";
            lblBojaKose.Size = new Size(60, 15);
            lblBojaKose.TabIndex = 24;
            lblBojaKose.Text = "Boja kose:";
            lblBojaKose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(297, 266);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 25;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(297, 295);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 26;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmDodajManekena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 330);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(lblBojaKose);
            Controls.Add(lblKonfBroj);
            Controls.Add(lblZanimanje);
            Controls.Add(txtKonfBroj);
            Controls.Add(txtBojaKose);
            Controls.Add(txtZanimanje);
            Controls.Add(txtBojaOciju);
            Controls.Add(txtVisina);
            Controls.Add(txtTezina);
            Controls.Add(cmbPol);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtIme);
            Controls.Add(txtPrezime);
            Controls.Add(txtMBR);
            Controls.Add(lblDatumRodjenja);
            Controls.Add(lblPol);
            Controls.Add(lblVisina);
            Controls.Add(Tezina);
            Controls.Add(lblBojaOciju);
            Controls.Add(lblIme);
            Controls.Add(lblPrezime);
            Controls.Add(lblMBR);
            Name = "frmDodajManekena";
            Text = "Dodaj manekena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMBR;
        private Label lblPrezime;
        private Label lblIme;
        private Label lblBojaOciju;
        private Label Tezina;
        private Label lblVisina;
        private Label lblPol;
        private Label lblDatumRodjenja;
        private TextBox txtMBR;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private DateTimePicker dtpDatumRodjenja;
        private ComboBox cmbPol;
        private TextBox txtTezina;
        private TextBox txtVisina;
        private TextBox txtBojaOciju;
        private TextBox txtZanimanje;
        private TextBox txtBojaKose;
        private TextBox txtKonfBroj;
        private Label lblZanimanje;
        private Label lblKonfBroj;
        private Label lblBojaKose;
        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}