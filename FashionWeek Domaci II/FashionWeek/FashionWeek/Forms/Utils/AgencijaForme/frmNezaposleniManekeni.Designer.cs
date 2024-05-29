namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmNezaposleniManekeni
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
            lblListaNezaposlenih = new Label();
            btnOdustani = new Button();
            btnZaposli = new Button();
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
            colZanimanje = new ColumnHeader();
            SuspendLayout();
            // 
            // lblListaNezaposlenih
            // 
            lblListaNezaposlenih.AutoSize = true;
            lblListaNezaposlenih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaNezaposlenih.Location = new Point(12, 9);
            lblListaNezaposlenih.Name = "lblListaNezaposlenih";
            lblListaNezaposlenih.Size = new Size(216, 21);
            lblListaNezaposlenih.TabIndex = 3;
            lblListaNezaposlenih.Text = "Lista nezaposlenih manekena:";
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(940, 408);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 4;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnZaposli
            // 
            btnZaposli.BackColor = SystemColors.MenuHighlight;
            btnZaposli.Enabled = false;
            btnZaposli.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposli.ForeColor = Color.White;
            btnZaposli.Location = new Point(940, 33);
            btnZaposli.Name = "btnZaposli";
            btnZaposli.Size = new Size(161, 30);
            btnZaposli.TabIndex = 5;
            btnZaposli.Text = "Zaposli";
            btnZaposli.UseVisualStyleBackColor = false;
            btnZaposli.Click += btnZaposli_Click;
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colVisina, colTezina, colBojaOciju, colBojaKose, colKonfBroj, colZanimanje });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(922, 405);
            lvManekeni.TabIndex = 6;
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
            // colZanimanje
            // 
            colZanimanje.Text = "Zanimanje";
            colZanimanje.TextAlign = HorizontalAlignment.Center;
            colZanimanje.Width = 100;
            // 
            // frmNezaposleniManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 450);
            Controls.Add(lvManekeni);
            Controls.Add(btnZaposli);
            Controls.Add(btnOdustani);
            Controls.Add(lblListaNezaposlenih);
            Name = "frmNezaposleniManekeni";
            Text = "AGENCIJA - Nezaposleni manekeni";
            Load += frmNezaposleniManekeni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblListaNezaposlenih;
        private Button btnOdustani;
        private Button btnZaposli;
        private ListView lvManekeni;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colVisina;
        private ColumnHeader colTezina;
        private ColumnHeader colBojaOciju;
        private ColumnHeader colBojaKose;
        private ColumnHeader colKonfBroj;
        private ColumnHeader colZanimanje;
    }
}