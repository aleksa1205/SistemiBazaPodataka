namespace FashionWeek.Forms.Utils.Revija
{
    partial class frmUcesniciRevije
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
            lblRevija = new Label();
            btnIzadji = new Button();
            btnObrisiManekena = new Button();
            btnDodajManekena = new Button();
            lvManekeni = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            colZaposlen = new ColumnHeader();
            colVisina = new ColumnHeader();
            colTezina = new ColumnHeader();
            colBojaOciju = new ColumnHeader();
            colBojaKose = new ColumnHeader();
            colKonfBroj = new ColumnHeader();
            SuspendLayout();
            // 
            // lblRevija
            // 
            lblRevija.AutoSize = true;
            lblRevija.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevija.Location = new Point(12, 9);
            lblRevija.Name = "lblRevija";
            lblRevija.Size = new Size(280, 21);
            lblRevija.TabIndex = 3;
            lblRevija.Text = "Lista manekena koji učestvuju na reviji ";
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(991, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 8;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnObrisiManekena
            // 
            btnObrisiManekena.BackColor = SystemColors.MenuHighlight;
            btnObrisiManekena.Enabled = false;
            btnObrisiManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiManekena.ForeColor = Color.White;
            btnObrisiManekena.Location = new Point(991, 65);
            btnObrisiManekena.Name = "btnObrisiManekena";
            btnObrisiManekena.Size = new Size(161, 30);
            btnObrisiManekena.TabIndex = 9;
            btnObrisiManekena.Text = "Obriši manekena";
            btnObrisiManekena.UseVisualStyleBackColor = false;
            btnObrisiManekena.Click += btnObrisiManekena_Click;
            // 
            // btnDodajManekena
            // 
            btnDodajManekena.BackColor = SystemColors.MenuHighlight;
            btnDodajManekena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajManekena.ForeColor = Color.White;
            btnDodajManekena.Location = new Point(991, 29);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(161, 30);
            btnDodajManekena.TabIndex = 10;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = false;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // lvManekeni
            // 
            lvManekeni.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, colZaposlen, colVisina, colTezina, colBojaOciju, colBojaKose, colKonfBroj });
            lvManekeni.Location = new Point(12, 33);
            lvManekeni.Name = "lvManekeni";
            lvManekeni.Size = new Size(973, 405);
            lvManekeni.TabIndex = 11;
            lvManekeni.UseCompatibleStateImageBehavior = false;
            lvManekeni.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MBR";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Licno ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prezime";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datum rođenja";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pol";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 30;
            // 
            // colZaposlen
            // 
            colZaposlen.Text = "Zaposlen U";
            colZaposlen.TextAlign = HorizontalAlignment.Center;
            colZaposlen.Width = 150;
            // 
            // colVisina
            // 
            colVisina.Text = "Visina";
            colVisina.TextAlign = HorizontalAlignment.Center;
            // 
            // colTezina
            // 
            colTezina.Text = "Težina";
            colTezina.TextAlign = HorizontalAlignment.Center;
            // 
            // colBojaOciju
            // 
            colBojaOciju.Text = "Boja očiju";
            colBojaOciju.TextAlign = HorizontalAlignment.Center;
            colBojaOciju.Width = 80;
            // 
            // colBojaKose
            // 
            colBojaKose.Text = "Boja kose";
            colBojaKose.TextAlign = HorizontalAlignment.Center;
            colBojaKose.Width = 80;
            // 
            // colKonfBroj
            // 
            colKonfBroj.Text = "Konfekcijski broj";
            colKonfBroj.TextAlign = HorizontalAlignment.Center;
            colKonfBroj.Width = 100;
            // 
            // frmUcesniciRevije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 450);
            Controls.Add(lvManekeni);
            Controls.Add(btnDodajManekena);
            Controls.Add(btnObrisiManekena);
            Controls.Add(btnIzadji);
            Controls.Add(lblRevija);
            Name = "frmUcesniciRevije";
            Text = "REVIJA - Učesnici";
            Load += frmUcesniciRevije_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRevija;
        private Button btnIzadji;
        private Button btnObrisiManekena;
        private Button btnDodajManekena;
        private ListView lvManekeni;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader colZaposlen;
        private ColumnHeader colVisina;
        private ColumnHeader colTezina;
        private ColumnHeader colBojaOciju;
        private ColumnHeader colBojaKose;
        private ColumnHeader colKonfBroj;
    }
}