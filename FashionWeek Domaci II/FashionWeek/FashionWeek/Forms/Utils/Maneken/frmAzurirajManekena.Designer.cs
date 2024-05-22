namespace FashionWeek.Forms.Utils
{
    partial class frmAzurirajManekena
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
            btnOdustani = new Button();
            btnAzuriraj = new Button();
            lblBojaKose = new Label();
            lblKonfBroj = new Label();
            lblZanimanje = new Label();
            txtKonfBroj = new TextBox();
            txtBojaKose = new TextBox();
            txtZanimanje = new TextBox();
            txtBojaOciju = new TextBox();
            txtVisina = new TextBox();
            txtTezina = new TextBox();
            cmbPol = new ComboBox();
            dtpDatumRodjenja = new DateTimePicker();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtMBR = new TextBox();
            lblDatumRodjenja = new Label();
            lblPol = new Label();
            lblVisina = new Label();
            Tezina = new Label();
            lblBojaOciju = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            lblMBR = new Label();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(297, 286);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 50;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(297, 257);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(75, 23);
            btnAzuriraj.TabIndex = 49;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // lblBojaKose
            // 
            lblBojaKose.AutoSize = true;
            lblBojaKose.Location = new Point(12, 237);
            lblBojaKose.Name = "lblBojaKose";
            lblBojaKose.Size = new Size(60, 15);
            lblBojaKose.TabIndex = 48;
            lblBojaKose.Text = "Boja kose:";
            lblBojaKose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKonfBroj
            // 
            lblKonfBroj.AutoSize = true;
            lblKonfBroj.Location = new Point(12, 266);
            lblKonfBroj.Name = "lblKonfBroj";
            lblKonfBroj.Size = new Size(50, 15);
            lblKonfBroj.TabIndex = 47;
            lblKonfBroj.Text = "Veličina:";
            lblKonfBroj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZanimanje
            // 
            lblZanimanje.AutoSize = true;
            lblZanimanje.Location = new Point(12, 295);
            lblZanimanje.Name = "lblZanimanje";
            lblZanimanje.Size = new Size(66, 15);
            lblZanimanje.TabIndex = 46;
            lblZanimanje.Text = "Zanimanje:";
            lblZanimanje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKonfBroj
            // 
            txtKonfBroj.Location = new Point(108, 263);
            txtKonfBroj.Name = "txtKonfBroj";
            txtKonfBroj.Size = new Size(116, 23);
            txtKonfBroj.TabIndex = 45;
            // 
            // txtBojaKose
            // 
            txtBojaKose.Location = new Point(108, 234);
            txtBojaKose.Name = "txtBojaKose";
            txtBojaKose.Size = new Size(116, 23);
            txtBojaKose.TabIndex = 44;
            // 
            // txtZanimanje
            // 
            txtZanimanje.Location = new Point(107, 292);
            txtZanimanje.Name = "txtZanimanje";
            txtZanimanje.Size = new Size(116, 23);
            txtZanimanje.TabIndex = 43;
            // 
            // txtBojaOciju
            // 
            txtBojaOciju.Location = new Point(107, 205);
            txtBojaOciju.Name = "txtBojaOciju";
            txtBojaOciju.Size = new Size(116, 23);
            txtBojaOciju.TabIndex = 42;
            // 
            // txtVisina
            // 
            txtVisina.Location = new Point(108, 147);
            txtVisina.Name = "txtVisina";
            txtVisina.Size = new Size(116, 23);
            txtVisina.TabIndex = 41;
            // 
            // txtTezina
            // 
            txtTezina.Location = new Point(108, 176);
            txtTezina.Name = "txtTezina";
            txtTezina.Size = new Size(116, 23);
            txtTezina.TabIndex = 40;
            // 
            // cmbPol
            // 
            cmbPol.FormattingEnabled = true;
            cmbPol.Items.AddRange(new object[] { "M", "Z" });
            cmbPol.Location = new Point(108, 118);
            cmbPol.Name = "cmbPol";
            cmbPol.Size = new Size(116, 23);
            cmbPol.TabIndex = 39;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(107, 90);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 38;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(108, 35);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(116, 23);
            txtIme.TabIndex = 37;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(108, 64);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(116, 23);
            txtPrezime.TabIndex = 36;
            // 
            // txtMBR
            // 
            txtMBR.Location = new Point(108, 6);
            txtMBR.Name = "txtMBR";
            txtMBR.Size = new Size(148, 23);
            txtMBR.TabIndex = 35;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.BackColor = Color.Red;
            lblDatumRodjenja.Location = new Point(12, 96);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(89, 15);
            lblDatumRodjenja.TabIndex = 34;
            lblDatumRodjenja.Text = "Datum rođenja:";
            lblDatumRodjenja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPol
            // 
            lblPol.AutoSize = true;
            lblPol.BackColor = Color.Red;
            lblPol.Location = new Point(12, 121);
            lblPol.Name = "lblPol";
            lblPol.Size = new Size(27, 15);
            lblPol.TabIndex = 33;
            lblPol.Text = "Pol:";
            lblPol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisina
            // 
            lblVisina.AutoSize = true;
            lblVisina.Location = new Point(12, 148);
            lblVisina.Name = "lblVisina";
            lblVisina.Size = new Size(41, 15);
            lblVisina.TabIndex = 32;
            lblVisina.Text = "Visina:";
            lblVisina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tezina
            // 
            Tezina.AutoSize = true;
            Tezina.Location = new Point(12, 179);
            Tezina.Name = "Tezina";
            Tezina.Size = new Size(42, 15);
            Tezina.TabIndex = 31;
            Tezina.Text = "Težina:";
            Tezina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBojaOciju
            // 
            lblBojaOciju.AutoSize = true;
            lblBojaOciju.Location = new Point(12, 208);
            lblBojaOciju.Name = "lblBojaOciju";
            lblBojaOciju.Size = new Size(62, 15);
            lblBojaOciju.TabIndex = 30;
            lblBojaOciju.Text = "Boja očiju:";
            lblBojaOciju.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.BackColor = Color.Red;
            lblIme.Location = new Point(12, 38);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 29;
            lblIme.Text = "Ime:";
            lblIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.BackColor = Color.Red;
            lblPrezime.Location = new Point(12, 67);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 28;
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
            lblMBR.TabIndex = 27;
            lblMBR.Text = "MBR:";
            lblMBR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAzurirajManekena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 330);
            Controls.Add(btnOdustani);
            Controls.Add(btnAzuriraj);
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
            Name = "frmAzurirajManekena";
            Text = "MANEKEN - Ažuriranje";
            Load += frmAzurirajManekena_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnAzuriraj;
        private Label lblBojaKose;
        private Label lblKonfBroj;
        private Label lblZanimanje;
        private TextBox txtKonfBroj;
        private TextBox txtBojaKose;
        private TextBox txtZanimanje;
        private TextBox txtBojaOciju;
        private TextBox txtVisina;
        private TextBox txtTezina;
        private ComboBox cmbPol;
        private DateTimePicker dtpDatumRodjenja;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtMBR;
        private Label lblDatumRodjenja;
        private Label lblPol;
        private Label lblVisina;
        private Label Tezina;
        private Label lblBojaOciju;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblMBR;
    }
}