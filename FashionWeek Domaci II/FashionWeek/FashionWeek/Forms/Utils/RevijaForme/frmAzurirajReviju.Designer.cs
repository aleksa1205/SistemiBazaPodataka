namespace FashionWeek.Forms.Utils.RevijaForme;

partial class frmAzurirajReviju
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
        txtDrzava = new TextBox();
        btnOdustani = new Button();
        btnAzuriraj = new Button();
        txtGrad = new TextBox();
        txtUlica = new TextBox();
        dtpTermin = new DateTimePicker();
        txtNaziv = new TextBox();
        lblTermin = new Label();
        lblDrzava = new Label();
        lblGrad = new Label();
        lblUlica = new Label();
        lblNaziv = new Label();
        lblRBR = new Label();
        txtRBR = new TextBox();
        SuspendLayout();
        // 
        // txtDrzava
        // 
        txtDrzava.Location = new Point(117, 92);
        txtDrzava.Name = "txtDrzava";
        txtDrzava.Size = new Size(116, 23);
        txtDrzava.TabIndex = 79;
        // 
        // btnOdustani
        // 
        btnOdustani.BackColor = SystemColors.MenuHighlight;
        btnOdustani.ForeColor = Color.White;
        btnOdustani.Location = new Point(300, 147);
        btnOdustani.Name = "btnOdustani";
        btnOdustani.Size = new Size(75, 23);
        btnOdustani.TabIndex = 78;
        btnOdustani.Text = "Odustani";
        btnOdustani.UseVisualStyleBackColor = false;
        btnOdustani.Click += btnOdustani_Click;
        // 
        // btnAzuriraj
        // 
        btnAzuriraj.BackColor = SystemColors.MenuHighlight;
        btnAzuriraj.ForeColor = Color.White;
        btnAzuriraj.Location = new Point(300, 121);
        btnAzuriraj.Name = "btnAzuriraj";
        btnAzuriraj.Size = new Size(75, 23);
        btnAzuriraj.TabIndex = 77;
        btnAzuriraj.Text = "Ažuriraj";
        btnAzuriraj.UseVisualStyleBackColor = false;
        btnAzuriraj.Click += btnAzuriraj_Click;
        // 
        // txtGrad
        // 
        txtGrad.Location = new Point(117, 121);
        txtGrad.Name = "txtGrad";
        txtGrad.Size = new Size(116, 23);
        txtGrad.TabIndex = 76;
        // 
        // txtUlica
        // 
        txtUlica.Location = new Point(117, 147);
        txtUlica.Name = "txtUlica";
        txtUlica.Size = new Size(116, 23);
        txtUlica.TabIndex = 75;
        // 
        // dtpTermin
        // 
        dtpTermin.Location = new Point(117, 61);
        dtpTermin.Name = "dtpTermin";
        dtpTermin.Size = new Size(200, 23);
        dtpTermin.TabIndex = 74;
        // 
        // txtNaziv
        // 
        txtNaziv.Location = new Point(117, 35);
        txtNaziv.Name = "txtNaziv";
        txtNaziv.Size = new Size(116, 23);
        txtNaziv.TabIndex = 73;
        // 
        // lblTermin
        // 
        lblTermin.AutoSize = true;
        lblTermin.BackColor = Color.Red;
        lblTermin.Location = new Point(12, 67);
        lblTermin.Name = "lblTermin";
        lblTermin.Size = new Size(43, 15);
        lblTermin.TabIndex = 72;
        lblTermin.Text = "Termin";
        lblTermin.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDrzava
        // 
        lblDrzava.AutoSize = true;
        lblDrzava.BackColor = Color.Transparent;
        lblDrzava.Location = new Point(12, 95);
        lblDrzava.Name = "lblDrzava";
        lblDrzava.Size = new Size(42, 15);
        lblDrzava.TabIndex = 71;
        lblDrzava.Text = "Država";
        lblDrzava.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblGrad
        // 
        lblGrad.AutoSize = true;
        lblGrad.Location = new Point(12, 124);
        lblGrad.Name = "lblGrad";
        lblGrad.Size = new Size(35, 15);
        lblGrad.TabIndex = 70;
        lblGrad.Text = "Grad:";
        lblGrad.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUlica
        // 
        lblUlica.AutoSize = true;
        lblUlica.Location = new Point(12, 150);
        lblUlica.Name = "lblUlica";
        lblUlica.Size = new Size(33, 15);
        lblUlica.TabIndex = 69;
        lblUlica.Text = "Ulica";
        lblUlica.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblNaziv
        // 
        lblNaziv.AutoSize = true;
        lblNaziv.BackColor = Color.Red;
        lblNaziv.Location = new Point(12, 38);
        lblNaziv.Name = "lblNaziv";
        lblNaziv.Size = new Size(39, 15);
        lblNaziv.TabIndex = 68;
        lblNaziv.Text = "Naziv:";
        lblNaziv.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblRBR
        // 
        lblRBR.AutoSize = true;
        lblRBR.BackColor = Color.Red;
        lblRBR.Location = new Point(12, 9);
        lblRBR.Name = "lblRBR";
        lblRBR.Size = new Size(31, 15);
        lblRBR.TabIndex = 80;
        lblRBR.Text = "RBR:";
        lblRBR.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtRBR
        // 
        txtRBR.Enabled = false;
        txtRBR.Location = new Point(117, 6);
        txtRBR.Name = "txtRBR";
        txtRBR.Size = new Size(116, 23);
        txtRBR.TabIndex = 81;
        // 
        // frmAzurirajReviju
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(393, 178);
        Controls.Add(txtRBR);
        Controls.Add(lblRBR);
        Controls.Add(txtDrzava);
        Controls.Add(btnOdustani);
        Controls.Add(btnAzuriraj);
        Controls.Add(txtGrad);
        Controls.Add(txtUlica);
        Controls.Add(dtpTermin);
        Controls.Add(txtNaziv);
        Controls.Add(lblTermin);
        Controls.Add(lblDrzava);
        Controls.Add(lblGrad);
        Controls.Add(lblUlica);
        Controls.Add(lblNaziv);
        Name = "frmAzurirajReviju";
        Text = "REVIJA - Ažuriraj";
        Load += frmAzurirajReviju_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtDrzava;
    private Button btnOdustani;
    private Button btnAzuriraj;
    private TextBox txtGrad;
    private TextBox txtUlica;
    private DateTimePicker dtpTermin;
    private TextBox txtNaziv;
    private Label lblTermin;
    private Label lblDrzava;
    private Label lblGrad;
    private Label lblUlica;
    private Label lblNaziv;
    private Label lblRBR;
    private TextBox txtRBR;
}