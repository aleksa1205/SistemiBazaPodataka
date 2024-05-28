namespace FashionWeek.Forms.Utils.OrganizatorForme
{
    partial class frmAzurirajOrganizatora
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
            btnAzuriraj = new Button();
            gpRevija = new GroupBox();
            rbNo = new RadioButton();
            rbYes = new RadioButton();
            txtInfo = new TextBox();
            lblnfoOKolekciji = new Label();
            lblPrvaRevija = new Label();
            lblID = new Label();
            txtID = new TextBox();
            lblIdentifikator = new Label();
            txtIdentifikator = new TextBox();
            gpRevija.SuspendLayout();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(316, 207);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 24;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = SystemColors.MenuHighlight;
            btnAzuriraj.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzuriraj.ForeColor = Color.White;
            btnAzuriraj.Location = new Point(12, 207);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(164, 30);
            btnAzuriraj.TabIndex = 23;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // gpRevija
            // 
            gpRevija.Controls.Add(rbNo);
            gpRevija.Controls.Add(rbYes);
            gpRevija.Location = new Point(85, 86);
            gpRevija.Name = "gpRevija";
            gpRevija.Size = new Size(91, 42);
            gpRevija.TabIndex = 22;
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
            // txtInfo
            // 
            txtInfo.Location = new Point(155, 134);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(325, 67);
            txtInfo.TabIndex = 21;
            // 
            // lblnfoOKolekciji
            // 
            lblnfoOKolekciji.AutoSize = true;
            lblnfoOKolekciji.BackColor = Color.Transparent;
            lblnfoOKolekciji.Location = new Point(12, 167);
            lblnfoOKolekciji.Name = "lblnfoOKolekciji";
            lblnfoOKolekciji.Size = new Size(126, 15);
            lblnfoOKolekciji.TabIndex = 20;
            lblnfoOKolekciji.Text = "Informacije o kolekciji:";
            lblnfoOKolekciji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrvaRevija
            // 
            lblPrvaRevija.AutoSize = true;
            lblPrvaRevija.BackColor = Color.Transparent;
            lblPrvaRevija.Location = new Point(12, 107);
            lblPrvaRevija.Name = "lblPrvaRevija";
            lblPrvaRevija.Size = new Size(64, 15);
            lblPrvaRevija.TabIndex = 19;
            lblPrvaRevija.Text = "Prva revija:";
            lblPrvaRevija.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Location = new Point(12, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 25;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(39, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(62, 23);
            txtID.TabIndex = 26;
            // 
            // lblIdentifikator
            // 
            lblIdentifikator.AutoSize = true;
            lblIdentifikator.Location = new Point(12, 52);
            lblIdentifikator.Name = "lblIdentifikator";
            lblIdentifikator.Size = new Size(74, 15);
            lblIdentifikator.TabIndex = 27;
            lblIdentifikator.Text = "Identifikator:";
            // 
            // txtIdentifikator
            // 
            txtIdentifikator.Enabled = false;
            txtIdentifikator.Location = new Point(92, 49);
            txtIdentifikator.Name = "txtIdentifikator";
            txtIdentifikator.Size = new Size(246, 23);
            txtIdentifikator.TabIndex = 28;
            // 
            // frmAzurirajOrganizatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 249);
            Controls.Add(txtIdentifikator);
            Controls.Add(lblIdentifikator);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(btnOdustani);
            Controls.Add(btnAzuriraj);
            Controls.Add(gpRevija);
            Controls.Add(txtInfo);
            Controls.Add(lblnfoOKolekciji);
            Controls.Add(lblPrvaRevija);
            Name = "frmAzurirajOrganizatora";
            Text = "ORGANIZATOR - Ažuriraj";
            Load += frmAzurirajOrganizatora_Load;
            gpRevija.ResumeLayout(false);
            gpRevija.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdustani;
        private Button btnAzuriraj;
        private GroupBox gpRevija;
        private RadioButton rbNo;
        private RadioButton rbYes;
        private TextBox txtInfo;
        private Label lblnfoOKolekciji;
        private Label lblPrvaRevija;
        private Label lblID;
        private TextBox txtID;
        private Label lblIdentifikator;
        private TextBox txtIdentifikator;
    }
}