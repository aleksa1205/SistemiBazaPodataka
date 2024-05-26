namespace FashionWeek.Forms.Utils.KucaForme
{
    partial class frmModneKuce
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
            btnVlasnici = new Button();
            btnIzadji = new Button();
            btnModniKreatori = new Button();
            btnObrisiModnuKucu = new Button();
            btnAzurirajModnuKucu = new Button();
            btnDodajModnuKucu = new Button();
            lvModneKuce = new ListView();
            colNaziv = new ColumnHeader();
            colOsnivac = new ColumnHeader();
            colAdresa = new ColumnHeader();
            lblListaModnihKuca = new Label();
            SuspendLayout();
            // 
            // btnVlasnici
            // 
            btnVlasnici.Enabled = false;
            btnVlasnici.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVlasnici.Location = new Point(624, 222);
            btnVlasnici.Name = "btnVlasnici";
            btnVlasnici.Size = new Size(161, 30);
            btnVlasnici.TabIndex = 16;
            btnVlasnici.Text = "Vlasnici";
            btnVlasnici.UseVisualStyleBackColor = true;
            btnVlasnici.Click += btnVlasnici_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(624, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 15;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnModniKreatori
            // 
            btnModniKreatori.Enabled = false;
            btnModniKreatori.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModniKreatori.Location = new Point(624, 186);
            btnModniKreatori.Name = "btnModniKreatori";
            btnModniKreatori.Size = new Size(161, 30);
            btnModniKreatori.TabIndex = 14;
            btnModniKreatori.Text = "Zaposleni";
            btnModniKreatori.UseVisualStyleBackColor = true;
            btnModniKreatori.Click += btnModniKreatori_Click;
            // 
            // btnObrisiModnuKucu
            // 
            btnObrisiModnuKucu.Enabled = false;
            btnObrisiModnuKucu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiModnuKucu.Location = new Point(624, 105);
            btnObrisiModnuKucu.Name = "btnObrisiModnuKucu";
            btnObrisiModnuKucu.Size = new Size(161, 30);
            btnObrisiModnuKucu.TabIndex = 13;
            btnObrisiModnuKucu.Text = "Obriši modnu kuću";
            btnObrisiModnuKucu.UseVisualStyleBackColor = true;
            btnObrisiModnuKucu.Click += btnObrisiModnuKucu_Click;
            // 
            // btnAzurirajModnuKucu
            // 
            btnAzurirajModnuKucu.Enabled = false;
            btnAzurirajModnuKucu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajModnuKucu.Location = new Point(624, 69);
            btnAzurirajModnuKucu.Name = "btnAzurirajModnuKucu";
            btnAzurirajModnuKucu.Size = new Size(161, 30);
            btnAzurirajModnuKucu.TabIndex = 12;
            btnAzurirajModnuKucu.Text = "Ažuriraj modnu kuću";
            btnAzurirajModnuKucu.UseVisualStyleBackColor = true;
            btnAzurirajModnuKucu.Click += btnAzurirajModnuKucu_Click;
            // 
            // btnDodajModnuKucu
            // 
            btnDodajModnuKucu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajModnuKucu.Location = new Point(624, 33);
            btnDodajModnuKucu.Name = "btnDodajModnuKucu";
            btnDodajModnuKucu.Size = new Size(161, 30);
            btnDodajModnuKucu.TabIndex = 11;
            btnDodajModnuKucu.Text = "Dodaj modnu kuću";
            btnDodajModnuKucu.UseVisualStyleBackColor = true;
            btnDodajModnuKucu.Click += btnDodajModnuKucu_Click;
            // 
            // lvModneKuce
            // 
            lvModneKuce.Columns.AddRange(new ColumnHeader[] { colNaziv, colOsnivac, colAdresa });
            lvModneKuce.Location = new Point(13, 33);
            lvModneKuce.Name = "lvModneKuce";
            lvModneKuce.Size = new Size(605, 405);
            lvModneKuce.TabIndex = 10;
            lvModneKuce.UseCompatibleStateImageBehavior = false;
            lvModneKuce.View = View.Details;
            lvModneKuce.SelectedIndexChanged += lvModneKuce_SelectedIndexChanged;
            // 
            // colNaziv
            // 
            colNaziv.Text = "Naziv";
            colNaziv.Width = 200;
            // 
            // colOsnivac
            // 
            colOsnivac.Text = "Osnivac";
            colOsnivac.TextAlign = HorizontalAlignment.Center;
            colOsnivac.Width = 150;
            // 
            // colAdresa
            // 
            colAdresa.Text = "Adresa";
            colAdresa.TextAlign = HorizontalAlignment.Center;
            colAdresa.Width = 250;
            // 
            // lblListaModnihKuca
            // 
            lblListaModnihKuca.AutoSize = true;
            lblListaModnihKuca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaModnihKuca.Location = new Point(12, 9);
            lblListaModnihKuca.Name = "lblListaModnihKuca";
            lblListaModnihKuca.Size = new Size(139, 21);
            lblListaModnihKuca.TabIndex = 9;
            lblListaModnihKuca.Text = "Lista modnih kuća:";
            // 
            // frmModneKuce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(btnVlasnici);
            Controls.Add(btnIzadji);
            Controls.Add(btnModniKreatori);
            Controls.Add(btnObrisiModnuKucu);
            Controls.Add(btnAzurirajModnuKucu);
            Controls.Add(btnDodajModnuKucu);
            Controls.Add(lvModneKuce);
            Controls.Add(lblListaModnihKuca);
            Name = "frmModneKuce";
            Text = "MODNE KUCE";
            Load += frmModneKuce_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVlasnici;
        private Button btnIzadji;
        private Button btnModniKreatori;
        private Button btnObrisiModnuKucu;
        private Button btnAzurirajModnuKucu;
        private Button btnDodajModnuKucu;
        private ListView lvModneKuce;
        private Label lblListaModnihKuca;
        private ColumnHeader colNaziv;
        private ColumnHeader colOsnivac;
        private ColumnHeader colAdresa;
    }
}