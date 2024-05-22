using FashionWeek;
using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Mapping;
using NHibernate.Util;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms
{
    public partial class frmButtons : Form
    {
        public frmButtons()
        {
            InitializeComponent();
        }

        private async void btnUcitajManekena_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    //Load - sigurni smo da objekat postoji u bazi
                    Maneken m = await session.LoadAsync<Maneken>("1507995583702");
                    MessageBox.Show($"{m.Ime.LicnoIme} {m.Ime.Prezime}");
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

        private async void btnDodajManekena_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken m = new()
                    {
                        MBR = "9998887776664",
                        Ime = new()
                        {
                            LicnoIme = "Marko",
                            Prezime = "Markovic"
                        },
                        Pol = 'M',
                        Visina = 180,
                        Tezina = 70,
                        Zanimanje = "Moler"
                    };
                    await session.SaveAsync(m);
                    await session.FlushAsync();
                    MessageBox.Show($"Uspesno dodat maneken sa maticnim brojem {m.MBR}");
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

        private async void btnManekenRadiU_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken m = await session.LoadAsync<Maneken>("1805000567932");
                    MessageBox.Show($"Maneken {m.MBR} - {m.Ime.LicnoIme} {m.Ime.Prezime} radi u modnoj agenciji {m.RadiUAgenciji!.Naziv} ");
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

        private async void btnManekenNastupaU_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken m = await session.LoadAsync<Maneken>("1204999538921");
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"{m.Ime.LicnoIme} {m.Ime.Prezime} sa maticnim brojem {m.MBR} je ucestvovao na sledecim modnim revijama: ");
                    foreach (var el in m.Revije)
                    {
                        sb.AppendLine($"{el.Naziv}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnManekeniModneAgencije_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija a = await session.LoadAsync<ModnaAgencija>("29186528");
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Manekeni modne agencije {a.Naziv}: ");
                    foreach (var el in a.Manekeni)
                    {
                        sb.AppendLine($"{el.Ime.LicnoIme} {el.Ime.Prezime}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnDodajManekenaIAgenciju_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    DomacaAgencija a = new DomacaAgencija
                    {
                        PIB = "22222222",
                        Naziv = "Opr Model Agency",
                        Inostrana = 'N',
                        Sediste = new()
                        {
                            Drzava = "Srbija",
                            Grad = "Doljevac",
                            Ulica = "Donji"
                        },
                        DatumOsnivanja = DateTime.Now
                    };
                    Maneken m = new Maneken
                    {
                        MBR = "5555555555555",
                        Ime = new()
                        {
                            LicnoIme = "Milenko",
                            Prezime = "Milenkovic"
                        },
                        DatumRodjenja = DateTime.Now,
                        Pol = 'M',
                        Visina = 200,
                        Tezina = 102
                    };

                    await session.SaveAsync(a);
                    m.RadiUAgenciji = a;
                    await session.SaveAsync(m);
                    a.Manekeni.Add(m);
                    await session.UpdateAsync(a);
                    await session.FlushAsync();

                    MessageBox.Show($"Modna agencija {a.PIB} {a.Naziv} je dodata u bazu i u nju je zaposljen maneken {m.Ime.LicnoIme} {m.Ime.Prezime}");
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

        private async void btnDodajCasopisManekenu_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken m = await session.GetAsync<Maneken>("0812993781023");
                    if (m != null)
                    {
                        Casopis c = new Casopis()
                        {
                            Id = new CasopisId()
                            {
                                Maneken = m,
                                NazivCasopisa = "Mnogo dobar casopis"
                            }
                        };
                        await session.SaveOrUpdateAsync(c);
                        await session.FlushAsync();
                        MessageBox.Show($"Dodat je casopis {c.Id.NazivCasopisa} u kome je {c.Id.Maneken.Ime.LicnoIme} {c.Id.Maneken.Ime.Prezime}");
                    }
                    else
                    {
                        MessageBox.Show($"Maneken sa maticnim brojem 0812993781023 ne postoji");
                    }
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

        private async void btnDodajManekenaAgenciji_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija a = await session.GetAsync<ModnaAgencija>("55566677");
                    if (a != null)
                    {
                        Maneken m = new Maneken
                        {
                            MBR = "2222222222222",
                            Ime = new Ime
                            {
                                LicnoIme = "Covek",
                                Prezime = "Dobar"
                            },
                            Pol = 'Z',
                            RadiUAgenciji = a
                        };
                        await session.SaveOrUpdateAsync(m);
                        a.Manekeni.Add(m);
                        await session.UpdateAsync(a);
                        await session.FlushAsync();
                        MessageBox.Show($"Maneken {m.Ime.LicnoIme} {m.Ime.Prezime} je dodat u agenciju {a.Naziv}");
                    }
                    else
                    {
                        MessageBox.Show("Modna agencija sa PIB-om 55566677 ne postoji!");
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAzurirajAgenciju_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija a = await session.GetAsync<ModnaAgencija>("55566677");
                    if (a != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Trenutna lokacija modne agencije {a.Naziv} je:");
                        sb.AppendLine($"Drzava: {a.Sediste?.Drzava}\nGrad: {a.Sediste?.Grad}\nUlica: {a.Sediste?.Ulica}");
                        a.Sediste!.Drzava = "Doljevac";
                        a.Sediste.Grad = "Dobar";

                        await session.UpdateAsync(a);
                        await session.FlushAsync();
                        await session.RefreshAsync(a);

                        sb.AppendLine("Nova lokacijaje:");
                        sb.AppendLine($"Drzava: {a.Sediste.Drzava}\nGrad: {a.Sediste.Grad}\nUlica: {a.Sediste.Ulica}");
                        MessageBox.Show(sb.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji agencija sa PIB-om 55566677");
                    }
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

        private async void btnFromKreatori_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("from ModniKreator");
                    IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Pronadjeni modni kreatori su:");
                    foreach (var kreator in kreatori)
                    {
                        sb.AppendLine($"{kreator.MBR}: {kreator.Ime.LicnoIme} {kreator.Ime.Prezime}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnFromKreatoriMuski_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("from ModniKreator as o where o.Pol='M'");
                    IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Muski modni kreatori: ");
                    foreach (var kreator in kreatori)
                    {
                        sb.AppendLine($"{kreator.MBR}: {kreator.Ime.LicnoIme} {kreator.Ime.Prezime}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnSelectModnaRevijaParametar_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("from ModnaRevija as o where o.Mesto.Grad= :grad");
                    query.SetString("grad", "Nis");
                    IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();

                    StringBuilder sb = new StringBuilder();
                    foreach (var revija in revije)
                    {
                        sb.AppendLine($"{revija.Naziv}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnRevijaById_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IQuery query = session.CreateQuery("select mr from ModnaRevija mr where mr.RBR = 3");
                    ModnaRevija mr = await query.UniqueResultAsync<ModnaRevija>();
                    MessageBox.Show($"{mr.RBR} {mr.Naziv}");
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

        private async void btnAgencijaByKriterijum_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ICriteria criteria = session.CreateCriteria<ModnaAgencija>();
                    criteria.Add(Restrictions.Eq("Inostrana", 'N'));
                    criteria.Add(Restrictions.Eq("Sediste.Drzava", "Srbija"));
                    IList<ModnaAgencija> agencije = await criteria.ListAsync<ModnaAgencija>();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Agencije koje su iz Srbije i nisu inostrane:");
                    foreach (var agencija in agencije)
                    {
                        sb.AppendLine($"{agencija.PIB}: {agencija.Naziv}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnQueryOverModneRevije_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IList<ModnaRevija> revije = await session.QueryOver<ModnaRevija>().Where(x => x.RBR >= 3).ListAsync<ModnaRevija>();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Modne revije cije je redni broj veci ili jednak 3: ");
                    foreach (var revija in revije)
                    {
                        sb.AppendLine($"{revija.RBR}: {revija.Naziv}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnUpitZaManekene_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MANEKEN");
                    query.AddEntity(typeof(Maneken));
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();

                    StringBuilder sb = new StringBuilder();
                    foreach (var maneken in manekeni)
                    {
                        sb.AppendLine($"{maneken.MBR}: {maneken.Ime.LicnoIme} {maneken.Ime.Prezime} {maneken.Pol}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnAzurirajManekena_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            ISession? newSession = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken m = await session.GetAsync<Maneken>("5555555555555");
                    if (m != null)
                    {
                        MessageBox.Show($"Meneken pre izmene: {m.Ime.LicnoIme} {m.Ime.Prezime}");
                        session.Close();
                        session = null;
                        m.Ime.Prezime = "MnogoDobro";

                        newSession = DataLayer.GetSession();
                        if (newSession != null)
                        {
                            await newSession.UpdateAsync(m);
                            await newSession.FlushAsync();
                            MessageBox.Show($"Maneken nakon izmene: {m.Ime.LicnoIme} {m.Ime.Prezime}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
                newSession?.Close();
            }
        }

        private async void btnObrisiManekena_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>("1008000784369");
                    if (maneken != null)
                    {
                        await session.DeleteAsync(maneken);
                        await session.FlushAsync();
                        MessageBox.Show($"Obrisan maneken sa maticnim brojem {maneken.MBR}");
                    }
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

        private async void btnObrisiManekenaTranscation_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            ITransaction? transaction = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>("2222222222222");
                    if (maneken != null)
                    {
                        transaction = session.BeginTransaction();
                        await session.DeleteAsync(maneken);
                        transaction?.CommitAsync();
                        MessageBox.Show($"Obrisan maneken sa maticnim brojem {maneken.MBR}");
                    }
                }
            }
            catch (Exception ex)
            {
                transaction?.RollbackAsync();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }

        private async void btnFromKreatoriMuskiLINQ_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    IList<ModniKreator> kreatori = await (from k in session.Query<ModniKreator>() where k.Pol == 'M' select k).ToListAsync();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Lista muskih modnih kreatora:");
                    foreach (var kreator in kreatori)
                    {
                        sb.AppendLine($"{kreator.MBR}: {kreator.Ime.LicnoIme} {kreator.Ime.Prezime}");
                    }
                    MessageBox.Show(sb.ToString());
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

        private async void btnObrisiModnuKucu_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaKuca kuca = await session.GetAsync<ModnaKuca>("Europe Fashion Ltd.");
                    if (kuca != null)
                    {
                        List<ModniKreator> kreatori = new List<ModniKreator>(kuca.Kreatori);
                        foreach (var kreator in kreatori)
                        {
                            kreator.RadiU = null;
                            await session.UpdateAsync(kreator);
                        }
                        await session.DeleteAsync(kuca);
                        await session.FlushAsync();

                        StringBuilder sb = new StringBuilder();
                        foreach (var kreator in kreatori)
                        {
                            sb.AppendLine($"{kreator.MBR}: {kreator.Ime.LicnoIme} {kreator.Ime.Prezime}");
                            if (kreator.RadiU != null)
                            {
                                sb.AppendLine($"{kreator.RadiU.Naziv}");
                            }
                        }
                        MessageBox.Show(sb.ToString());
                    }
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

        private async void btnObrisiReviju_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaRevija revija = await session.GetAsync<ModnaRevija>(3);
                    if (revija != null)
                    {
                        foreach (var man in revija.Manekeni)
                        {
                            man.Revije.Remove(revija);
                            await session.UpdateAsync(man);
                        }
                        foreach (var kreat in revija.Kreatori)
                        {
                            kreat.Revije.Remove(revija);
                            await session.UpdateAsync(kreat);

                        }
                        foreach (var specg in revija.SpecijalniGosti)
                        {
                            await session.DeleteAsync(specg);
                            await session.FlushAsync();

                        }
                        var org = revija.Organizator;
                        if (org != null)
                        {
                            org.ModneRevije.Remove(revija);
                        }
                        await session.UpdateAsync(org);
                        await session.DeleteAsync(revija);
                        await session.FlushAsync();


                        //StringBuilder sb = new();
                        //foreach(var el in revija.Manekeni)
                        //{
                        //    foreach(var i in el.Revije)
                        //    {
                        //        sb.AppendLine(i.Naziv);
                        //    }
                        //}
                        MessageBox.Show($"Obrisana je modna revija {revija.Naziv}");
                    }
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

        private async void btnDodajDrzavuAgenciji_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>("77141507");
                    if (agencija is InostranaAgencija)
                    {
                        NazivZemlje nz = new NazivZemlje
                        {
                            Id = new NazivZemljeId()
                            {
                                ModnaAgencija = agencija as InostranaAgencija,
                                NazivZemlje = "NovaZemlja"
                            }
                        };
                        await session.SaveOrUpdateAsync(nz);
                        await session.FlushAsync();
                        MessageBox.Show($"{nz.Id.NazivZemlje} je dodata kao zemlja u kojoj radi {nz.Id.ModnaAgencija!.Naziv}");

                    }
                    else
                    {
                        MessageBox.Show("Modna agencija nije inostrana i ne moze joj se dodati zemlja!");
                    }
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

        private async void btnObrisiZemljuAgenciji_Click(object sender, EventArgs e)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>("77141507");
                    if (agencija is InostranaAgencija)
                    {
                        List<NazivZemlje> nazivi = await (from k in session.Query<NazivZemlje>() select k).ToListAsync();
                        List<NazivZemlje> izdvojeni = nazivi.Where(x => x.Id.ModnaAgencija == agencija).ToList();
                        if (izdvojeni.Count != 0)
                        {
                            await session.DeleteAsync(izdvojeni[0]);
                            await session.FlushAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Modna agencija nije inostrana i ne moze joj se izbrisati zemlja!");
                    }
                }
            }
            catch(Exception ex)
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