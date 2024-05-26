namespace FashionWeek.Forms.Utils.ManekenForme
{
    partial class frmDodajRevijuManeken
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
            btnDodajReviju = new Button();
            btnOdustani = new Button();
            lblListaRevija = new Label();
            lvRevije = new ListView();
            colRBR = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colMesto = new ColumnHeader();
            colTermin = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDodajReviju
            // 
            btnDodajReviju.BackColor = SystemColors.MenuHighlight;
            btnDodajReviju.Enabled = false;
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
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(592, 375);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 8;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // lblListaRevija
            // 
            lblListaRevija.AutoSize = true;
            lblListaRevija.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaRevija.Location = new Point(12, 9);
            lblListaRevija.Name = "lblListaRevija";
            lblListaRevija.Size = new Size(318, 21);
            lblListaRevija.TabIndex = 7;
            lblListaRevija.Text = "Lista revija na kojima ne učestvuje maneken ";
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { colRBR, colNaziv, colMesto, colTermin });
            lvRevije.Location = new Point(12, 33);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 10;
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
            // frmDodajRevijuManeken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 411);
            Controls.Add(lvRevije);
            Controls.Add(btnDodajReviju);
            Controls.Add(btnOdustani);
            Controls.Add(lblListaRevija);
            Name = "frmDodajRevijuManeken";
            Text = "MANEKEN - Dodaj reviju";
            Load += frmDodajRevijuManeken_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajReviju;
        private Button btnOdustani;
        private Label lblListaRevija;
        private ListView lvRevije;
        private ColumnHeader colRBR;
        private ColumnHeader colNaziv;
        private ColumnHeader colMesto;
        private ColumnHeader colTermin;
    }
}