namespace FashionWeek.Forms.Utils.Revija
{
    partial class frmRevije
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
            lvRevije = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblRevije = new Label();
            btnIzadji = new Button();
            btnObrisiReviju = new Button();
            btnAzurirajReviju = new Button();
            btnDodajReviju = new Button();
            btnUcesnici = new Button();
            btnKreatori = new Button();
            btnSpecijalniGosti = new Button();
            SuspendLayout();
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRevije.Location = new Point(12, 33);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 4;
            lvRevije.UseCompatibleStateImageBehavior = false;
            lvRevije.View = View.Details;
            lvRevije.SelectedIndexChanged += lvRevije_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "RBR";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesto";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Termin";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 80;
            // 
            // lblRevije
            // 
            lblRevije.AutoSize = true;
            lblRevije.Font = new Font("Segoe UI", 12F);
            lblRevije.ForeColor = Color.Black;
            lblRevije.Location = new Point(12, 9);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(145, 21);
            lblRevije.TabIndex = 5;
            lblRevije.Text = "Lista modnih revija:";
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(592, 375);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 6;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnObrisiReviju
            // 
            btnObrisiReviju.BackColor = SystemColors.MenuHighlight;
            btnObrisiReviju.Enabled = false;
            btnObrisiReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiReviju.ForeColor = Color.White;
            btnObrisiReviju.Location = new Point(592, 105);
            btnObrisiReviju.Name = "btnObrisiReviju";
            btnObrisiReviju.Size = new Size(161, 30);
            btnObrisiReviju.TabIndex = 7;
            btnObrisiReviju.Text = "Obriši reviju";
            btnObrisiReviju.UseVisualStyleBackColor = false;
            btnObrisiReviju.Click += btnObrisiReviju_Click;
            // 
            // btnAzurirajReviju
            // 
            btnAzurirajReviju.BackColor = SystemColors.MenuHighlight;
            btnAzurirajReviju.Enabled = false;
            btnAzurirajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajReviju.ForeColor = Color.White;
            btnAzurirajReviju.Location = new Point(592, 69);
            btnAzurirajReviju.Name = "btnAzurirajReviju";
            btnAzurirajReviju.Size = new Size(161, 30);
            btnAzurirajReviju.TabIndex = 8;
            btnAzurirajReviju.Text = "Ažuriraj reviju";
            btnAzurirajReviju.UseVisualStyleBackColor = false;
            btnAzurirajReviju.Click += btnAzurirajReviju_Click;
            // 
            // btnDodajReviju
            // 
            btnDodajReviju.BackColor = SystemColors.MenuHighlight;
            btnDodajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajReviju.ForeColor = Color.White;
            btnDodajReviju.Location = new Point(592, 33);
            btnDodajReviju.Name = "btnDodajReviju";
            btnDodajReviju.Size = new Size(161, 30);
            btnDodajReviju.TabIndex = 9;
            btnDodajReviju.Text = "Dodaj reviju";
            btnDodajReviju.UseVisualStyleBackColor = false;
            btnDodajReviju.Click += btnDodajReviju_Click;
            // 
            // btnUcesnici
            // 
            btnUcesnici.BackColor = SystemColors.MenuHighlight;
            btnUcesnici.Enabled = false;
            btnUcesnici.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUcesnici.ForeColor = Color.White;
            btnUcesnici.Location = new Point(592, 177);
            btnUcesnici.Name = "btnUcesnici";
            btnUcesnici.Size = new Size(161, 30);
            btnUcesnici.TabIndex = 10;
            btnUcesnici.Text = "Učesnici";
            btnUcesnici.UseVisualStyleBackColor = false;
            btnUcesnici.Click += btnUcesnici_Click;
            // 
            // btnKreatori
            // 
            btnKreatori.BackColor = SystemColors.MenuHighlight;
            btnKreatori.Enabled = false;
            btnKreatori.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKreatori.ForeColor = Color.White;
            btnKreatori.Location = new Point(592, 213);
            btnKreatori.Name = "btnKreatori";
            btnKreatori.Size = new Size(161, 30);
            btnKreatori.TabIndex = 11;
            btnKreatori.Text = "Kreatori";
            btnKreatori.UseVisualStyleBackColor = false;
            btnKreatori.Click += btnKreatori_Click;
            // 
            // btnSpecijalniGosti
            // 
            btnSpecijalniGosti.BackColor = SystemColors.MenuHighlight;
            btnSpecijalniGosti.Enabled = false;
            btnSpecijalniGosti.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSpecijalniGosti.ForeColor = Color.White;
            btnSpecijalniGosti.Location = new Point(592, 249);
            btnSpecijalniGosti.Name = "btnSpecijalniGosti";
            btnSpecijalniGosti.Size = new Size(161, 30);
            btnSpecijalniGosti.TabIndex = 12;
            btnSpecijalniGosti.Text = "Specijalni gosti";
            btnSpecijalniGosti.UseVisualStyleBackColor = false;
            btnSpecijalniGosti.Click += btnSpecijalniGosti_Click;
            // 
            // frmRevije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 413);
            Controls.Add(btnSpecijalniGosti);
            Controls.Add(btnKreatori);
            Controls.Add(btnUcesnici);
            Controls.Add(btnDodajReviju);
            Controls.Add(btnAzurirajReviju);
            Controls.Add(btnObrisiReviju);
            Controls.Add(btnIzadji);
            Controls.Add(lblRevije);
            Controls.Add(lvRevije);
            Name = "frmRevije";
            Text = "REVIJE";
            Load += frmRevije_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvRevije;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblRevije;
        private Button btnIzadji;
        private Button btnObrisiReviju;
        private Button btnAzurirajReviju;
        private Button btnDodajReviju;
        private Button btnUcesnici;
        private Button btnKreatori;
        private Button btnSpecijalniGosti;
    }
}