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
            lvIdentifikatori = new ListView();
            colKey = new ColumnHeader();
            gpRevija.SuspendLayout();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(267, 81);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(356, 67);
            txtInfo.TabIndex = 14;
            // 
            // lblnfoOKolekciji
            // 
            lblnfoOKolekciji.AutoSize = true;
            lblnfoOKolekciji.BackColor = Color.Transparent;
            lblnfoOKolekciji.Location = new Point(267, 63);
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
            lblPrvaRevija.Location = new Point(267, 35);
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
            gpRevija.Location = new Point(337, 18);
            gpRevija.Name = "gpRevija";
            gpRevija.Size = new Size(91, 42);
            gpRevija.TabIndex = 16;
            gpRevija.TabStop = false;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(54, 17);
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
            btnOdustani.BackColor = SystemColors.MenuHighlight;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(459, 197);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(164, 30);
            btnOdustani.TabIndex = 18;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click_1;
            // 
            // btnDodajOrganizatora
            // 
            btnDodajOrganizatora.BackColor = SystemColors.MenuHighlight;
            btnDodajOrganizatora.Enabled = false;
            btnDodajOrganizatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajOrganizatora.ForeColor = Color.White;
            btnDodajOrganizatora.Location = new Point(267, 197);
            btnDodajOrganizatora.Name = "btnDodajOrganizatora";
            btnDodajOrganizatora.Size = new Size(164, 30);
            btnDodajOrganizatora.TabIndex = 17;
            btnDodajOrganizatora.Text = "Sačuvaj";
            btnDodajOrganizatora.UseVisualStyleBackColor = false;
            btnDodajOrganizatora.Click += btnDodajOrganizatora_Click;
            // 
            // lvIdentifikatori
            // 
            lvIdentifikatori.Columns.AddRange(new ColumnHeader[] { colKey });
            lvIdentifikatori.Location = new Point(4, 8);
            lvIdentifikatori.Name = "lvIdentifikatori";
            lvIdentifikatori.Size = new Size(237, 219);
            lvIdentifikatori.TabIndex = 19;
            lvIdentifikatori.UseCompatibleStateImageBehavior = false;
            lvIdentifikatori.View = View.Details;
            lvIdentifikatori.SelectedIndexChanged += lvIdentifikatori_SelectedIndexChanged;
            // 
            // colKey
            // 
            colKey.Text = "Identifikator";
            colKey.Width = 235;
            // 
            // frmDodajOrganizatora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 233);
            Controls.Add(lvIdentifikatori);
            Controls.Add(btnOdustani);
            Controls.Add(btnDodajOrganizatora);
            Controls.Add(gpRevija);
            Controls.Add(txtInfo);
            Controls.Add(lblnfoOKolekciji);
            Controls.Add(lblPrvaRevija);
            Name = "frmDodajOrganizatora";
            Text = "ORGANIZATOR - Dodaj";
            Load += frmDodajOrganizatora_Load;
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
        private ListView lvIdentifikatori;
        private ColumnHeader colKey;
    }
}