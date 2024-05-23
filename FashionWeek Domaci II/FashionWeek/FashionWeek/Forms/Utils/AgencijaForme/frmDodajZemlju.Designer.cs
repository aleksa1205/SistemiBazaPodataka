namespace FashionWeek.Forms.Utils.AgencijaForme
{
    partial class frmDodajZemlju
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
            txtNazivZemlje = new TextBox();
            btnDodajZemlju = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // txtNazivZemlje
            // 
            txtNazivZemlje.Location = new Point(32, 12);
            txtNazivZemlje.Name = "txtNazivZemlje";
            txtNazivZemlje.Size = new Size(164, 23);
            txtNazivZemlje.TabIndex = 0;
            // 
            // btnDodajZemlju
            // 
            btnDodajZemlju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajZemlju.Location = new Point(32, 46);
            btnDodajZemlju.Name = "btnDodajZemlju";
            btnDodajZemlju.Size = new Size(164, 30);
            btnDodajZemlju.TabIndex = 8;
            btnDodajZemlju.Text = "Dodaj zemlju";
            btnDodajZemlju.UseVisualStyleBackColor = true;
            btnDodajZemlju.Click += btnDodajZemlju_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(32, 80);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 9;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmDodajZemlju
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 122);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajZemlju);
            Controls.Add(txtNazivZemlje);
            Name = "frmDodajZemlju";
            Text = "ZEMLJA - Dodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazivZemlje;
        private Button btnDodajZemlju;
        private Button btnOdustani;
    }
}