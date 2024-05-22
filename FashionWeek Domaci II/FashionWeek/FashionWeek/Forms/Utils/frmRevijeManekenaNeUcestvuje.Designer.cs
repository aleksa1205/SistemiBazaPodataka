namespace FashionWeek.Forms.Utils
{
    partial class frmRevijeManekenaNeUcestvuje
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
            colRBR = new ColumnHeader();
            colNaziv = new ColumnHeader();
            colMesto = new ColumnHeader();
            colTermin = new ColumnHeader();
            lblRevije = new Label();
            SuspendLayout();
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { colRBR, colNaziv, colMesto, colTermin });
            lvRevije.Location = new Point(92, 90);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 2;
            lvRevije.UseCompatibleStateImageBehavior = false;
            lvRevije.View = View.Details;
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
            lblRevije.Location = new Point(302, 215);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(197, 21);
            lblRevije.TabIndex = 3;
            lblRevije.Text = "Revija na kojima učestvuje ";
            // 
            // frmRevijeManekenaNeUcestvuje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRevije);
            Controls.Add(lvRevije);
            Name = "frmRevijeManekenaNeUcestvuje";
            Text = "frmRevijeManekenaNeUcestvuje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvRevije;
        private ColumnHeader colRBR;
        private ColumnHeader colNaziv;
        private ColumnHeader colMesto;
        private ColumnHeader colTermin;
        private Label lblRevije;
    }
}