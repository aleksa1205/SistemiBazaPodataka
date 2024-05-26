namespace FashionWeek.Forms.Utils.ManekenForme
{
    partial class frmRevijeManekena
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
            lblRevije = new Label();
            lvRevije = new ListView();
            colRBR = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colMesto = new ColumnHeader();
            colTermin = new ColumnHeader();
            btnDodajReviju = new Button();
            btnObrisiReviju = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblRevije
            // 
            lblRevije.AutoSize = true;
            lblRevije.Font = new Font("Segoe UI", 12F);
            lblRevije.ForeColor = Color.Black;
            lblRevije.Location = new Point(12, 9);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(197, 21);
            lblRevije.TabIndex = 0;
            lblRevije.Text = "Revija na kojima učestvuje ";
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { colRBR, colNaziv, colMesto, colTermin });
            lvRevije.Location = new Point(12, 33);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 1;
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
            // btnDodajReviju
            // 
            btnDodajReviju.BackColor = SystemColors.MenuHighlight;
            btnDodajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajReviju.ForeColor = Color.White;
            btnDodajReviju.Location = new Point(603, 33);
            btnDodajReviju.Name = "btnDodajReviju";
            btnDodajReviju.Size = new Size(161, 30);
            btnDodajReviju.TabIndex = 3;
            btnDodajReviju.Text = "Dodaj reviju";
            btnDodajReviju.UseVisualStyleBackColor = false;
            btnDodajReviju.Click += btnDodajReviju_Click;
            // 
            // btnObrisiReviju
            // 
            btnObrisiReviju.BackColor = SystemColors.MenuHighlight;
            btnObrisiReviju.Enabled = false;
            btnObrisiReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiReviju.ForeColor = Color.White;
            btnObrisiReviju.Location = new Point(603, 69);
            btnObrisiReviju.Name = "btnObrisiReviju";
            btnObrisiReviju.Size = new Size(161, 30);
            btnObrisiReviju.TabIndex = 4;
            btnObrisiReviju.Text = "Obriši reviju";
            btnObrisiReviju.UseVisualStyleBackColor = false;
            btnObrisiReviju.Click += btnObrisiReviju_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(603, 376);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmRevijeManekena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 418);
            Controls.Add(btnOdustani);
            Controls.Add(btnObrisiReviju);
            Controls.Add(btnDodajReviju);
            Controls.Add(lvRevije);
            Controls.Add(lblRevije);
            Name = "frmRevijeManekena";
            Text = "MANEKEN - Revije";
            Load += frmRevije_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRevije;
        private ListView lvRevije;
        private ColumnHeader colRBR;
        private ColumnHeader Naziv;
        private ColumnHeader colMesto;
        private ColumnHeader colTermin;
        private ColumnHeader colNaziv;
        private Button btnDodajReviju;
        private Button btnObrisiReviju;
        private Button btnOdustani;
    }
}