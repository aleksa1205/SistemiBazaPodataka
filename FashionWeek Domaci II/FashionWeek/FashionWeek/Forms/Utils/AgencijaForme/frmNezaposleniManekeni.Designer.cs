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
            colZanimanje = new ColumnHeader();
            lblListaNezaposlenih = new Label();
            btnOdustani = new Button();
            btnZaposli = new Button();
            SuspendLayout();
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZanimanje });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(477, 405);
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
            // colZanimanje
            // 
            colZanimanje.Text = "Zanimanje";
            colZanimanje.TextAlign = HorizontalAlignment.Center;
            colZanimanje.Width = 80;
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
            btnOdustani.Location = new Point(495, 408);
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
            btnZaposli.Location = new Point(495, 33);
            btnZaposli.Name = "btnZaposli";
            btnZaposli.Size = new Size(161, 30);
            btnZaposli.TabIndex = 5;
            btnZaposli.Text = "Zaposli";
            btnZaposli.UseVisualStyleBackColor = false;
            btnZaposli.Click += btnZaposli_Click;
            // 
            // frmNezaposleniManekeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(btnZaposli);
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
        private Button btnZaposli;
        private ColumnHeader colZanimanje;
    }
}