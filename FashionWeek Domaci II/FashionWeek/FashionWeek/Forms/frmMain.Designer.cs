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
            button2 = new Button();
            SuspendLayout();
            // 
            // btnAgencije
            // 
            btnAgencije.Font = new Font("Segoe UI", 18F);
            btnAgencije.Location = new Point(12, 291);
            btnAgencije.Name = "btnAgencije";
            btnAgencije.Size = new Size(150, 65);
            btnAgencije.TabIndex = 0;
            btnAgencije.Text = "AGENCIJE";
            btnAgencije.UseVisualStyleBackColor = true;
            btnAgencije.Click += btnAgencije_Click;
            // 
            // btnManekeni
            // 
            btnManekeni.Font = new Font("Segoe UI", 18F);
            btnManekeni.Location = new Point(12, 220);
            btnManekeni.Name = "btnManekeni";
            btnManekeni.Size = new Size(150, 65);
            btnManekeni.TabIndex = 1;
            btnManekeni.Text = "MANEKENI";
            btnManekeni.UseVisualStyleBackColor = true;
            btnManekeni.Click += btnManekeni_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(12, 362);
            button2.Name = "button2";
            button2.Size = new Size(150, 65);
            button2.TabIndex = 2;
            button2.Text = "REVIJE";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnManekeni);
            Controls.Add(btnAgencije);
            Name = "frmMain";
            Text = "FASHIONWEEK";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgencije;
        private Button btnManekeni;
        private Button button2;
    }
}