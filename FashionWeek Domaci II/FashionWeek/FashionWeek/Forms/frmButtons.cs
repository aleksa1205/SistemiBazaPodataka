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
                session!.Close();
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
                session!.Close();
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
                session!.Close();
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
                session!.Close();
            }
        }

        private async void btnDodajIZaposliManekena_Click(object sender, EventArgs e)
        {
            //Cascade ne funkcionise
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {

                    ModnaAgencija a = new ModnaAgencija
                    {
                        PIB = "55566677",
                        Naziv = "Goresnjak Agencija",
                        Inostrana = 'N',
                        Sediste = new()
                        {
                            Drzava = "Srbija",
                            Grad = "Subotica",
                            Ulica = "Suboticka 234"
                        },
                        DatumOsnivanja=DateTime.Now
                    };
                    Maneken m = new Maneken
                    {
                        MBR = "7774446665552",
                        Ime = new()
                        {
                            LicnoIme = "Milan",
                            Prezime = "Milanovic"
                        },
                        DatumRodjenja = DateTime.Now,
                        Pol = 'M',
                        Visina = 190,
                        Tezina = 100,
                        RadiUAgenciji = a
                    };

                    a.Manekeni.Add(m);
                    await session!.SaveAsync(a);
                    await session.SaveAsync(m);
                    await session.FlushAsync();
                    //m.RadiUAgenciji = a;
                    //await session.SaveAsync(m);
                    StringBuilder sb = new();
                    sb.AppendLine("Dodata je Modna agencija:");
                    sb.AppendLine($"{a.PIB}\n{a.Naziv}\n{a.Inostrana}");
                    sb.AppendLine("I maneken: ");
                    sb.AppendLine($"{m.MBR} {m.Ime.LicnoIme} {m.Ime.Prezime}\n {m.RadiUAgenciji.Naziv}");
                    MessageBox.Show(sb.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session!.Close();
            }
        }
    }
}