﻿namespace FashionWeek.Forms.Utils.OrganizatorForme
{
    partial class frmSpecijalniGostiOrgnizatora
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
            btnIzadji = new Button();
            SuspendLayout();
            // 
            // lvOrganizatori
            // 
            lvOrganizatori.Columns.AddRange(new ColumnHeader[] { colMBR, colLicnoIme, colPrezime, colDatumRodjenja, colPol, colZemljaPorekla, colRadiU });
            lvOrganizatori.Location = new Point(13, 33);
            lvOrganizatori.Name = "lvOrganizatori";
            lvOrganizatori.Size = new Size(708, 405);
            lvOrganizatori.TabIndex = 14;
            lvOrganizatori.UseCompatibleStateImageBehavior = false;
            lvOrganizatori.View = View.Details;
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
            lblSpecijalniGosti.Size = new Size(266, 21);
            lblSpecijalniGosti.TabIndex = 13;
            lblSpecijalniGosti.Text = "Lista specijalnih gostiju organizatora ";
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(296, 444);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 15;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // frmSpecijalniGostiOrgnizatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 478);
            Controls.Add(btnIzadji);
            Controls.Add(lvOrganizatori);
            Controls.Add(lblSpecijalniGosti);
            Name = "frmSpecijalniGostiOrgnizatora";
            Text = "ORGANIZATOR - Specijalni gosti";
            Load += frmSpecijalniGostiOrgnizatora_Load;
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
        private Button btnIzadji;
    }
}