namespace FashionWeek.Forms.Utils.ManekenForme
{
    partial class frmDodajCasopis
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
            btnDodajCasopis = new Button();
            txtNazivCasopisa = new TextBox();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(42, 80);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 12;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnDodajCasopis
            // 
            btnDodajCasopis.BackColor = SystemColors.MenuHighlight;
            btnDodajCasopis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajCasopis.ForeColor = Color.White;
            btnDodajCasopis.Location = new Point(42, 46);
            btnDodajCasopis.Name = "btnDodajCasopis";
            btnDodajCasopis.Size = new Size(164, 30);
            btnDodajCasopis.TabIndex = 11;
            btnDodajCasopis.Text = "Dodaj časopis";
            btnDodajCasopis.UseVisualStyleBackColor = false;
            btnDodajCasopis.Click += btnDodajCasopis_Click;
            // 
            // txtNazivCasopisa
            // 
            txtNazivCasopisa.Location = new Point(42, 12);
            txtNazivCasopisa.Name = "txtNazivCasopisa";
            txtNazivCasopisa.Size = new Size(164, 23);
            txtNazivCasopisa.TabIndex = 10;
            // 
            // frmDodajCasopis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 124);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajCasopis);
            Controls.Add(txtNazivCasopisa);
            Name = "frmDodajCasopis";
            Text = "MANEKEN - Dodaj časopis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnDodajCasopis;
        private TextBox txtNazivCasopisa;
    }
}