using FashionWeek.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.Linq;
using NHibernate.Stat;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FashionWeek.DTO
{
    public class DTOManager
    {

        #region Maneken
        public static async Task<Maneken> VratiManekena(string mbr)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>(mbr);
                    return maneken;
                }
                throw new Exception("Konekcija sa bazom nije ostvarena!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null!;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ManekenPregled>> VratiManekene()
        {
            ISession? session = null;
            List<ManekenPregled> listaManekena = new List<ManekenPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MANEKEN");
                    query.AddEntity(typeof(Maneken));
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();

                    foreach (var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenPregled(maneken));
                    }
                    return listaManekena;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ManekenNezaposlenPregled>> VratiNezaposleneManeken()
        {
            ISession? session = null;
            List<ManekenNezaposlenPregled> listaManekena = new List<ManekenNezaposlenPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MANEKEN WHERE PIB_AGENCIJE IS NULL");
                    query.AddEntity(typeof(Maneken));
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();

                    foreach (var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenNezaposlenPregled(maneken));
                    }
                    return listaManekena;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }


        public static async Task<bool> DodajManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.SaveAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                else
                {
                    throw new Exception("Konekcija sa bazom nije ostvarena!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> AzurirajManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.UpdateAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                else
                {
                    throw new Exception("Konekcija sa bazom nije ostvarena!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ZaposliManekena(string mbrManekena, string pibAgencija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>(mbrManekena);
                    ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pibAgencija);
                    if (maneken != null && agencija != null)
                    {
                        maneken.RadiUAgenciji = agencija;
                        await session.UpdateAsync(maneken);
                        await session.FlushAsync();
                        return true;
                    }
                    throw new Exception("Greška pri pribavljanju manekena i agencije!");
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DajOtkazManeken(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    maneken.RadiUAgenciji = null;
                    await session.UpdateAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajRevijuManekenu(string manekenMBR, int revijaRBR)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>(manekenMBR);
                    ModnaRevija revija = await session.GetAsync<ModnaRevija>(revijaRBR);
                    if(maneken!=null && revija != null)
                    {
                        maneken.Revije.Add(revija);
                        await session.UpdateAsync(maneken);
                        await session.FlushAsync();
                        return true;
                    }
                    throw new Exception("Greška pri pribavljanju manekena i revije!");
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiRevijuManekenu(string mbrManekena, int rbrRevije)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>(mbrManekena);
                    ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbrRevije);
                    if (maneken != null && revija != null)
                    {
                        maneken.Revije.Remove(revija);
                        await session.UpdateAsync(maneken);
                        await session.FlushAsync();
                        return true;
                    }
                    throw new Exception("Greška pri pribavljanju manekena i revije!");
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                else
                {
                    throw new Exception("Konekcija sa bazom nije ostvarena!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region ModnaRevija
        public static async Task<IList<ModnaRevijaPregled>> VratiModneRevije()
        {
            ISession? session = null;
            List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNA_REVIJA");
                    query.AddEntity(typeof(ModnaRevija));
                    IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();

                    foreach(var revija in revije)
                    {
                        listaRevija.Add(new ModnaRevijaPregled(revija));
                    }
                    return listaRevija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaRevija;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijaManekena(Maneken maneken)
        {
            ISession? session = null;
            List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    string strQuery = "select mr from ModnaRevija mr join mr.Manekeni m where m.MBR= :manekenMBR";
                    IQuery query = session.CreateQuery(strQuery);
                    query.SetParameter("manekenMBR", maneken.MBR);
                    IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                    foreach (var revija in revije)
                    {
                        listaRevija.Add(new ModnaRevijaPregled(revija));
                    }
                    return listaRevija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return listaRevija;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ModnaRevijaPregled>> VratiNepostojeceRevijeManekena(Maneken maneken)
        {
            ISession? session = null;
            List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    string strQuery = "select mr from ModnaRevija mr where mr.RBR not in (select mr2 from ModnaRevija mr2 join mr2.Manekeni m where m.MBR= :manekenMBR)";
                    IQuery query = session.CreateQuery(strQuery);
                    query.SetParameter("manekenMBR", maneken.MBR);
                    IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                    foreach (var revija in revije)
                    {
                        listaRevija.Add(new ModnaRevijaPregled(revija));
                    }
                    return listaRevija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaRevija;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ManekenPregled>> VratiManekeneModneRevije(ModnaRevija revija)
        {
            ISession? session = null;
            IList<ManekenPregled> listaManekena = new List<ManekenPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    string strQuery = "select m from Maneken m join m.Revije mr where mr.RBR= :rbrRevije";
                    IQuery query = session.CreateQuery(strQuery);
                    query.SetParameter("rbrRevije", revija.RBR);
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                    
                    foreach(var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenPregled(maneken));
                    }
                    return listaManekena;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();   
            }
        }

        public static async Task<IList<ManekenPregled>> VratiManekenKojeNisuNaModnojReviji(ModnaRevija revija)
        {
            ISession session = DataLayer.GetSession();
            IList<ManekenPregled> listaManekena = new List<ManekenPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {

                    string strQuery = "select m from Maneken m where m.MBR not in (select m2.MBR from Maneken m2 join m2.Revije r where r.RBR= :rbrRevije)";
                    IQuery query = session.CreateQuery(strQuery);
                    query.SetParameter("rbrRevije", revija.RBR);
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();

                    foreach (var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenPregled(maneken));
                    }
                    return listaManekena;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<ModnaRevija> VratiModnuReviju(int rbr)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
                    return revija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajReviju(ModnaRevija revija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.SaveAsync(revija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> AzurirajReviju(ModnaRevija revija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.UpdateAsync(revija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiReviju(ModnaRevija revija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(revija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region ModnaAgencija
        public static async Task<IList<ModnaAgencijaPregled>> VratiModneAgencije()
        {
            ISession? session = null;
            IList<ModnaAgencijaPregled> listaAgencija = new List<ModnaAgencijaPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNA_AGENCIJA");
                    query.AddEntity(typeof(ModnaAgencija));
                    IList<ModnaAgencija> agencije = await query.ListAsync<ModnaAgencija>();

                    foreach (var agencija in agencije)
                    {
                        listaAgencija.Add(new ModnaAgencijaPregled(agencija));
                    }
                    return listaAgencija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaAgencija;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ManekenPregled>> VratiManekeneModneAgencijePregled(ModnaAgencija agencija)
        {
            ISession? session = null;
            IList<ManekenPregled> listaManekena = new List<ManekenPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    string strQuery = "select m from Maneken m join m.RadiUAgenciji r where r= :agencijaPIB";
                    IQuery query = session.CreateQuery(strQuery);
                    query.SetParameter("agencijaPIB", agencija);
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                    foreach (var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenPregled(maneken));
                    }
                    return listaManekena;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<ModnaAgencija> VratiModnuAgenciju(string pib)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
                    return agencija;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null!;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajModnuAgenciju(ModnaAgencija agencija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.SaveAsync(agencija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> AzurirajModnuAgenciju(ModnaAgencija agencija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.UpdateAsync(agencija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiModnuAgenciju(ModnaAgencija agencija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(agencija);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region NaziviZemalja
        public static async Task<IList<string>> VratiZemljeUKojimaPoslujeAgencijaPregled(ModnaAgencija agencija)
        {
            ISession? session = null;
            IList<string> listaZemalja = new List<string>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    if (agencija is InostranaAgencija)
                    {
                        ISQLQuery query = session.CreateSQLQuery($"SELECT * FROM NAZIVI_ZEMALJA WHERE PIB_INOSTRANE={agencija.PIB}");
                        query.AddEntity(typeof(NazivZemlje));
                        IList<NazivZemlje> nazivZemljeIds = await query.ListAsync<NazivZemlje>();
                        foreach (var zemljaId in nazivZemljeIds)
                        {
                            listaZemalja.Add(zemljaId.Id.NazivZemlje);
                        }
                        return listaZemalja;
                    }
                    throw new Exception("Agencija mora biti inostrana!");
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaZemalja;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajZemlju(InostranaAgencija agencija, string nazivZemlje)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery($"SELECT * FROM NAZIVI_ZEMALJA WHERE PIB_INOSTRANE={agencija.PIB}");
                    query.AddEntity(typeof(NazivZemlje));
                    IList<NazivZemlje> naziviZemalja = await query.ListAsync<NazivZemlje>();
                    foreach(var zemlja in naziviZemalja)
                    {
                        if (zemlja.Id.NazivZemlje == nazivZemlje)
                        {
                            throw new Exception($"{zemlja.Id.InostranaAgencija?.Naziv} već posluje u {nazivZemlje}!");
                        }
                    }

                    NazivZemlje novaZemlja = new NazivZemlje()
                    {
                        Id = new NazivZemljeId
                        {
                            InostranaAgencija = agencija,
                            NazivZemlje = nazivZemlje
                        }
                    };
                    await session.SaveAsync(novaZemlja);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiZemlju(NazivZemlje nazivZemlje)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(nazivZemlje);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region NaziviCasopisa
        public static async Task<IList<string>> VratiCasopiseManekena(Maneken maneken)
        {
            ISession? session = null;
            IList<string> listaCasopisa = new List<string>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery($"SELECT * FROM NAZIVI_CASOPISA WHERE MBR_MANEKENA={maneken.MBR}");
                    query.AddEntity(typeof(Casopis));
                    IList<Casopis> casopisi = await query.ListAsync<Casopis>();
                    foreach (var casopis in casopisi)
                    {
                        listaCasopisa.Add(casopis.Id.NazivCasopisa);
                    }
                    return listaCasopisa;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaCasopisa;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajCasopis(Maneken maneken, string nazivCasopisa)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery($"SELECT * FROM NAZIVI_CASOPISA WHERE MBR_MANEKENA={maneken.MBR}");
                    query.AddEntity(typeof(Casopis));
                    IList<Casopis> casopisi = await query.ListAsync<Casopis>();
                    foreach (var casopis in casopisi)
                    {
                        if (casopis.Id.NazivCasopisa == nazivCasopisa)
                        {
                            throw new Exception($"{maneken.Ime.ToString()} je već u časopiusu {nazivCasopisa}!");
                        }
                    }

                    Casopis noviCasopis = new Casopis()
                    {
                        Id = new CasopisId()
                        {
                            Maneken = maneken,
                            NazivCasopisa = nazivCasopisa
                        }
                    };
                    await session.SaveAsync(noviCasopis);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> ObrisiCasopis(Casopis casopis) 
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(casopis);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region ModniKreator
        public static async Task<ModniKreator> VratiModnogKreatora(string mbr) 
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
                    return kreator;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<IList<ModniKreatorPregled>> VratiModneKreatore() 
        {
            ISession? session = null;
            IList<ModniKreatorPregled> listaKreatora = new List<ModniKreatorPregled>();
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNI_KREATOR");
                    query.AddEntity(typeof(ModniKreator));
                    IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();

                    foreach(var kreator in kreatori)
                    {
                        listaKreatora.Add(new ModniKreatorPregled(kreator));
                    }
                    return listaKreatora;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaKreatora;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> DodajModnogKreatora(ModniKreator kreator)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.SaveAsync(kreator);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> AzurirajModnogKreatora(ModniKreator kreator)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.UpdateAsync(kreator);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri povezivanju sa bazom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion
    }
}
