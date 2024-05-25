namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmKreatoriModneKuce
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
            btnIzadji = new Button();
            btnObrisiKreatora = new Button();
            btnZaposliKreatora = new Button();
            lvKreatori = new ListView();
            colMBR = new ColumnHeader();
            colLicnoIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            colDatumRodjenja = new ColumnHeader();
            colPol = new ColumnHeader();
            colZemljaPorekla = new ColumnHeader();
            lblListaKreatora = new Label();
            SuspendLayout();
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(544, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 22;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnObrisiKreatora
            // 
            btnObrisiKreatora.Enabled = false;
            btnObrisiKreatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiKreatora.Location = new Point(544, 69);
            btnObrisiKreatora.Name = "btnObrisiKreatora";
            btnObrisiKreatora.Size = new Size(161, 30);
            btnObrisiKreatora.TabIndex = 20;
            btnObrisiKreatora.Text = "Obriši kreatora";
            btnObrisiKreatora.UseVisualStyleBackColor = true;
            btnObrisiKreatora.Click += btnObrisiKreatora_Click;
            // 
            // btnZaposliKreatora
            // 
            btnZaposliKreatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposliKreatora.Location = new Point(544, 33);
            btnZaposliKreatora.Name = "btnZaposliKreatora";
            btnZaposliKreatora.Size = new Size(161, 30);
            btnZaposliKreatora.TabIndex = 18;
            btnZaposliKreatora.Text = "Zaposli kreatora";
            btnZaposliKreatora.UseVisualStyleBackColor = true;
            btnZaposliKreatora.Click += btnZaposliKreatora_Click;
            // 
            // lvKreatori
            // 
            lvKreatori.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZemljaPorekla });
            lvKreatori.Location = new Point(13, 33);
            lvKreatori.Name = "lvKreatori";
            lvKreatori.Size = new Size(525, 405);
            lvKreatori.TabIndex = 17;
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
            // lblListaKreatora
            // 
            lblListaKreatora.AutoSize = true;
            lblListaKreatora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaKreatora.Location = new Point(12, 9);
            lblListaKreatora.Name = "lblListaKreatora";
            lblListaKreatora.Size = new Size(197, 21);
            lblListaKreatora.TabIndex = 16;
            lblListaKreatora.Text = "Lista kreatora modne kuće ";
            // 
            // frmKreatoriModneKuce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(btnIzadji);
            Controls.Add(btnObrisiKreatora);
            Controls.Add(btnZaposliKreatora);
            Controls.Add(lvKreatori);
            Controls.Add(lblListaKreatora);
            Name = "frmKreatoriModneKuce";
            Text = "MODNA KUĆA - Kreatori";
            Load += frmKreatoriModneKuce_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIzadji;
        private Button btnObrisiKreatora;
        private Button btnZaposliKreatora;
        private ListView lvKreatori;
        private ColumnHeader colMBR;
        private ColumnHeader colLicnoIme;
        private ColumnHeader colPrezime;
        private ColumnHeader colDatumRodjenja;
        private ColumnHeader colPol;
        private ColumnHeader colZemljaPorekla;
        private Label lblListaKreatora;
    }
}