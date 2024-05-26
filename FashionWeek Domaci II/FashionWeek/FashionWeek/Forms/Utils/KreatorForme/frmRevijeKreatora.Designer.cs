namespace FashionWeek.Forms.Utils.KreatorForme
{
    partial class frmRevijeKreatora
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
            btnObrisiReviju = new Button();
            btnDodajReviju = new Button();
            lvRevije = new ListView();
            colRBR = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colMesto = new ColumnHeader();
            colTermin = new ColumnHeader();
            lblRevije = new Label();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(592, 376);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 10;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnObrisiReviju
            // 
            btnObrisiReviju.BackColor = SystemColors.MenuHighlight;
            btnObrisiReviju.Enabled = false;
            btnObrisiReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiReviju.ForeColor = Color.White;
            btnObrisiReviju.Location = new Point(592, 69);
            btnObrisiReviju.Name = "btnObrisiReviju";
            btnObrisiReviju.Size = new Size(161, 30);
            btnObrisiReviju.TabIndex = 9;
            btnObrisiReviju.Text = "Obriši reviju";
            btnObrisiReviju.UseVisualStyleBackColor = false;
            btnObrisiReviju.Click += btnObrisiReviju_Click;
            // 
            // btnDodajReviju
            // 
            btnDodajReviju.BackColor = SystemColors.MenuHighlight;
            btnDodajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajReviju.ForeColor = Color.White;
            btnDodajReviju.Location = new Point(592, 33);
            btnDodajReviju.Name = "btnDodajReviju";
            btnDodajReviju.Size = new Size(161, 30);
            btnDodajReviju.TabIndex = 8;
            btnDodajReviju.Text = "Dodaj reviju";
            btnDodajReviju.UseVisualStyleBackColor = false;
            btnDodajReviju.Click += btnDodajReviju_Click;
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { colRBR, colNaziv, colMesto, colTermin });
            lvRevije.Location = new Point(12, 34);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 7;
            lvRevije.UseCompatibleStateImageBehavior = false;
            lvRevije.View = View.Details;
            lvRevije.SelectedIndexChanged += lvRevije_SelectedIndexChanged;
            // 
            // colRBR
            // 
            colRBR.Text = "RBR";
            colRBR.Width = 40;
            // 
            // colNaziv
            // 
            colNaziv.Text = "Naziv";
            colNaziv.TextAlign = HorizontalAlignment.Center;
            colNaziv.Width = 200;
            // 
            // colMesto
            // 
            colMesto.Text = "Mesto";
            colMesto.TextAlign = HorizontalAlignment.Center;
            colMesto.Width = 250;
            // 
            // colTermin
            // 
            colTermin.Text = "Termin";
            colTermin.TextAlign = HorizontalAlignment.Center;
            colTermin.Width = 80;
            // 
            // lblRevije
            // 
            lblRevije.AutoSize = true;
            lblRevije.Font = new Font("Segoe UI", 12F);
            lblRevije.ForeColor = Color.Black;
            lblRevije.Location = new Point(12, 9);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(197, 21);
            lblRevije.TabIndex = 6;
            lblRevije.Text = "Revija na kojima učestvuje ";
            // 
            // frmRevijeKreatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 417);
            Controls.Add(btnOdustani);
            Controls.Add(btnObrisiReviju);
            Controls.Add(btnDodajReviju);
            Controls.Add(lvRevije);
            Controls.Add(lblRevije);
            Name = "frmRevijeKreatora";
            Text = "KREATOR - Revije";
            Load += frmRevijeKreatora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnObrisiReviju;
        private Button btnDodajReviju;
        private ListView lvRevije;
        private ColumnHeader colRBR;
        private ColumnHeader colNaziv;
        private ColumnHeader colMesto;
        private ColumnHeader colTermin;
        private Label lblRevije;
    }
}