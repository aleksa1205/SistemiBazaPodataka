namespace FashionWeek.Forms.Utils.RevijaForme
{
    partial class frmDodajSpecijalnogGosta
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
            lvOrganizatori = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colZemljaPorekla = new ColumnHeader();
            colRadiU = new ColumnHeader();
            lblSpecijalniGosti = new Label();
            btnPozoviGosta = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lvOrganizatori
            // 
            lvOrganizatori.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZemljaPorekla, colRadiU });
            lvOrganizatori.Location = new Point(12, 33);
            lvOrganizatori.Name = "lvOrganizatori";
            lvOrganizatori.Size = new Size(708, 405);
            lvOrganizatori.TabIndex = 13;
            lvOrganizatori.UseCompatibleStateImageBehavior = false;
            lvOrganizatori.View = View.Details;
            lvOrganizatori.SelectedIndexChanged += lvOrganizatori_SelectedIndexChanged;
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
            // colZemljaPorekla
            // 
            colZemljaPorekla.Text = "Zemlja porekla";
            colZemljaPorekla.TextAlign = HorizontalAlignment.Center;
            colZemljaPorekla.Width = 130;
            // 
            // colRadiU
            // 
            colRadiU.Text = "Radi u";
            colRadiU.TextAlign = HorizontalAlignment.Center;
            colRadiU.Width = 180;
            // 
            // lblSpecijalniGosti
            // 
            lblSpecijalniGosti.AutoSize = true;
            lblSpecijalniGosti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecijalniGosti.Location = new Point(12, 9);
            lblSpecijalniGosti.Name = "lblSpecijalniGosti";
            lblSpecijalniGosti.Size = new Size(377, 21);
            lblSpecijalniGosti.TabIndex = 14;
            lblSpecijalniGosti.Text = "Lista osoba koje se mogu pozvati kao specijalni gosti:";
            // 
            // btnPozoviGosta
            // 
            btnPozoviGosta.BackColor = SystemColors.MenuHighlight;
            btnPozoviGosta.Enabled = false;
            btnPozoviGosta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPozoviGosta.ForeColor = Color.White;
            btnPozoviGosta.Location = new Point(726, 33);
            btnPozoviGosta.Name = "btnPozoviGosta";
            btnPozoviGosta.Size = new Size(161, 30);
            btnPozoviGosta.TabIndex = 15;
            btnPozoviGosta.Text = "Pozvati gosta";
            btnPozoviGosta.UseVisualStyleBackColor = false;
            btnPozoviGosta.Click += btnPozoviGosta_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(726, 407);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 16;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmDodajSpecijalnogGosta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 449);
            Controls.Add(btnOdustani);
            Controls.Add(btnPozoviGosta);
            Controls.Add(lblSpecijalniGosti);
            Controls.Add(lvOrganizatori);
            Name = "frmDodajSpecijalnogGosta";
            Text = "REVIJA - Dodaj specijalnog gosta";
            Load += frmDodajSpecijalnogGosta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvOrganizatori;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colZemljaPorekla;
        private ColumnHeader colRadiU;
        private Label lblSpecijalniGosti;
        private Button btnPozoviGosta;
        private Button btnOdustani;
    }
}