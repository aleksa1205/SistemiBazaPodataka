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
            lvManekeni = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colAgencija = new ColumnHeader();
            btnDodajManekena = new Button();
            btnAzurirajManekena = new Button();
            btnObrisiManekena = new Button();
            btnRevije = new Button();
            btnIzadji = new Button();
            btnCasopisi = new Button();
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
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colAgencija });
            lvManekeni.Location = new Point(13, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(662, 405);
            lvManekeni.TabIndex = 1;
            lvManekeni.UseCompatibleStateImageBehavior = false;
            lvManekeni.View = View.Details;
            lvManekeni.SelectedIndexChanged += lvManekeni_SelectedIndexChanged;
            // 
            // colMBR
            // 
            colMBR.Text = "MBR";
            colMBR.Width = 100;
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
            // colAgencija
            // 
            colAgencija.Text = "Zaposlen u";
            colAgencija.TextAlign = HorizontalAlignment.Center;
            colAgencija.Width = 130;
            // 
            // btnDodajManekena
            // 
            btnDodajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajManekena.Location = new Point(694, 33);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(161, 30);
            btnDodajManekena.TabIndex = 2;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = true;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // btnAzurirajManekena
            // 
            btnAzurirajManekena.Enabled = false;
            btnAzurirajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajManekena.Location = new Point(694, 69);
            btnAzurirajManekena.Name = "btnAzurirajManekena";
            btnAzurirajManekena.Size = new Size(161, 30);
            btnAzurirajManekena.TabIndex = 3;
            btnAzurirajManekena.Text = "Ažuriraj manekena";
            btnAzurirajManekena.UseVisualStyleBackColor = true;
            btnAzurirajManekena.Click += btnAzurirajManekena_Click;
            // 
            // btnObrisiManekena
            // 
            btnObrisiManekena.Enabled = false;
            btnObrisiManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiManekena.Location = new Point(694, 105);
            btnObrisiManekena.Name = "btnObrisiManekena";
            btnObrisiManekena.Size = new Size(161, 30);
            btnObrisiManekena.TabIndex = 4;
            btnObrisiManekena.Text = "Obriši manekena";
            btnObrisiManekena.UseVisualStyleBackColor = true;
            btnObrisiManekena.Click += btnObrisiManekena_Click;
            // 
            // btnRevije
            // 
            btnRevije.Enabled = false;
            btnRevije.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevije.Location = new Point(694, 186);
            btnRevije.Name = "btnRevije";
            btnRevije.Size = new Size(161, 30);
            btnRevije.TabIndex = 6;
            btnRevije.Text = "Revije";
            btnRevije.UseVisualStyleBackColor = true;
            btnRevije.Click += btnRevije_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(694, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 7;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnCasopisi
            // 
            btnCasopisi.Enabled = false;
            btnCasopisi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCasopisi.Location = new Point(694, 222);
            btnCasopisi.Name = "btnCasopisi";
            btnCasopisi.Size = new Size(161, 30);
            btnCasopisi.TabIndex = 8;
            btnCasopisi.Text = "Časopisi";
            btnCasopisi.UseVisualStyleBackColor = true;
            btnCasopisi.Click += btnCasopisi_Click;
            // 
            // frmManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(btnCasopisi);
            Controls.Add(btnIzadji);
            Controls.Add(btnRevije);
            Controls.Add(btnObrisiManekena);
            Controls.Add(btnAzurirajManekena);
            Controls.Add(btnDodajManekena);
            Controls.Add(lvManekeni);
            Controls.Add(lblListaManekena);
            Name = "frmManekeni";
            Text = "MANEKENI";
            Load += frmManekeni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaManekena;
        private ListView lvManekeni;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colAgencija;
        private Button btnDodajManekena;
        private Button btnAzurirajManekena;
        private Button btnObrisiManekena;
        private Button btnRevije;
        private Button btnIzadji;
        private Button btnCasopisi;
    }
}