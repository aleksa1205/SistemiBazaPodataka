namespace FashionWeek.Forms
{
    partial class frmMain
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
            btnAgencije = new Button();
            btnManekeni = new Button();
            btnRevije = new Button();
            btnKreatori = new Button();
            btnModneKuce = new Button();
            SuspendLayout();
            // 
            // btnAgencije
            // 
            btnAgencije.BackColor = SystemColors.MenuHighlight;
            btnAgencije.Font = new Font("Segoe UI", 18F);
            btnAgencije.ForeColor = Color.Honeydew;
            btnAgencije.Location = new Point(12, 291);
            btnAgencije.Name = "btnAgencije";
            btnAgencije.Size = new Size(150, 65);
            btnAgencije.TabIndex = 0;
            btnAgencije.Text = "AGENCIJE";
            btnAgencije.UseVisualStyleBackColor = false;
            btnAgencije.Click += btnAgencije_Click;
            // 
            // btnManekeni
            // 
            btnManekeni.BackColor = SystemColors.MenuHighlight;
            btnManekeni.Font = new Font("Segoe UI", 18F);
            btnManekeni.ForeColor = Color.Snow;
            btnManekeni.Location = new Point(12, 220);
            btnManekeni.Name = "btnManekeni";
            btnManekeni.Size = new Size(150, 65);
            btnManekeni.TabIndex = 1;
            btnManekeni.Text = "MANEKENI";
            btnManekeni.UseVisualStyleBackColor = false;
            btnManekeni.Click += btnManekeni_Click;
            // 
            // btnRevije
            // 
            btnRevije.BackColor = SystemColors.MenuHighlight;
            btnRevije.Font = new Font("Segoe UI", 18F);
            btnRevije.ForeColor = Color.Cornsilk;
            btnRevije.Location = new Point(12, 362);
            btnRevije.Name = "btnRevije";
            btnRevije.Size = new Size(150, 65);
            btnRevije.TabIndex = 2;
            btnRevije.Text = "REVIJE";
            btnRevije.UseVisualStyleBackColor = false;
            btnRevije.Click += btnRevije_Click;
            // 
            // btnKreatori
            // 
            btnKreatori.Font = new Font("Segoe UI", 18F);
            btnKreatori.Location = new Point(168, 362);
            btnKreatori.Name = "btnKreatori";
            btnKreatori.Size = new Size(150, 65);
            btnKreatori.TabIndex = 3;
            btnKreatori.Text = "KREATORI";
            btnKreatori.UseVisualStyleBackColor = true;
            btnKreatori.Click += btnKreatori_Click;
            // 
            // btnModneKuce
            // 
            btnModneKuce.Font = new Font("Segoe UI", 18F);
            btnModneKuce.Location = new Point(168, 276);
            btnModneKuce.Name = "btnModneKuce";
            btnModneKuce.Size = new Size(150, 80);
            btnModneKuce.TabIndex = 4;
            btnModneKuce.Text = "MODNE KUCE";
            btnModneKuce.UseVisualStyleBackColor = true;
            btnModneKuce.Click += btnModneKuce_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModneKuce);
            Controls.Add(btnKreatori);
            Controls.Add(btnRevije);
            Controls.Add(btnManekeni);
            Controls.Add(btnAgencije);
            Name = "frmMain";
            Text = "FASHIONWEEK";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgencije;
        private Button btnManekeni;
        private Button btnRevije;
        private Button btnKreatori;
        private Button btnModneKuce;
    }
}