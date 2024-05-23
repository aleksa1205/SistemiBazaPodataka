using FashionWeek.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.ManekenForme
{
    public partial class frmDodajCasopis : Form
    {
        public frmDodajCasopis()
        {
            InitializeComponent();
        }

        private async void btnDodajCasopis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivCasopisa.Text))
            {
                MessageBox.Show("Naziv časopisa mora biti popunjen!");
                return;
            }
            if(await DTOManager.DodajCasopis(frmManekeni._manekenMBR!, txtNazivCasopisa.Text))
            {
                MessageBox.Show("Uspešno dodat časopis!");
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
