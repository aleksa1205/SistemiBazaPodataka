using FashionWeek.Forms.Utils.ManekenForme;
using FashionWeek.Forms.Utils.RevijaForme;
using FashionWeek.Forms.Utils.AgencijaForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionWeek.Forms.Utils.Revija;
using FashionWeek.Forms.Utils.KreatorForme;

namespace FashionWeek.Forms;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnManekeni_Click(object sender, EventArgs e)
    {
        frmManekeni frmManeken = new frmManekeni();
        frmManeken.ShowDialog();
    }

    private void btnAgencije_Click(object sender, EventArgs e)
    {
        frmAgencije frmAgencije = new frmAgencije();
        frmAgencije.ShowDialog();
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevije frmRevije = new frmRevije();
        frmRevije.ShowDialog();
    }

    private void btnKreatori_Click(object sender, EventArgs e)
    {
        frmKreatori frmKreatori = new frmKreatori();
        frmKreatori.ShowDialog();
    }
}