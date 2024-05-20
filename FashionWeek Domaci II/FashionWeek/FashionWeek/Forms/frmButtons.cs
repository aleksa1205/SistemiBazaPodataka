using FashionWeek;
using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using NHibernate;
using System;
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
                    await session.SaveOrUpdateAsync(m);
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
                    ModnaAgencija a = new ModnaAgencija
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
                    string? mbr = "0812993781023";
                    Maneken m = await session.GetAsync<Maneken>(mbr);
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
                        MessageBox.Show($"Maneken sa maticnim brojem {mbr} ne postoji");
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
    }
}