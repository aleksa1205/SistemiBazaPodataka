namespace FashionWeek.Forms.Utils.ManekenForme
{
    partial class frmNaziviCasopisaManekena
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
            lblNazivAgencije = new Label();
            btnObrisiCasopis = new Button();
            btnDodajCasopis = new Button();
            btnOdustani = new Button();
            lvCasopisi = new ListView();
            colCasopis = new ColumnHeader();
            lblSpisakCasopisa = new Label();
            lblManeken = new Label();
            SuspendLayout();
            // 
            // lblNazivAgencije
            // 
            lblNazivAgencije.AutoSize = true;
            lblNazivAgencije.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNazivAgencije.Location = new Point(231, 29);
            lblNazivAgencije.Name = "lblNazivAgencije";
            lblNazivAgencije.Size = new Size(0, 21);
            lblNazivAgencije.TabIndex = 15;
            // 
            // btnObrisiCasopis
            // 
            btnObrisiCasopis.Enabled = false;
            btnObrisiCasopis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiCasopis.Location = new Point(170, 105);
            btnObrisiCasopis.Name = "btnObrisiCasopis";
            btnObrisiCasopis.Size = new Size(161, 30);
            btnObrisiCasopis.TabIndex = 14;
            btnObrisiCasopis.Text = "Obriši časopis";
            btnObrisiCasopis.UseVisualStyleBackColor = true;
            btnObrisiCasopis.Click += btnObrisiCasopis_Click;
            // 
            // btnDodajCasopis
            // 
            btnDodajCasopis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajCasopis.Location = new Point(170, 69);
            btnDodajCasopis.Name = "btnDodajCasopis";
            btnDodajCasopis.Size = new Size(161, 30);
            btnDodajCasopis.TabIndex = 13;
            btnDodajCasopis.Text = "Dodaj časopis";
            btnDodajCasopis.UseVisualStyleBackColor = true;
            btnDodajCasopis.Click += btnDodajCasopis_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdustani.Location = new Point(170, 444);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(161, 30);
            btnOdustani.TabIndex = 12;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // lvCasopisi
            // 
            lvCasopisi.Columns.AddRange(new ColumnHeader[] { colCasopis });
            lvCasopisi.Location = new Point(12, 69);
            lvCasopisi.Name = "lvCasopisi";
            lvCasopisi.Size = new Size(155, 405);
            lvCasopisi.TabIndex = 11;
            lvCasopisi.UseCompatibleStateImageBehavior = false;
            lvCasopisi.View = View.Details;
            lvCasopisi.SelectedIndexChanged += lvCasopisi_SelectedIndexChanged;
            // 
            // colCasopis
            // 
            colCasopis.Text = "Časopis";
            colCasopis.Width = 150;
            // 
            // lblSpisakCasopisa
            // 
            lblSpisakCasopisa.AutoSize = true;
            lblSpisakCasopisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpisakCasopisa.Location = new Point(12, 9);
            lblSpisakCasopisa.Name = "lblSpisakCasopisa";
            lblSpisakCasopisa.Size = new Size(314, 21);
            lblSpisakCasopisa.TabIndex = 10;
            lblSpisakCasopisa.Text = "Spisak časopisa u kojima se našao maneken\r\n";
            // 
            // lblManeken
            // 
            lblManeken.AutoSize = true;
            lblManeken.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManeken.Location = new Point(12, 45);
            lblManeken.Name = "lblManeken";
            lblManeken.Size = new Size(0, 21);
            lblManeken.TabIndex = 16;
            // 
            // frmNaziviCasopisaManekena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 486);
            Controls.Add(lblManeken);
            Controls.Add(lblNazivAgencije);
            Controls.Add(btnObrisiCasopis);
            Controls.Add(btnDodajCasopis);
            Controls.Add(btnOdustani);
            Controls.Add(lvCasopisi);
            Controls.Add(lblSpisakCasopisa);
            Name = "frmNaziviCasopisaManekena";
            Text = "MANEKEN - Nazivi časopisa";
            Load += frmNaziviCasopisaManekena_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivAgencije;
        private Button btnObrisiCasopis;
        private Button btnDodajCasopis;
        private Button btnOdustani;
        private ListView lvCasopisi;
        private ColumnHeader colCasopis;
        private Label lblSpisakCasopisa;
        private Label lblManeken;
    }
}