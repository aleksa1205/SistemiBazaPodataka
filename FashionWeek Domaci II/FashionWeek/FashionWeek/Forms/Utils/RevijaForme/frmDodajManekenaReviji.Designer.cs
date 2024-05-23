namespace FashionWeek.Forms.Utils.RevijaForme
{
    partial class frmDodajManekenaReviji
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
            btnDodajManekena = new Button();
            btnOdustani = new Button();
            lblListaManekena = new Label();
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
            // btnDodajManekena
            // 
            btnDodajManekena.Enabled = false;
            btnDodajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajManekena.Location = new Point(680, 33);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(161, 30);
            btnDodajManekena.TabIndex = 3;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = true;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(680, 408);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 4;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // lblListaManekena
            // 
            lblListaManekena.AutoSize = true;
            lblListaManekena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaManekena.Location = new Point(12, 9);
            lblListaManekena.Name = "lblListaManekena";
            lblListaManekena.Size = new Size(301, 21);
            lblListaManekena.TabIndex = 5;
            lblListaManekena.Text = "Lista manekena koji ne učestvuju na reviji ";
            // 
            // frmDodajManekenaReviji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(lblListaManekena);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajManekena);
            Controls.Add(lvManekeni);
            Name = "frmDodajManekenaReviji";
            Text = "REVIJA - Dodaj manekena";
            Load += frmDodajManekenaReviji_Load;
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
        private Button btnDodajManekena;
        private Button btnOdustani;
        private Label lblListaManekena;
    }
}