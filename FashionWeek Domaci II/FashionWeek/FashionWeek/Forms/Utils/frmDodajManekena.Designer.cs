namespace FashionWeek.Forms.Utils
{
    partial class frmDodajManekena
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
            lblMBR = new Label();
            lblPrezime = new Label();
            lblIme = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblPol = new Label();
            lblDatumRodjenja = new Label();
            txtMBR = new TextBox();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            cmbPol = new ComboBox();
            SuspendLayout();
            // 
            // lblMBR
            // 
            lblMBR.AutoSize = true;
            lblMBR.Location = new Point(12, 18);
            lblMBR.Name = "lblMBR";
            lblMBR.Size = new Size(35, 15);
            lblMBR.TabIndex = 0;
            lblMBR.Text = "MBR:";
            lblMBR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(12, 76);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 1;
            lblPrezime.Text = "Prezime:";
            lblPrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(12, 47);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 2;
            lblIme.Text = "Ime:";
            lblIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 265);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "MBR:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 213);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 4;
            label4.Text = "MBR:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 157);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 5;
            label5.Text = "MBR:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPol
            // 
            lblPol.AutoSize = true;
            lblPol.Location = new Point(12, 130);
            lblPol.Name = "lblPol";
            lblPol.Size = new Size(35, 15);
            lblPol.TabIndex = 6;
            lblPol.Text = "MBR:";
            lblPol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.Location = new Point(12, 105);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(89, 15);
            lblDatumRodjenja.TabIndex = 7;
            lblDatumRodjenja.Text = "Datum rođenja:";
            lblDatumRodjenja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMBR
            // 
            txtMBR.Location = new Point(108, 15);
            txtMBR.Name = "txtMBR";
            txtMBR.Size = new Size(148, 23);
            txtMBR.TabIndex = 8;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(108, 73);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(116, 23);
            txtPrezime.TabIndex = 10;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(108, 44);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(116, 23);
            txtIme.TabIndex = 11;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(107, 99);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 12;
            // 
            // cmbPol
            // 
            cmbPol.FormattingEnabled = true;
            cmbPol.Items.AddRange(new object[] { "", "M", "Z" });
            cmbPol.Location = new Point(108, 127);
            cmbPol.Name = "cmbPol";
            cmbPol.Size = new Size(121, 23);
            cmbPol.TabIndex = 14;
            // 
            // frmDodajManekena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(cmbPol);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(txtIme);
            Controls.Add(txtPrezime);
            Controls.Add(txtMBR);
            Controls.Add(lblDatumRodjenja);
            Controls.Add(lblPol);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIme);
            Controls.Add(lblPrezime);
            Controls.Add(lblMBR);
            Name = "frmDodajManekena";
            Text = "Dodaj manekena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMBR;
        private Label lblPrezime;
        private Label lblIme;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblPol;
        private Label lblDatumRodjenja;
        private TextBox txtMBR;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private DateTimePicker dtpDatumRodjenja;
        private ComboBox cmbPol;
    }
}