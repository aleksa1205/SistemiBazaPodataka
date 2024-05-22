namespace FashionWeek.Forms.Utils.Revija
{
    partial class frmDodajReviju
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
            dtpTermin = new DateTimePicker();
            txtNaziv = new TextBox();
            lblTermin = new Label();
            lblDrzava = new Label();
            lblGrad = new Label();
            lblUlica = new Label();
            lblNaziv = new Label();
            SuspendLayout();
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(117, 63);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(116, 23);
            txtDrzava.TabIndex = 67;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(300, 118);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(75, 23);
            btnOdustani.TabIndex = 66;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(300, 92);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 65;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(117, 92);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(116, 23);
            txtGrad.TabIndex = 64;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(117, 118);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(116, 23);
            txtUlica.TabIndex = 63;
            // 
            // dtpTermin
            // 
            dtpTermin.Location = new Point(117, 32);
            dtpTermin.Name = "dtpTermin";
            dtpTermin.Size = new Size(200, 23);
            dtpTermin.TabIndex = 62;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(117, 6);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(116, 23);
            txtNaziv.TabIndex = 61;
            // 
            // lblTermin
            // 
            lblTermin.AutoSize = true;
            lblTermin.BackColor = Color.Red;
            lblTermin.Location = new Point(12, 38);
            lblTermin.Name = "lblTermin";
            lblTermin.Size = new Size(43, 15);
            lblTermin.TabIndex = 59;
            lblTermin.Text = "Termin";
            lblTermin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.BackColor = Color.Transparent;
            lblDrzava.Location = new Point(12, 66);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(42, 15);
            lblDrzava.TabIndex = 58;
            lblDrzava.Text = "Država";
            lblDrzava.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(10, 95);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(35, 15);
            lblGrad.TabIndex = 57;
            lblGrad.Text = "Grad:";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUlica
            // 
            lblUlica.AutoSize = true;
            lblUlica.Location = new Point(12, 121);
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
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 55;
            lblNaziv.Text = "Naziv:";
            lblNaziv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDodajReviju
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 150);
            Controls.Add(txtDrzava);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtGrad);
            Controls.Add(txtUlica);
            Controls.Add(dtpTermin);
            Controls.Add(txtNaziv);
            Controls.Add(lblTermin);
            Controls.Add(lblDrzava);
            Controls.Add(lblGrad);
            Controls.Add(lblUlica);
            Controls.Add(lblNaziv);
            Name = "frmDodajReviju";
            Text = "REVIJA - Dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDrzava;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private TextBox txtGrad;
        private TextBox txtUlica;
        private DateTimePicker dtpTermin;
        private TextBox txtNaziv;
        private Label lblTermin;
        private Label lblDrzava;
        private Label lblGrad;
        private Label lblUlica;
        private Label lblNaziv;
    }
}