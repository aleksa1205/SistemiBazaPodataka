namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmDodajVlasnika
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
            btnDodajVlasnika = new Button();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            lblIme = new Label();
            lblPrezime = new Label();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(67, 98);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 12;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            // 
            // btnDodajVlasnika
            // 
            btnDodajVlasnika.BackColor = SystemColors.MenuHighlight;
            btnDodajVlasnika.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajVlasnika.ForeColor = Color.White;
            btnDodajVlasnika.Location = new Point(67, 64);
            btnDodajVlasnika.Name = "btnDodajVlasnika";
            btnDodajVlasnika.Size = new Size(164, 30);
            btnDodajVlasnika.TabIndex = 11;
            btnDodajVlasnika.Text = "Dodaj vlasnika";
            btnDodajVlasnika.UseVisualStyleBackColor = false;
            btnDodajVlasnika.Click += btnDodajVlasnika_Click;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(67, 35);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(164, 23);
            txtPrezime.TabIndex = 10;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(67, 6);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(164, 23);
            txtIme.TabIndex = 13;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(12, 9);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(27, 15);
            lblIme.TabIndex = 14;
            lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(12, 38);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(49, 15);
            lblPrezime.TabIndex = 15;
            lblPrezime.Text = "Prezime";
            // 
            // frmDodajVlasnika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 138);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajVlasnika);
            Controls.Add(txtPrezime);
            Name = "frmDodajVlasnika";
            Text = "MODNA КUĆA - Dodaj vlasnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnDodajVlasnika;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label lblIme;
        private Label lblPrezime;
    }
}