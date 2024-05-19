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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaRevija m = s.Load<ModnaRevija>(123);
                MessageBox.Show($"{m.Naziv}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ERROR
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //throws an exception not found even though that object exists in db
                ISession s = DataLayer.GetSession();
                ModnaKuca m = s.Load<ModnaKuca>("Nice Fashion");
                MessageBox.Show($"{m.Naziv} {m.Osnivac!.LicnoIme} {m.Osnivac.Prezime}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaAgencija m = s.Load<ModnaAgencija>("14074731");
                MessageBox.Show($"{m.Naziv}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Organizator m = s.Load<Organizator>(2);
                MessageBox.Show($" {m.InformacijeOKolekciji}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                //Planski baca error!!!
                ISession s = DataLayer.GetSession();
                SpecijalanGost m = s.Load<SpecijalanGost>("1904001783462");
                MessageBox.Show($" {m.Id.ModnaRevija.Naziv}");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
