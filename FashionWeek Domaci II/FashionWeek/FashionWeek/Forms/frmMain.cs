using FashionWeek.Entiteti;
using NHibernate;

namespace FashionWeek
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Maneken m = s.Load<Maneken>("1507995583702");
                MessageBox.Show($"{m.Ime.LicnoIme} {m.Ime.Prezime}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModniKreator m = s.Load<ModniKreator>("1005970748392");
                MessageBox.Show($"{m.Ime.LicnoIme} {m.Ime.Prezime}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
