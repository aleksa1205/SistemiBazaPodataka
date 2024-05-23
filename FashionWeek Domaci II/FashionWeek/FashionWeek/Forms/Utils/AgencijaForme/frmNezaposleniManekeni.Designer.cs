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
            lvManekeni = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            lblListaNezaposlenih = new Label();
            btnOdustani = new Button();
            btnZaposliManekena = new Button();
            colZanimanje = new ColumnHeader();
            SuspendLayout();
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZanimanje });
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
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(680, 408);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 4;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnZaposliManekena
            // 
            btnZaposliManekena.Enabled = false;
            btnZaposliManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposliManekena.Location = new Point(680, 33);
            btnZaposliManekena.Name = "btnZaposliManekena";
            btnZaposliManekena.Size = new Size(161, 30);
            btnZaposliManekena.TabIndex = 5;
            btnZaposliManekena.Text = "Zaposli manekena";
            btnZaposliManekena.UseVisualStyleBackColor = true;
            btnZaposliManekena.Click += btnZaposliManekena_Click;
            // 
            // colZanimanje
            // 
            colZanimanje.Text = "Zanimanje";
            colZanimanje.TextAlign = HorizontalAlignment.Center;
            colZanimanje.Width = 80;
            // 
            // frmNezaposleniManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(btnZaposliManekena);
            Controls.Add(btnOdustani);
            Controls.Add(lblListaNezaposlenih);
            Controls.Add(lvManekeni);
            Name = "frmNezaposleniManekeni";
            Text = "AGENCIJA - Nezaposleni manekeni";
            Load += frmNezaposleniManekeni_Load;
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
        private Label lblListaNezaposlenih;
        private Button btnOdustani;
        private Button btnZaposliManekena;
        private ColumnHeader colZanimanje;
    }
}