namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmDodajModnuKucu
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
            txtDrzava = new TextBox();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            txtGrad = new TextBox();
            txtUlica = new TextBox();
            txtNaziv = new TextBox();
            lblDrzava = new Label();
            lblGrad = new Label();
            lblUlica = new Label();
            lblNaziv = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            lblImeOsnivaca = new Label();
            lblPrezimeOsnivaca = new Label();
            SuspendLayout();
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(117, 95);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(116, 23);
            txtDrzava.TabIndex = 67;
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(249, 152);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 66;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = SystemColors.MenuHighlight;
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(249, 123);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 65;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(117, 124);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(116, 23);
            txtGrad.TabIndex = 64;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(117, 150);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(116, 23);
            txtUlica.TabIndex = 63;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(117, 6);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(116, 23);
            txtNaziv.TabIndex = 61;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.BackColor = Color.Transparent;
            lblDrzava.Location = new Point(12, 103);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(42, 15);
            lblDrzava.TabIndex = 58;
            lblDrzava.Text = "Država";
            lblDrzava.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(12, 127);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(32, 15);
            lblGrad.TabIndex = 57;
            lblGrad.Text = "Grad";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUlica
            // 
            lblUlica.AutoSize = true;
            lblUlica.Location = new Point(12, 153);
            lblUlica.Name = "lblUlica";
            lblUlica.Size = new Size(33, 15);
            lblUlica.TabIndex = 56;
            lblUlica.Text = "Ulica";
            lblUlica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.BackColor = Color.Red;
            lblNaziv.Location = new Point(12, 9);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(36, 15);
            lblNaziv.TabIndex = 55;
            lblNaziv.Text = "Naziv";
            lblNaziv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(117, 39);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(116, 23);
            txtIme.TabIndex = 71;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(117, 68);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(116, 23);
            txtPrezime.TabIndex = 70;
            // 
            // lblImeOsnivaca
            // 
            lblImeOsnivaca.AutoSize = true;
            lblImeOsnivaca.BackColor = Color.Red;
            lblImeOsnivaca.Location = new Point(12, 42);
            lblImeOsnivaca.Name = "lblImeOsnivaca";
            lblImeOsnivaca.Size = new Size(76, 15);
            lblImeOsnivaca.TabIndex = 69;
            lblImeOsnivaca.Text = "Ime osnivača";
            lblImeOsnivaca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrezimeOsnivaca
            // 
            lblPrezimeOsnivaca.AutoSize = true;
            lblPrezimeOsnivaca.BackColor = Color.Red;
            lblPrezimeOsnivaca.Location = new Point(12, 71);
            lblPrezimeOsnivaca.Name = "lblPrezimeOsnivaca";
            lblPrezimeOsnivaca.Size = new Size(98, 15);
            lblPrezimeOsnivaca.TabIndex = 68;
            lblPrezimeOsnivaca.Text = "Prezime osnivača";
            lblPrezimeOsnivaca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDodajModnuKucu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 181);
            Controls.Add(txtIme);
            Controls.Add(txtPrezime);
            Controls.Add(lblImeOsnivaca);
            Controls.Add(lblPrezimeOsnivaca);
            Controls.Add(txtDrzava);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtGrad);
            Controls.Add(txtUlica);
            Controls.Add(txtNaziv);
            Controls.Add(lblDrzava);
            Controls.Add(lblGrad);
            Controls.Add(lblUlica);
            Controls.Add(lblNaziv);
            Name = "frmDodajModnuKucu";
            Text = "MODNA KUĆA - Dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDrzava;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private TextBox txtGrad;
        private TextBox txtUlica;
        private TextBox txtNaziv;
        private Label lblDrzava;
        private Label lblGrad;
        private Label lblUlica;
        private Label lblNaziv;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Label lblImeOsnivaca;
        private Label lblPrezimeOsnivaca;
    }
}