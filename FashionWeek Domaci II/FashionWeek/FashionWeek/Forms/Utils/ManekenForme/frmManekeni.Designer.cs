namespace FashionWeek.Forms.Utils.ManekenForme
{
    partial class frmManekeni
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
            lblListaManekena = new Label();
            btnDodajManekena = new Button();
            btnAzurirajManekena = new Button();
            btnObrisiManekena = new Button();
            btnRevije = new Button();
            btnIzadji = new Button();
            btnCasopisi = new Button();
            lvManekeni = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colZaposlen = new ColumnHeader();
            colVisina = new ColumnHeader();
            colTezina = new ColumnHeader();
            colBojaOciju = new ColumnHeader();
            colBojaKose = new ColumnHeader();
            colKonfBroj = new ColumnHeader();
            SuspendLayout();
            // 
            // lblListaManekena
            // 
            lblListaManekena.AutoSize = true;
            lblListaManekena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaManekena.Location = new Point(12, 9);
            lblListaManekena.Name = "lblListaManekena";
            lblListaManekena.Size = new Size(121, 21);
            lblListaManekena.TabIndex = 0;
            lblListaManekena.Text = "Lista manekena:";
            // 
            // btnDodajManekena
            // 
            btnDodajManekena.BackColor = SystemColors.MenuHighlight;
            btnDodajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajManekena.ForeColor = Color.White;
            btnDodajManekena.Location = new Point(991, 33);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(161, 30);
            btnDodajManekena.TabIndex = 2;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = false;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // btnAzurirajManekena
            // 
            btnAzurirajManekena.BackColor = SystemColors.MenuHighlight;
            btnAzurirajManekena.Enabled = false;
            btnAzurirajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajManekena.ForeColor = Color.White;
            btnAzurirajManekena.Location = new Point(991, 68);
            btnAzurirajManekena.Name = "btnAzurirajManekena";
            btnAzurirajManekena.Size = new Size(161, 30);
            btnAzurirajManekena.TabIndex = 3;
            btnAzurirajManekena.Text = "Ažuriraj manekena";
            btnAzurirajManekena.UseVisualStyleBackColor = false;
            btnAzurirajManekena.Click += btnAzurirajManekena_Click;
            // 
            // btnObrisiManekena
            // 
            btnObrisiManekena.BackColor = SystemColors.MenuHighlight;
            btnObrisiManekena.Enabled = false;
            btnObrisiManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiManekena.ForeColor = Color.White;
            btnObrisiManekena.Location = new Point(991, 104);
            btnObrisiManekena.Name = "btnObrisiManekena";
            btnObrisiManekena.Size = new Size(161, 30);
            btnObrisiManekena.TabIndex = 4;
            btnObrisiManekena.Text = "Obriši manekena";
            btnObrisiManekena.UseVisualStyleBackColor = false;
            btnObrisiManekena.Click += btnObrisiManekena_Click;
            // 
            // btnRevije
            // 
            btnRevije.BackColor = SystemColors.MenuHighlight;
            btnRevije.Enabled = false;
            btnRevije.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevije.ForeColor = Color.White;
            btnRevije.Location = new Point(991, 185);
            btnRevije.Name = "btnRevije";
            btnRevije.Size = new Size(161, 30);
            btnRevije.TabIndex = 6;
            btnRevije.Text = "Revije";
            btnRevije.UseVisualStyleBackColor = false;
            btnRevije.Click += btnRevije_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(991, 407);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 7;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnCasopisi
            // 
            btnCasopisi.BackColor = SystemColors.MenuHighlight;
            btnCasopisi.Enabled = false;
            btnCasopisi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCasopisi.ForeColor = Color.White;
            btnCasopisi.Location = new Point(991, 221);
            btnCasopisi.Name = "btnCasopisi";
            btnCasopisi.Size = new Size(161, 30);
            btnCasopisi.TabIndex = 8;
            btnCasopisi.Text = "Časopisi";
            btnCasopisi.UseVisualStyleBackColor = false;
            btnCasopisi.Click += btnCasopisi_Click;
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZaposlen, colVisina, colTezina, colBojaOciju, colBojaKose, colKonfBroj });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(973, 405);
            lvManekeni.TabIndex = 9;
            lvManekeni.UseCompatibleStateImageBehavior = false;
            lvManekeni.View = View.Details;
            lvManekeni.SelectedIndexChanged += lvManekeni_SelectedIndexChanged_1;
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
            // colZaposlen
            // 
            colZaposlen.Text = "Zaposlen U";
            colZaposlen.TextAlign = HorizontalAlignment.Center;
            colZaposlen.Width = 150;
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
            // frmManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 450);
            Controls.Add(lvManekeni);
            Controls.Add(btnCasopisi);
            Controls.Add(btnIzadji);
            Controls.Add(btnRevije);
            Controls.Add(btnObrisiManekena);
            Controls.Add(btnAzurirajManekena);
            Controls.Add(btnDodajManekena);
            Controls.Add(lblListaManekena);
            Name = "frmManekeni";
            Text = "MANEKENI";
            Load += frmManekeni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaManekena;
        private Button btnDodajManekena;
        private Button btnAzurirajManekena;
        private Button btnObrisiManekena;
        private Button btnRevije;
        private Button btnIzadji;
        private Button btnCasopisi;
        private ListView lvManekeni;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colZaposlen;
        private ColumnHeader colVisina;
        private ColumnHeader colTezina;
        private ColumnHeader colBojaOciju;
        private ColumnHeader colBojaKose;
        private ColumnHeader colKonfBroj;
    }
}