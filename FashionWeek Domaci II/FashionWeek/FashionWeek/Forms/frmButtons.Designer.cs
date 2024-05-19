namespace FashionWeek.Forms
{
    partial class frmButtons
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
            btnUcitajManekena = new Button();
            btnDodajManekena = new Button();
            btnManekenRadiU = new Button();
            btnManekenNastupaU = new Button();
            btnDodajIZaposliManekena = new Button();
            SuspendLayout();
            // 
            // btnUcitajManekena
            // 
            btnUcitajManekena.Location = new Point(12, 12);
            btnUcitajManekena.Name = "btnUcitajManekena";
            btnUcitajManekena.Size = new Size(203, 23);
            btnUcitajManekena.TabIndex = 0;
            btnUcitajManekena.Text = "Učitavanje podataka o manekenu";
            btnUcitajManekena.UseVisualStyleBackColor = true;
            btnUcitajManekena.Click += btnUcitajManekena_Click;
            // 
            // btnDodajManekena
            // 
            btnDodajManekena.Location = new Point(12, 41);
            btnDodajManekena.Name = "btnDodajManekena";
            btnDodajManekena.Size = new Size(203, 23);
            btnDodajManekena.TabIndex = 1;
            btnDodajManekena.Text = "Dodaj manekena";
            btnDodajManekena.UseVisualStyleBackColor = true;
            btnDodajManekena.Click += btnDodajManekena_Click;
            // 
            // btnManekenRadiU
            // 
            btnManekenRadiU.Location = new Point(12, 70);
            btnManekenRadiU.Name = "btnManekenRadiU";
            btnManekenRadiU.Size = new Size(203, 23);
            btnManekenRadiU.TabIndex = 2;
            btnManekenRadiU.Text = "Maneken radi u (1:N)";
            btnManekenRadiU.UseVisualStyleBackColor = true;
            btnManekenRadiU.Click += btnManekenRadiU_Click;
            // 
            // btnManekenNastupaU
            // 
            btnManekenNastupaU.Location = new Point(12, 99);
            btnManekenNastupaU.Name = "btnManekenNastupaU";
            btnManekenNastupaU.Size = new Size(203, 23);
            btnManekenNastupaU.TabIndex = 3;
            btnManekenNastupaU.Text = "Maneken nastupa u (N:M)";
            btnManekenNastupaU.UseVisualStyleBackColor = true;
            btnManekenNastupaU.Click += btnManekenNastupaU_Click;
            // 
            // btnDodajIZaposliManekena
            // 
            btnDodajIZaposliManekena.Location = new Point(12, 128);
            btnDodajIZaposliManekena.Name = "btnDodajIZaposliManekena";
            btnDodajIZaposliManekena.Size = new Size(203, 23);
            btnDodajIZaposliManekena.TabIndex = 4;
            btnDodajIZaposliManekena.Text = "Dodaj i zaposli manekena";
            btnDodajIZaposliManekena.UseVisualStyleBackColor = true;
            btnDodajIZaposliManekena.Click += btnDodajIZaposliManekena_Click;
            // 
            // frmButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodajIZaposliManekena);
            Controls.Add(btnManekenNastupaU);
            Controls.Add(btnManekenRadiU);
            Controls.Add(btnDodajManekena);
            Controls.Add(btnUcitajManekena);
            Name = "frmButtons";
            Text = "frmButtons";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUcitajManekena;
        private Button btnDodajManekena;
        private Button btnManekenRadiU;
        private Button btnManekenNastupaU;
        private Button btnDodajIZaposliManekena;
    }
}