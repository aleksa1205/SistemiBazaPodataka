namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmVlasnici
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
            lblNazivModneKuce = new Label();
            btnObrisiVlasnika = new Button();
            btnDodajVlasnika = new Button();
            btnIzadji = new Button();
            lvVlasnici = new ListView();
            colRBR = new ColumnHeader();
            colIme = new ColumnHeader();
            colPrezime = new ColumnHeader();
            lblSpisakVlasnika = new Label();
            SuspendLayout();
            // 
            // lblNazivModneKuce
            // 
            lblNazivModneKuce.AutoSize = true;
            lblNazivModneKuce.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNazivModneKuce.Location = new Point(12, 44);
            lblNazivModneKuce.Name = "lblNazivModneKuce";
            lblNazivModneKuce.Size = new Size(0, 21);
            lblNazivModneKuce.TabIndex = 15;
            // 
            // btnObrisiVlasnika
            // 
            btnObrisiVlasnika.Enabled = false;
            btnObrisiVlasnika.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiVlasnika.Location = new Point(262, 104);
            btnObrisiVlasnika.Name = "btnObrisiVlasnika";
            btnObrisiVlasnika.Size = new Size(161, 30);
            btnObrisiVlasnika.TabIndex = 14;
            btnObrisiVlasnika.Text = "Obriši vlasnika";
            btnObrisiVlasnika.UseVisualStyleBackColor = true;
            btnObrisiVlasnika.Click += btnObrisiVlasnika_Click;
            // 
            // btnDodajVlasnika
            // 
            btnDodajVlasnika.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajVlasnika.Location = new Point(262, 68);
            btnDodajVlasnika.Name = "btnDodajVlasnika";
            btnDodajVlasnika.Size = new Size(161, 30);
            btnDodajVlasnika.TabIndex = 13;
            btnDodajVlasnika.Text = "Dodaj vlasnika";
            btnDodajVlasnika.UseVisualStyleBackColor = true;
            btnDodajVlasnika.Click += btnDodajVlasnika_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(262, 443);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 12;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // lvVlasnici
            // 
            lvVlasnici.Columns.AddRange(new ColumnHeader[] { colRBR, colIme, colPrezime });
            lvVlasnici.Location = new Point(12, 68);
            lvVlasnici.Name = "lvVlasnici";
            lvVlasnici.Size = new Size(244, 405);
            lvVlasnici.TabIndex = 11;
            lvVlasnici.UseCompatibleStateImageBehavior = false;
            lvVlasnici.View = View.Details;
            lvVlasnici.SelectedIndexChanged += lvVlasnici_SelectedIndexChanged;
            // 
            // colRBR
            // 
            colRBR.Text = "RBR";
            colRBR.Width = 40;
            // 
            // colIme
            // 
            colIme.Text = "Ime";
            colIme.TextAlign = HorizontalAlignment.Center;
            colIme.Width = 100;
            // 
            // colPrezime
            // 
            colPrezime.Text = "Prezime";
            colPrezime.TextAlign = HorizontalAlignment.Center;
            colPrezime.Width = 100;
            // 
            // lblSpisakVlasnika
            // 
            lblSpisakVlasnika.AutoSize = true;
            lblSpisakVlasnika.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpisakVlasnika.Location = new Point(12, 8);
            lblSpisakVlasnika.Name = "lblSpisakVlasnika";
            lblSpisakVlasnika.Size = new Size(204, 21);
            lblSpisakVlasnika.TabIndex = 10;
            lblSpisakVlasnika.Text = "Spisak vlasnika modne kuće";
            // 
            // frmVlasnici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 496);
            Controls.Add(lblNazivModneKuce);
            Controls.Add(btnObrisiVlasnika);
            Controls.Add(btnDodajVlasnika);
            Controls.Add(btnIzadji);
            Controls.Add(lvVlasnici);
            Controls.Add(lblSpisakVlasnika);
            Name = "frmVlasnici";
            Text = "MODNA KUĆA - Vlasnici";
            Load += frmVlasnici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivModneKuce;
        private Button btnObrisiVlasnika;
        private Button btnDodajVlasnika;
        private Button btnIzadji;
        private ListView lvVlasnici;
        private ColumnHeader colRBR;
        private Label lblSpisakVlasnika;
        private ColumnHeader colIme;
        private ColumnHeader colPrezime;
    }
}