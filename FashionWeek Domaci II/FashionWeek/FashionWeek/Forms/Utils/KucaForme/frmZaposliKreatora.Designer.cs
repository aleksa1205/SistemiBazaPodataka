namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmZaposliKreatora
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
            lvKreatori = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colZemljaPorekla = new ColumnHeader();
            btnZaposli = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lvKreatori
            // 
            lvKreatori.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZemljaPorekla });
            lvKreatori.Location = new Point(12, 12);
            lvKreatori.Name = "lvKreatori";
            lvKreatori.Size = new Size(525, 405);
            lvKreatori.TabIndex = 18;
            lvKreatori.UseCompatibleStateImageBehavior = false;
            lvKreatori.View = View.Details;
            lvKreatori.SelectedIndexChanged += lvKreatori_SelectedIndexChanged;
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
            // btnZaposli
            // 
            btnZaposli.BackColor = SystemColors.MenuHighlight;
            btnZaposli.Enabled = false;
            btnZaposli.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposli.ForeColor = Color.White;
            btnZaposli.Location = new Point(543, 12);
            btnZaposli.Name = "btnZaposli";
            btnZaposli.Size = new Size(161, 30);
            btnZaposli.TabIndex = 19;
            btnZaposli.Text = "Zaposli";
            btnZaposli.UseVisualStyleBackColor = false;
            btnZaposli.Click += btnZaposli_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(543, 387);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 20;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmZaposliKreatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 424);
            Controls.Add(btnOdustani);
            Controls.Add(btnZaposli);
            Controls.Add(lvKreatori);
            Name = "frmZaposliKreatora";
            Text = "MODNA KUĆA - Zaposli kreatora";
            Load += frmZaposliKreatora_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvKreatori;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colZemljaPorekla;
        private Button btnZaposli;
        private Button btnOdustani;
    }
}