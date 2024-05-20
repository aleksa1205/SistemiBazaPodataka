using FashionWeek.Entiteti;
using NHibernate;

namespace FashionWeek
{
    public partial class frmTest : Form
    {
        public frmTest()
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
                ModnaRevija m = s.Load<ModnaRevija>(1);
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
                Organizator m = s.Load<Organizator>(1);
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

        private async void button8_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModniKreator k = await session.LoadAsync<ModniKreator>("1005970748392");
                    ModnaRevija r = await session.LoadAsync<ModnaRevija>(2);
                    r.Kreatori.Remove(k);

                    await session.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            //1108980587321
            
                ISession? session = null;
                try
                {
                    session = DataLayer.GetSession();
                    if (session != null)
                    {
                        Maneken k = await session.LoadAsync<Maneken>("1008000784369");
                        session?.DeleteAsync(k);

                        await session?.FlushAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    session?.Close();
                }
        }
    }
}
