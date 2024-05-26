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
            btnOrganizatori = new Button();
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgencije
            // 
            btnAgencije.BackColor = SystemColors.MenuHighlight;
            btnAgencije.Font = new Font("Segoe UI", 18F);
            btnAgencije.ForeColor = Color.Honeydew;
            btnAgencije.Location = new Point(12, 379);
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
            btnManekeni.Location = new Point(447, 381);
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
            btnRevije.Location = new Point(177, 456);
            btnRevije.Name = "btnRevije";
            btnRevije.Size = new Size(264, 65);
            btnRevije.TabIndex = 2;
            btnRevije.Text = "REVIJE";
            btnRevije.UseVisualStyleBackColor = false;
            btnRevije.Click += btnRevije_Click;
            // 
            // btnKreatori
            // 
            btnKreatori.BackColor = SystemColors.MenuHighlight;
            btnKreatori.Font = new Font("Segoe UI", 18F);
            btnKreatori.ForeColor = Color.White;
            btnKreatori.Location = new Point(447, 456);
            btnKreatori.Name = "btnKreatori";
            btnKreatori.Size = new Size(150, 69);
            btnKreatori.TabIndex = 3;
            btnKreatori.Text = "KREATORI";
            btnKreatori.UseVisualStyleBackColor = false;
            btnKreatori.Click += btnKreatori_Click;
            // 
            // btnModneKuce
            // 
            btnModneKuce.BackColor = SystemColors.MenuHighlight;
            btnModneKuce.Font = new Font("Segoe UI", 18F);
            btnModneKuce.ForeColor = Color.White;
            btnModneKuce.Location = new Point(12, 456);
            btnModneKuce.Name = "btnModneKuce";
            btnModneKuce.Size = new Size(150, 65);
            btnModneKuce.TabIndex = 4;
            btnModneKuce.Text = "KUĆE";
            btnModneKuce.UseVisualStyleBackColor = false;
            btnModneKuce.Click += btnModneKuce_Click;
            // 
            // btnOrganizatori
            // 
            btnOrganizatori.BackColor = SystemColors.MenuHighlight;
            btnOrganizatori.Font = new Font("Segoe UI", 18F);
            btnOrganizatori.ForeColor = Color.White;
            btnOrganizatori.Location = new Point(177, 379);
            btnOrganizatori.Name = "btnOrganizatori";
            btnOrganizatori.Size = new Size(264, 65);
            btnOrganizatori.TabIndex = 5;
            btnOrganizatori.Text = "ORGANIZATORI";
            btnOrganizatori.UseVisualStyleBackColor = false;
            btnOrganizatori.Click += btnOrganizatori_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoRed;
            pictureBox1.Location = new Point(195, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 231);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblHeading.Location = new Point(140, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(330, 59);
            lblHeading.TabIndex = 7;
            lblHeading.Text = "FASHIONWEEK";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 533);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Controls.Add(btnOrganizatori);
            Controls.Add(btnModneKuce);
            Controls.Add(btnKreatori);
            Controls.Add(btnRevije);
            Controls.Add(btnManekeni);
            Controls.Add(btnAgencije);
            Name = "frmMain";
            Text = "FASHIONWEEK";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgencije;
        private Button btnManekeni;
        private Button btnRevije;
        private Button btnKreatori;
        private Button btnModneKuce;
        private Button btnOrganizatori;
        private PictureBox pictureBox1;
        private Label lblHeading;
    }
}