namespace FashionWeek.Forms.Utils.RevijaForme
{
    partial class frmSpecijalniGosti
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
            btnObrisiGosta = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lvOrganizatori
            // 
            lvOrganizatori.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZemljaPorekla, colRadiU });
            lvOrganizatori.Location = new Point(13, 33);
            lvOrganizatori.Name = "lvOrganizatori";
            lvOrganizatori.Size = new Size(708, 405);
            lvOrganizatori.TabIndex = 12;
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
            lblSpecijalniGosti.Size = new Size(216, 21);
            lblSpecijalniGosti.TabIndex = 11;
            lblSpecijalniGosti.Text = "Lista specijalnih gostiju revije ";
            // 
            // btnObrisiGosta
            // 
            btnObrisiGosta.Enabled = false;
            btnObrisiGosta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiGosta.Location = new Point(727, 69);
            btnObrisiGosta.Name = "btnObrisiGosta";
            btnObrisiGosta.Size = new Size(161, 30);
            btnObrisiGosta.TabIndex = 13;
            btnObrisiGosta.Text = "Obriši gosta";
            btnObrisiGosta.UseVisualStyleBackColor = true;
            btnObrisiGosta.Click += btnObrisiGosta_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(727, 33);
            button1.Name = "button1";
            button1.Size = new Size(161, 30);
            button1.TabIndex = 14;
            button1.Text = "Dodaj manekena";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(726, 408);
            button2.Name = "button2";
            button2.Size = new Size(161, 30);
            button2.TabIndex = 15;
            button2.Text = "Dodaj manekena";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmSpecijalniGosti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnObrisiGosta);
            Controls.Add(lvOrganizatori);
            Controls.Add(lblSpecijalniGosti);
            Name = "frmSpecijalniGosti";
            Text = "REVIJA - Specijalni gosti";
            Load += frmSpecijalniGosti_Load;
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
        private Button btnObrisiGosta;
        private Button button1;
        private Button button2;
    }
}