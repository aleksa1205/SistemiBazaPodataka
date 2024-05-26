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
            gpRevija.SuspendLayout();
            SuspendLayout();
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(316, 170);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 24;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzuriraj.Location = new Point(12, 170);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(164, 30);
            btnAzuriraj.TabIndex = 23;
            btnAzuriraj.Text = "Ažuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // gpRevija
            // 
            gpRevija.Controls.Add(rbNo);
            gpRevija.Controls.Add(rbYes);
            gpRevija.Location = new Point(82, 35);
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
            txtInfo.Location = new Point(144, 83);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(325, 67);
            txtInfo.TabIndex = 21;
            // 
            // lblnfoOKolekciji
            // 
            lblnfoOKolekciji.AutoSize = true;
            lblnfoOKolekciji.BackColor = Color.Transparent;
            lblnfoOKolekciji.Location = new Point(12, 115);
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
            lblPrvaRevija.Location = new Point(12, 56);
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
            // frmAzurirajOrganizatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 215);
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
    }
}