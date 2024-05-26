namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmAgencijaManekeni
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
            lvManekeni = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colVisina = new ColumnHeader();
            colTezina = new ColumnHeader();
            colBojaOciju = new ColumnHeader();
            colBojaKose = new ColumnHeader();
            colKonfBroj = new ColumnHeader();
            lblListaManekenaAgencije = new Label();
            btnOtpustiManekena = new Button();
            btnIzadji = new Button();
            btnZaposliManekena = new Button();
            SuspendLayout();
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colVisina, colTezina, colBojaOciju, colBojaKose, colKonfBroj });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(824, 405);
            lvManekeni.TabIndex = 2;
            lvManekeni.UseCompatibleStateImageBehavior = false;
            lvManekeni.View = View.Details;
            lvManekeni.SelectedIndexChanged += lvManekeni_SelectedIndexChanged;
            // 
            // colMBR
            // 
            colMBR.Text = "MBR";
            colMBR.Width = 150;
            // 
            // colLicnoIme
            // 
            colLicnoIme.Text = "Licno ime";
            colLicnoIme.TextAlign = HorizontalAlignment.Center;
            colLicnoIme.Width = 80;
            // 
            // colPrezime
            // 
            colPrezime.Text = "Prezime";
            colPrezime.TextAlign = HorizontalAlignment.Center;
            colPrezime.Width = 80;
            // 
            // colDatumRodjenja
            // 
            colDatumRodjenja.Text = "Datum rođenja";
            colDatumRodjenja.TextAlign = HorizontalAlignment.Center;
            colDatumRodjenja.Width = 100;
            // 
            // colPol
            // 
            colPol.Text = "Pol";
            colPol.TextAlign = HorizontalAlignment.Center;
            colPol.Width = 30;
            // 
            // colVisina
            // 
            colVisina.Text = "Visina";
            colVisina.TextAlign = HorizontalAlignment.Center;
            // 
            // colTezina
            // 
            colTezina.Text = "Težina";
            colTezina.TextAlign = HorizontalAlignment.Center;
            // 
            // colBojaOciju
            // 
            colBojaOciju.Text = "Boja očiju";
            colBojaOciju.TextAlign = HorizontalAlignment.Center;
            colBojaOciju.Width = 80;
            // 
            // colBojaKose
            // 
            colBojaKose.Text = "Boja kose";
            colBojaKose.TextAlign = HorizontalAlignment.Center;
            colBojaKose.Width = 80;
            // 
            // colKonfBroj
            // 
            colKonfBroj.Text = "Konfekcijski broj";
            colKonfBroj.TextAlign = HorizontalAlignment.Center;
            colKonfBroj.Width = 100;
            // 
            // lblListaManekenaAgencije
            // 
            lblListaManekenaAgencije.AutoSize = true;
            lblListaManekenaAgencije.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaManekenaAgencije.Location = new Point(12, 9);
            lblListaManekenaAgencije.Name = "lblListaManekenaAgencije";
            lblListaManekenaAgencije.Size = new Size(183, 21);
            lblListaManekenaAgencije.TabIndex = 3;
            lblListaManekenaAgencije.Text = "Lista manekena agencije ";
            // 
            // btnOtpustiManekena
            // 
            btnOtpustiManekena.BackColor = SystemColors.MenuHighlight;
            btnOtpustiManekena.Enabled = false;
            btnOtpustiManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOtpustiManekena.ForeColor = Color.White;
            btnOtpustiManekena.Location = new Point(842, 69);
            btnOtpustiManekena.Name = "btnOtpustiManekena";
            btnOtpustiManekena.Size = new Size(161, 30);
            btnOtpustiManekena.TabIndex = 6;
            btnOtpustiManekena.Text = "Otpusti manekena";
            btnOtpustiManekena.UseVisualStyleBackColor = false;
            btnOtpustiManekena.Click += btnOtpustiManekena_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(842, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 7;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnZaposliManekena
            // 
            btnZaposliManekena.BackColor = SystemColors.MenuHighlight;
            btnZaposliManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposliManekena.ForeColor = Color.White;
            btnZaposliManekena.Location = new Point(842, 33);
            btnZaposliManekena.Name = "btnZaposliManekena";
            btnZaposliManekena.Size = new Size(161, 30);
            btnZaposliManekena.TabIndex = 9;
            btnZaposliManekena.Text = "Zaposli manekena";
            btnZaposliManekena.UseVisualStyleBackColor = false;
            btnZaposliManekena.Click += btnZaposliManekena_Click;
            // 
            // frmAgencijaManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
            Controls.Add(btnZaposliManekena);
            Controls.Add(btnIzadji);
            Controls.Add(btnOtpustiManekena);
            Controls.Add(lblListaManekenaAgencije);
            Controls.Add(lvManekeni);
            Name = "frmAgencijaManekeni";
            Text = "AGENCIJA - Manekeni";
            Load += frmAgencijaManekeni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvManekeni;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private Label lblListaManekenaAgencije;
        private Button btnOtpustiManekena;
        private Button btnIzadji;
        private Button btnZaposliManekena;
        private ColumnHeader colVisina;
        private ColumnHeader colTezina;
        private ColumnHeader colBojaOciju;
        private ColumnHeader colBojaKose;
        private ColumnHeader colKonfBroj;
    }
}