namespace FashionWeek.Forms.Utils.Revija
{
    partial class frmUcesniciRevije
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
            colAgencija = new ColumnHeader();
            lblRevija = new Label();
            btnIzadji = new Button();
            btnObrisiManekena = new Button();
            btnDodajManekena = new Button();
            SuspendLayout();
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colAgencija });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(662, 405);
            lvManekeni.TabIndex = 2;
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
            // lblRevija
            // 
            lblRevija.AutoSize = true;
            lblRevija.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevija.Location = new Point(12, 9);
            lblRevija.Name = "lblRevija";
            lblRevija.Size = new Size(280, 21);
            lblRevija.TabIndex = 3;
            lblRevija.Text = "Lista manekena koji učestvuju na reviji ";
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(680, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 8;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnObrisiManekena
            // 
            btnObrisiManekena.Enabled = false;
            btnObrisiManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiManekena.Location = new Point(680, 69);
            btnObrisiManekena.Name = "btnObrisiManekena";
            btnObrisiManekena.Size = new Size(161, 30);
            btnObrisiManekena.TabIndex = 9;
            btnObrisiManekena.Text = "Obriši manekena";
            btnObrisiManekena.UseVisualStyleBackColor = true;
            btnObrisiManekena.Click += btnObrisiManekena_Click;
            // 
            // btnDodajManekena
            // 
            btnDodajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajManekena.Location = new Point(680, 33);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(161, 30);
            btnDodajManekena.TabIndex = 10;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = true;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // frmUcesniciRevije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(btnDodajManekena);
            Controls.Add(btnObrisiManekena);
            Controls.Add(btnIzadji);
            Controls.Add(lblRevija);
            Controls.Add(lvManekeni);
            Name = "frmUcesniciRevije";
            Text = "REVIJA - Učesnici";
            Load += frmUcesniciRevije_Load;
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
        private ColumnHeader colAgencija;
        private Label lblRevija;
        private Button btnIzadji;
        private Button btnObrisiManekena;
        private Button btnDodajManekena;
    }
}