namespace FashionWeek.Forms.Utils.OrganizatorForme
{
    partial class frmOrganizatori
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
            btnIzadji = new Button();
            btnRevije = new Button();
            btnObrisiOrganiztora = new Button();
            btnAzurirajOrganizatora = new Button();
            btnDodajOrganizatora = new Button();
            lvOrganizatori = new ListView();
            colId = new ColumnHeader();
            colPrvaRevija = new ColumnHeader();
            colInfo = new ColumnHeader();
            lblListaOrganizatora = new Label();
            SuspendLayout();
            // 
            // btnIzadji
            // 
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.Location = new Point(604, 408);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 22;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = true;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // btnRevije
            // 
            btnRevije.Enabled = false;
            btnRevije.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevije.Location = new Point(604, 186);
            btnRevije.Name = "btnRevije";
            btnRevije.Size = new Size(161, 30);
            btnRevije.TabIndex = 21;
            btnRevije.Text = "Revije";
            btnRevije.UseVisualStyleBackColor = true;
            btnRevije.Click += btnRevije_Click;
            // 
            // btnObrisiOrganiztora
            // 
            btnObrisiOrganiztora.Enabled = false;
            btnObrisiOrganiztora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisiOrganiztora.Location = new Point(604, 105);
            btnObrisiOrganiztora.Name = "btnObrisiOrganiztora";
            btnObrisiOrganiztora.Size = new Size(161, 30);
            btnObrisiOrganiztora.TabIndex = 20;
            btnObrisiOrganiztora.Text = "Obriši organizatora";
            btnObrisiOrganiztora.UseVisualStyleBackColor = true;
            btnObrisiOrganiztora.Click += btnObrisiOrganiztora_Click;
            // 
            // btnAzurirajOrganizatora
            // 
            btnAzurirajOrganizatora.Enabled = false;
            btnAzurirajOrganizatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAzurirajOrganizatora.Location = new Point(604, 69);
            btnAzurirajOrganizatora.Name = "btnAzurirajOrganizatora";
            btnAzurirajOrganizatora.Size = new Size(161, 30);
            btnAzurirajOrganizatora.TabIndex = 19;
            btnAzurirajOrganizatora.Text = "Ažuriraj organizatora";
            btnAzurirajOrganizatora.UseVisualStyleBackColor = true;
            btnAzurirajOrganizatora.Click += btnAzurirajOrganizatora_Click;
            // 
            // btnDodajOrganizatora
            // 
            btnDodajOrganizatora.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajOrganizatora.Location = new Point(604, 33);
            btnDodajOrganizatora.Name = "btnDodajOrganizatora";
            btnDodajOrganizatora.Size = new Size(161, 30);
            btnDodajOrganizatora.TabIndex = 18;
            btnDodajOrganizatora.Text = "Dodaj organizatora";
            btnDodajOrganizatora.UseVisualStyleBackColor = true;
            btnDodajOrganizatora.Click += btnDodajOrganizatora_Click;
            // 
            // lvOrganizatori
            // 
            lvOrganizatori.Columns.AddRange(new ColumnHeader[] { colId, colPrvaRevija, colInfo });
            lvOrganizatori.Location = new Point(12, 33);
            lvOrganizatori.Name = "lvOrganizatori";
            lvOrganizatori.Size = new Size(586, 405);
            lvOrganizatori.TabIndex = 17;
            lvOrganizatori.UseCompatibleStateImageBehavior = false;
            lvOrganizatori.View = View.Details;
            lvOrganizatori.SelectedIndexChanged += lvOrganizatori_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 40;
            // 
            // colPrvaRevija
            // 
            colPrvaRevija.Text = "Prva";
            colPrvaRevija.TextAlign = HorizontalAlignment.Center;
            colPrvaRevija.Width = 40;
            // 
            // colInfo
            // 
            colInfo.Text = "Informacije o kolekciji";
            colInfo.TextAlign = HorizontalAlignment.Center;
            colInfo.Width = 500;
            // 
            // lblListaOrganizatora
            // 
            lblListaOrganizatora.AutoSize = true;
            lblListaOrganizatora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaOrganizatora.Location = new Point(11, 9);
            lblListaOrganizatora.Name = "lblListaOrganizatora";
            lblListaOrganizatora.Size = new Size(137, 21);
            lblListaOrganizatora.TabIndex = 16;
            lblListaOrganizatora.Text = "Lista organizatora:";
            // 
            // frmOrganizatori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(btnIzadji);
            Controls.Add(btnRevije);
            Controls.Add(btnObrisiOrganiztora);
            Controls.Add(btnAzurirajOrganizatora);
            Controls.Add(btnDodajOrganizatora);
            Controls.Add(lvOrganizatori);
            Controls.Add(lblListaOrganizatora);
            Name = "frmOrganizatori";
            Text = "ORGANIZATORI";
            Load += frmOrganizatori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIzadji;
        private Button btnRevije;
        private Button btnObrisiOrganiztora;
        private Button btnAzurirajOrganizatora;
        private Button btnDodajOrganizatora;
        private ListView lvOrganizatori;
        private Label lblListaOrganizatora;
        private ColumnHeader colId;
        private ColumnHeader colPrvaRevija;
        private ColumnHeader colInfo;
    }
}