using FashionWeek.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.Linq;
using NHibernate.Stat;
using System;
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

        public static async Task<IList<ManekenPregled>> VratiNezaposleneManeken()
        {
            ISession? session = null;
            List<ManekenPregled> listaManekena = new List<ManekenPregled>();
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

        public static async Task<bool> ZaposliManekena(Maneken maneken, ModnaAgencija agencija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    maneken.RadiUAgenciji = agencija;
                    await session.UpdateAsync(maneken);
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

        public static async Task<bool> DodajRevijuManekenu(Maneken maneken, ModnaRevija revija)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    maneken.Revije.Add(revija);
                    await session.UpdateAsync(maneken);
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

        public static async Task<bool> ObrisiRevijuManekenu(ModnaRevija revija, Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    maneken.Revije.Remove(revija);
                    //revija.Manekeni.Remove(maneken);
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
                    string strQuery = "select mr from ModnaRevija mr join mr.Manekeni m where m.MBR!= :manekenMBR";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaAgencija;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion

        #region NaziviZemalja
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
                    IList<NazivZemlje> nazivZemljeIds = await query.ListAsync<NazivZemlje>();
                    foreach(var naziv in nazivZemljeIds)
                    {
                        if (naziv.Id.NazivZemlje == nazivZemlje)
                        {
                            throw new Exception($"{naziv.Id.InostranaAgencija?.Naziv} već posluje u {nazivZemlje}!");
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
        #endregion
    }
}
