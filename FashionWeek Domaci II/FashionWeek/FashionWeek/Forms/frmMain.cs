using FashionWeek.Forms.Utils;
using FashionWeek.Forms.Utils.Agencija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms
{
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
    }
}