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
            btnManekeniModneAgencije = new Button();
            btnDodajManekenaIAgenciju = new Button();
            btnDodajCasopisManekenu = new Button();
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
            // btnManekeniModneAgencije
            // 
            btnManekeniModneAgencije.Location = new Point(12, 128);
            btnManekeniModneAgencije.Name = "btnManekeniModneAgencije";
            btnManekeniModneAgencije.Size = new Size(203, 23);
            btnManekeniModneAgencije.TabIndex = 4;
            btnManekeniModneAgencije.Text = "Manekeni modne agencije (N:1)";
            btnManekeniModneAgencije.UseVisualStyleBackColor = true;
            btnManekeniModneAgencije.Click += btnManekeniModneAgencije_Click;
            // 
            // btnDodajManekenaIAgenciju
            // 
            btnDodajManekenaIAgenciju.Location = new Point(12, 157);
            btnDodajManekenaIAgenciju.Name = "btnDodajManekenaIAgenciju";
            btnDodajManekenaIAgenciju.Size = new Size(203, 23);
            btnDodajManekenaIAgenciju.TabIndex = 5;
            btnDodajManekenaIAgenciju.Text = "Dodaj Manekena i Agenciju";
            btnDodajManekenaIAgenciju.UseVisualStyleBackColor = true;
            btnDodajManekenaIAgenciju.Click += btnDodajManekenaIAgenciju_Click;
            // 
            // btnDodajCasopisManekenu
            // 
            btnDodajCasopisManekenu.Location = new Point(12, 186);
            btnDodajCasopisManekenu.Name = "btnDodajCasopisManekenu";
            btnDodajCasopisManekenu.Size = new Size(203, 42);
            btnDodajCasopisManekenu.TabIndex = 6;
            btnDodajCasopisManekenu.Text = "Dodaj casopis manekenu (visevrednosni)";
            btnDodajCasopisManekenu.UseVisualStyleBackColor = true;
            btnDodajCasopisManekenu.Click += btnDodajCasopisManekenu_Click;
            // 
            // frmButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodajCasopisManekenu);
            Controls.Add(btnDodajManekenaIAgenciju);
            Controls.Add(btnManekeniModneAgencije);
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
        private Button btnManekeniModneAgencije;
        private Button btnDodajManekenaIAgenciju;
        private Button btnDodajCasopisManekenu;
    }
}