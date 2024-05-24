namespace FashionWeek.Forms.Utils.KreatorForme
{
    partial class frmDodajRevijuKreatoru
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
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(592, 378);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 15;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnDodajReviju
            // 
            btnDodajReviju.Enabled = false;
            btnDodajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajReviju.Location = new Point(592, 36);
            btnDodajReviju.Name = "btnDodajReviju";
            btnDodajReviju.Size = new Size(161, 30);
            btnDodajReviju.TabIndex = 13;
            btnDodajReviju.Text = "Dodaj reviju";
            btnDodajReviju.UseVisualStyleBackColor = true;
            btnDodajReviju.Click += btnDodajReviju_Click;
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { colRBR, colNaziv, colMesto, colTermin });
            lvRevije.Location = new Point(12, 36);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 12;
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
            lblRevije.Location = new Point(12, 11);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(218, 21);
            lblRevije.TabIndex = 11;
            lblRevije.Text = "Revija na kojima ne učestvuje ";
            // 
            // frmDodajRevijuKreatoru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 413);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajReviju);
            Controls.Add(lvRevije);
            Controls.Add(lblRevije);
            Name = "frmDodajRevijuKreatoru";
            Text = "KREATOR - Dodaj reviju";
            Load += frmDodajRevijuKreatoru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnDodajReviju;
        private ListView lvRevije;
        private ColumnHeader colRBR;
        private ColumnHeader colNaziv;
        private ColumnHeader colMesto;
        private ColumnHeader colTermin;
        private Label lblRevije;
    }
}