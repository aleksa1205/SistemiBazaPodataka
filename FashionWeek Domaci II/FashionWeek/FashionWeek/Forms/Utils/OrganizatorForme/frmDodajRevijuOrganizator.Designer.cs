﻿namespace FashionWeek.Forms.Utils.OrganizatorForme
{
    partial class frmDodajRevijuOrganizator
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
            lblRevije = new Label();
            lvRevije = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnDodajReviju = new Button();
            btnIzadji = new Button();
            SuspendLayout();
            // 
            // lblRevije
            // 
            lblRevije.AutoSize = true;
            lblRevije.Font = new Font("Segoe UI", 12F);
            lblRevije.ForeColor = Color.Black;
            lblRevije.Location = new Point(12, 9);
            lblRevije.Name = "lblRevije";
            lblRevije.Size = new Size(326, 21);
            lblRevije.TabIndex = 15;
            lblRevije.Text = "Lista modnih revija koje nemaju organizatora:";
            // 
            // lvRevije
            // 
            lvRevije.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRevije.Location = new Point(12, 33);
            lvRevije.Name = "lvRevije";
            lvRevije.Size = new Size(574, 372);
            lvRevije.TabIndex = 14;
            lvRevije.UseCompatibleStateImageBehavior = false;
            lvRevije.View = View.Details;
            lvRevije.SelectedIndexChanged += lvRevije_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "RBR";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesto";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Termin";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 80;
            // 
            // btnDodajReviju
            // 
            btnDodajReviju.BackColor = SystemColors.MenuHighlight;
            btnDodajReviju.Enabled = false;
            btnDodajReviju.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajReviju.ForeColor = Color.White;
            btnDodajReviju.Location = new Point(592, 33);
            btnDodajReviju.Name = "btnDodajReviju";
            btnDodajReviju.Size = new Size(161, 30);
            btnDodajReviju.TabIndex = 20;
            btnDodajReviju.Text = "Dodaj reviju";
            btnDodajReviju.UseVisualStyleBackColor = false;
            btnDodajReviju.Click += btnDodajReviju_Click;
            // 
            // btnIzadji
            // 
            btnIzadji.BackColor = SystemColors.MenuHighlight;
            btnIzadji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzadji.ForeColor = Color.White;
            btnIzadji.Location = new Point(592, 375);
            btnIzadji.Name = "btnIzadji";
            btnIzadji.Size = new Size(161, 30);
            btnIzadji.TabIndex = 18;
            btnIzadji.Text = "Izađi";
            btnIzadji.UseVisualStyleBackColor = false;
            btnIzadji.Click += btnIzadji_Click;
            // 
            // frmDodajRevijuOrganizator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 411);
            Controls.Add(btnDodajReviju);
            Controls.Add(btnIzadji);
            Controls.Add(lblRevije);
            Controls.Add(lvRevije);
            Name = "frmDodajRevijuOrganizator";
            Text = "ORGANIZATOR - Dodaj reviju";
            Load += frmDodajRevijuOrganizator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRevije;
        private ListView lvRevije;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnDodajReviju;
        private Button btnIzadji;
    }
}