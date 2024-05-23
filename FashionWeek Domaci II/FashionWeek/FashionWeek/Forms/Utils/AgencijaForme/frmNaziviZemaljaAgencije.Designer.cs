namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmNaziviZemaljaAgencije
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
            lblSpisakZemalja = new Label();
            lvZemlje = new ListView();
            colZemlja = new ColumnHeader();
            btnIzadji = new Button();
            btnDodajZemlju = new Button();
            btnObrisiZemlju = new Button();
            lblNazivAgencije = new Label();
            SuspendLayout();
            // 
            // lblSpisakZemalja
            // 
            lblSpisakZemalja.AutoSize = true;
            lblSpisakZemalja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpisakZemalja.Location = new Point(12, 9);
            lblSpisakZemalja.Name = "lblSpisakZemalja";
            lblSpisakZemalja.Size = new Size(295, 21);
            lblSpisakZemalja.TabIndex = 2;
            lblSpisakZemalja.Text = "Spisak zemalja u kojima posluje agencija ";
            // 
            // lvZemlje
            // 
            lvZemlje.Columns.AddRange(new ColumnHeader[] { colZemlja });
            lvZemlje.Location = new Point(12, 69);
            lvZemlje.Name = "lvZemlje";
            lvZemlje.Size = new Size(155, 405);
            lvZemlje.TabIndex = 3;
            lvZemlje.UseCompatibleStateImageBehavior = false;
            lvZemlje.View = View.Details;
            lvZemlje.SelectedIndexChanged += lvZemlje_SelectedIndexChanged;
            // 
            // colZemlja
            // 
            colZemlja.Text = "Zemlja";
            colZemlja.Width = 150;
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(190, 444);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 6;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnDodajZemlju
            // 
            btnDodajZemlju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajZemlju.Location = new Point(190, 69);
            btnDodajZemlju.Name = "btnDodajZemlju";
            btnDodajZemlju.Size = new Size(161, 30);
            btnDodajZemlju.TabIndex = 7;
            btnDodajZemlju.Text = "Dodaj zemlju";
            btnDodajZemlju.UseVisualStyleBackColor = true;
            btnDodajZemlju.Click += btnDodajZemlju_Click;
            // 
            // btnObrisiZemlju
            // 
            btnObrisiZemlju.Enabled = false;
            btnObrisiZemlju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiZemlju.Location = new Point(190, 105);
            btnObrisiZemlju.Name = "btnObrisiZemlju";
            btnObrisiZemlju.Size = new Size(161, 30);
            btnObrisiZemlju.TabIndex = 8;
            btnObrisiZemlju.Text = "Obriši zemlju";
            btnObrisiZemlju.UseVisualStyleBackColor = true;
            btnObrisiZemlju.Click += btnObrisiZemlju_Click;
            // 
            // lblNazivAgencije
            // 
            lblNazivAgencije.AutoSize = true;
            lblNazivAgencije.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNazivAgencije.Location = new Point(12, 45);
            lblNazivAgencije.Name = "lblNazivAgencije";
            lblNazivAgencije.Size = new Size(0, 21);
            lblNazivAgencije.TabIndex = 9;
            // 
            // frmNaziviZemaljaAgencije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 491);
            Controls.Add(lblNazivAgencije);
            Controls.Add(btnObrisiZemlju);
            Controls.Add(btnDodajZemlju);
            Controls.Add(btnIzadji);
            Controls.Add(lvZemlje);
            Controls.Add(lblSpisakZemalja);
            Name = "frmNaziviZemaljaAgencije";
            Text = "AGENCIJA - Zemlje";
            Load += frmAgencijeZemlje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpisakZemalja;
        private ListView lvZemlje;
        private ColumnHeader colZemlja;
        private Button btnIzadji;
        private Button btnDodajZemlju;
        private Button btnObrisiZemlju;
        private Label lblNazivAgencije;
    }
}