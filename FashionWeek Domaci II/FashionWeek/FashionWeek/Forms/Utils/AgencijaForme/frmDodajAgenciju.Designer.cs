namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmDodajAgenciju
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
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            txtGrad = new TextBox();
            txtUlica = new TextBox();
            dtpDatumOsnivanja = new DateTimePicker();
            txtNaziv = new TextBox();
            txtPIB = new TextBox();
            lblDatumOsnivanja = new Label();
            lblDrzava = new Label();
            lblGrad = new Label();
            lblUlica = new Label();
            lblNaziv = new Label();
            lblTip = new Label();
            lblPIB = new Label();
            txtDrzava = new TextBox();
            gbTip = new GroupBox();
            rbInostrana = new RadioButton();
            rbDomaca = new RadioButton();
            gbTip.SuspendLayout();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(300, 202);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 50;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(300, 173);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 49;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(118, 174);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(116, 23);
            txtGrad.TabIndex = 41;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(118, 200);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(116, 23);
            txtUlica.TabIndex = 40;
            // 
            // dtpDatumOsnivanja
            // 
            dtpDatumOsnivanja.Location = new Point(118, 114);
            dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            dtpDatumOsnivanja.Size = new Size(200, 23);
            dtpDatumOsnivanja.TabIndex = 38;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(117, 38);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(116, 23);
            txtNaziv.TabIndex = 37;
            // 
            // txtPIB
            // 
            txtPIB.Location = new Point(117, 9);
            txtPIB.Name = "txtPIB";
            txtPIB.Size = new Size(148, 23);
            txtPIB.TabIndex = 35;
            // 
            // lblDatumOsnivanja
            // 
            lblDatumOsnivanja.AutoSize = true;
            lblDatumOsnivanja.BackColor = Color.Red;
            lblDatumOsnivanja.Location = new Point(13, 120);
            lblDatumOsnivanja.Name = "lblDatumOsnivanja";
            lblDatumOsnivanja.Size = new Size(99, 15);
            lblDatumOsnivanja.TabIndex = 34;
            lblDatumOsnivanja.Text = "Datum osnivanja:";
            lblDatumOsnivanja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.BackColor = Color.Transparent;
            lblDrzava.Location = new Point(13, 145);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(42, 15);
            lblDrzava.TabIndex = 33;
            lblDrzava.Text = "Država";
            lblDrzava.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(13, 172);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(35, 15);
            lblGrad.TabIndex = 32;
            lblGrad.Text = "Grad:";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUlica
            // 
            lblUlica.AutoSize = true;
            lblUlica.Location = new Point(13, 203);
            lblUlica.Name = "lblUlica";
            lblUlica.Size = new Size(33, 15);
            lblUlica.TabIndex = 31;
            lblUlica.Text = "Ulica";
            lblUlica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.BackColor = Color.Red;
            lblNaziv.Location = new Point(12, 41);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 29;
            lblNaziv.Text = "Naziv:";
            lblNaziv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.BackColor = Color.Red;
            lblTip.Location = new Point(13, 88);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(26, 15);
            lblTip.TabIndex = 28;
            lblTip.Text = "Tip:";
            lblTip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPIB
            // 
            lblPIB.AutoSize = true;
            lblPIB.BackColor = Color.Red;
            lblPIB.Location = new Point(12, 9);
            lblPIB.Name = "lblPIB";
            lblPIB.Size = new Size(27, 15);
            lblPIB.TabIndex = 27;
            lblPIB.Text = "PIB:";
            lblPIB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(118, 145);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(116, 23);
            txtDrzava.TabIndex = 51;
            // 
            // gbTip
            // 
            gbTip.Controls.Add(rbInostrana);
            gbTip.Controls.Add(rbDomaca);
            gbTip.Location = new Point(117, 67);
            gbTip.Name = "gbTip";
            gbTip.Size = new Size(161, 40);
            gbTip.TabIndex = 52;
            gbTip.TabStop = false;
            // 
            // rbInostrana
            // 
            rbInostrana.AutoSize = true;
            rbInostrana.Location = new Point(81, 19);
            rbInostrana.Name = "rbInostrana";
            rbInostrana.Size = new Size(74, 19);
            rbInostrana.TabIndex = 1;
            rbInostrana.Text = "Inostrana";
            rbInostrana.UseVisualStyleBackColor = true;
            // 
            // rbDomaca
            // 
            rbDomaca.AutoSize = true;
            rbDomaca.Checked = true;
            rbDomaca.Location = new Point(6, 19);
            rbDomaca.Name = "rbDomaca";
            rbDomaca.Size = new Size(69, 19);
            rbDomaca.TabIndex = 0;
            rbDomaca.TabStop = true;
            rbDomaca.Text = "Domaća";
            rbDomaca.UseVisualStyleBackColor = true;
            // 
            // frmDodajAgenciju
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 237);
            Controls.Add(gbTip);
            Controls.Add(txtDrzava);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtGrad);
            Controls.Add(txtUlica);
            Controls.Add(dtpDatumOsnivanja);
            Controls.Add(txtNaziv);
            Controls.Add(txtPIB);
            Controls.Add(lblDatumOsnivanja);
            Controls.Add(lblDrzava);
            Controls.Add(lblGrad);
            Controls.Add(lblUlica);
            Controls.Add(lblNaziv);
            Controls.Add(lblTip);
            Controls.Add(lblPIB);
            Name = "frmDodajAgenciju";
            Text = "AGENCIJA - Dodaj";
            gbTip.ResumeLayout(false);
            gbTip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label lblBojaKose;
        private Label lblKonfBroj;
        private Label lblZanimanje;
        private TextBox txtKonfBroj;
        private TextBox txtBojaKose;
        private TextBox txtZanimanje;
        private TextBox txtBojaOciju;
        private TextBox txtGrad;
        private TextBox txtUlica;
        private ComboBox cmbPol;
        private DateTimePicker dtpDatumOsnivanja;
        private TextBox txtNaziv;
        private TextBox txtPrezime;
        private TextBox txtPIB;
        private Label lblDatumOsnivanja;
        private Label lblDrzava;
        private Label lblGrad;
        private Label lblUlica;
        private Label lblBojaOciju;
        private Label lblNaziv;
        private Label lblTip;
        private Label lblPIB;
        private TextBox txtDrzava;
        private GroupBox gbTip;
        private RadioButton rbInostrana;
        private RadioButton rbDomaca;
    }
}