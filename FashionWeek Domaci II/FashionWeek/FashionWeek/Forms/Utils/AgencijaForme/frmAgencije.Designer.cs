namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmAgencije
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
            lblListaAgencija = new Label();
            lvAgencije = new ListView();
            colPIB = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colSediste = new ColumnHeader();
            colDatumOsnivanja = new ColumnHeader();
            btnObrisiAgenciju = new Button();
            btnAzurirajAgenciju = new Button();
            btnDodajAgenciju = new Button();
            btnPrikaziManekene = new Button();
            btnZemljePoslovanja = new Button();
            btnIzadji = new Button();
            SuspendLayout();
            // 
            // lblListaAgencija
            // 
            lblListaAgencija.AutoSize = true;
            lblListaAgencija.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaAgencija.Location = new Point(12, 9);
            lblListaAgencija.Name = "lblListaAgencija";
            lblListaAgencija.Size = new Size(106, 21);
            lblListaAgencija.TabIndex = 1;
            lblListaAgencija.Text = "Lista agencija:";
            // 
            // lvAgencije
            // 
            lvAgencije.Columns.AddRange(new ColumnHeader[] { colPIB, colNaziv, colSediste, colDatumOsnivanja });
            lvAgencije.Location = new Point(12, 33);
            lvAgencije.Name = "lvAgencije";
            lvAgencije.Size = new Size(605, 405);
            lvAgencije.TabIndex = 2;
            lvAgencije.UseCompatibleStateImageBehavior = false;
            lvAgencije.View = View.Details;
            lvAgencije.SelectedIndexChanged += lvAgencije_SelectedIndexChanged;
            // 
            // colPIB
            // 
            colPIB.Text = "PIB";
            colPIB.Width = 100;
            // 
            // colNaziv
            // 
            colNaziv.Text = "Naziv";
            colNaziv.TextAlign = HorizontalAlignment.Center;
            colNaziv.Width = 150;
            // 
            // colSediste
            // 
            colSediste.Text = "Sedište";
            colSediste.TextAlign = HorizontalAlignment.Center;
            colSediste.Width = 200;
            // 
            // colDatumOsnivanja
            // 
            colDatumOsnivanja.Text = "Datum osnivanja";
            colDatumOsnivanja.TextAlign = HorizontalAlignment.Center;
            colDatumOsnivanja.Width = 150;
            // 
            // btnObrisiAgenciju
            // 
            btnObrisiAgenciju.Enabled = false;
            btnObrisiAgenciju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiAgenciju.Location = new Point(627, 105);
            btnObrisiAgenciju.Name = "btnObrisiAgenciju";
            btnObrisiAgenciju.Size = new Size(161, 30);
            btnObrisiAgenciju.TabIndex = 3;
            btnObrisiAgenciju.Text = "Obriši agenciju";
            btnObrisiAgenciju.UseVisualStyleBackColor = true;
            btnObrisiAgenciju.Click += btnObrisiAgenciju_Click;
            // 
            // btnAzurirajAgenciju
            // 
            btnAzurirajAgenciju.Enabled = false;
            btnAzurirajAgenciju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajAgenciju.Location = new Point(627, 69);
            btnAzurirajAgenciju.Name = "btnAzurirajAgenciju";
            btnAzurirajAgenciju.Size = new Size(161, 30);
            btnAzurirajAgenciju.TabIndex = 4;
            btnAzurirajAgenciju.Text = "Ažuriraj agenciju";
            btnAzurirajAgenciju.UseVisualStyleBackColor = true;
            btnAzurirajAgenciju.Click += btnAzurirajAgenciju_Click;
            // 
            // btnDodajAgenciju
            // 
            btnDodajAgenciju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajAgenciju.Location = new Point(627, 33);
            btnDodajAgenciju.Name = "btnDodajAgenciju";
            btnDodajAgenciju.Size = new Size(161, 30);
            btnDodajAgenciju.TabIndex = 5;
            btnDodajAgenciju.Text = "Dodaj agenciju";
            btnDodajAgenciju.UseVisualStyleBackColor = true;
            btnDodajAgenciju.Click += btnDodajAgenciju_Click;
            // 
            // btnPrikaziManekene
            // 
            btnPrikaziManekene.Enabled = false;
            btnPrikaziManekene.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrikaziManekene.Location = new Point(627, 190);
            btnPrikaziManekene.Name = "btnPrikaziManekene";
            btnPrikaziManekene.Size = new Size(161, 30);
            btnPrikaziManekene.TabIndex = 6;
            btnPrikaziManekene.Text = "Zaposleni";
            btnPrikaziManekene.UseVisualStyleBackColor = true;
            btnPrikaziManekene.Click += btnPrikaziManekene_Click;
            // 
            // btnZemljePoslovanja
            // 
            btnZemljePoslovanja.Enabled = false;
            btnZemljePoslovanja.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZemljePoslovanja.Location = new Point(627, 226);
            btnZemljePoslovanja.Name = "btnZemljePoslovanja";
            btnZemljePoslovanja.Size = new Size(161, 30);
            btnZemljePoslovanja.TabIndex = 7;
            btnZemljePoslovanja.Text = "Zemlje poslovanja";
            btnZemljePoslovanja.UseVisualStyleBackColor = true;
            btnZemljePoslovanja.Click += btnZemljePoslovanja_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(627, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 9;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // frmAgencije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIzadji);
            Controls.Add(btnZemljePoslovanja);
            Controls.Add(btnPrikaziManekene);
            Controls.Add(btnDodajAgenciju);
            Controls.Add(btnAzurirajAgenciju);
            Controls.Add(btnObrisiAgenciju);
            Controls.Add(lvAgencije);
            Controls.Add(lblListaAgencija);
            Name = "frmAgencije";
            Text = "AGENCIJE";
            Load += frmAgencije_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListaAgencija;
        private ListView lvAgencije;
        private ColumnHeader colPIB;
        private ColumnHeader colNaziv;
        private ColumnHeader colSediste;
        private ColumnHeader colDatumOsnivanja;
        private Button btnObrisiAgenciju;
        private Button btnAzurirajAgenciju;
        private Button btnDodajAgenciju;
        private Button btnPrikaziManekene;
        private Button btnZemljePoslovanja;
        private Button btnIzadji;
    }
}