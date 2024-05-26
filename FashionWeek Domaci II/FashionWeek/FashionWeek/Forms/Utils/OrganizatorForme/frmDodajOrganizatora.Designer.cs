namespace FashionWeek.Forms.Utils.OrganizatorForme
{
    partial class frmDodajOrganizatora
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
            txtInfo = new TextBox();
            lblnfoOKolekciji = new Label();
            lblPrvaRevija = new Label();
            gpRevija = new GroupBox();
            rbNo = new RadioButton();
            rbYes = new RadioButton();
            btnOdustani = new Button();
            btnDodajOrganizatora = new Button();
            gpRevija.SuspendLayout();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(147, 62);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(325, 67);
            txtInfo.TabIndex = 14;
            // 
            // lblnfoOKolekciji
            // 
            lblnfoOKolekciji.AutoSize = true;
            lblnfoOKolekciji.BackColor = Color.Transparent;
            lblnfoOKolekciji.Location = new Point(12, 89);
            lblnfoOKolekciji.Name = "lblnfoOKolekciji";
            lblnfoOKolekciji.Size = new Size(126, 15);
            lblnfoOKolekciji.TabIndex = 13;
            lblnfoOKolekciji.Text = "Informacije o kolekciji:";
            lblnfoOKolekciji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrvaRevija
            // 
            lblPrvaRevija.AutoSize = true;
            lblPrvaRevija.BackColor = Color.Transparent;
            lblPrvaRevija.Location = new Point(12, 30);
            lblPrvaRevija.Name = "lblPrvaRevija";
            lblPrvaRevija.Size = new Size(64, 15);
            lblPrvaRevija.TabIndex = 12;
            lblPrvaRevija.Text = "Prva revija:";
            lblPrvaRevija.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpRevija
            // 
            gpRevija.Controls.Add(rbNo);
            gpRevija.Controls.Add(rbYes);
            gpRevija.Location = new Point(96, 9);
            gpRevija.Name = "gpRevija";
            gpRevija.Size = new Size(91, 42);
            gpRevija.TabIndex = 16;
            gpRevija.TabStop = false;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(51, 19);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(31, 19);
            rbNo.TabIndex = 1;
            rbNo.Text = "F";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Checked = true;
            rbYes.Location = new Point(3, 19);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(31, 19);
            rbYes.TabIndex = 0;
            rbYes.TabStop = true;
            rbYes.Text = "T";
            rbYes.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(308, 143);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 18;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click_1;
            // 
            // btnDodajOrganizatora
            // 
            btnDodajOrganizatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajOrganizatora.Location = new Point(12, 143);
            btnDodajOrganizatora.Name = "btnDodajOrganizatora";
            btnDodajOrganizatora.Size = new Size(164, 30);
            btnDodajOrganizatora.TabIndex = 17;
            btnDodajOrganizatora.Text = "Sačuvaj";
            btnDodajOrganizatora.UseVisualStyleBackColor = true;
            btnDodajOrganizatora.Click += btnDodajOrganizatora_Click;
            // 
            // frmDodajOrganizatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 185);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajOrganizatora);
            Controls.Add(gpRevija);
            Controls.Add(txtInfo);
            Controls.Add(lblnfoOKolekciji);
            Controls.Add(lblPrvaRevija);
            Name = "frmDodajOrganizatora";
            Text = "ORGANIZATOR - Dodaj";
            gpRevija.ResumeLayout(false);
            gpRevija.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInfo;
        private Label lblnfoOKolekciji;
        private Label lblPrvaRevija;
        private GroupBox gpRevija;
        private RadioButton rbNo;
        private RadioButton rbYes;
        private Button btnOdustani;
        private Button btnDodajOrganizatora;
    }
}