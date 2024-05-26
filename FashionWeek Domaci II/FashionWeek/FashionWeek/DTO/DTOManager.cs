using NHibernate.Param;
using NHibernate.Transform;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace FashionWeek.DTO;

public class DTOManager
{
    #region Maneken
    public static async Task<ManekenBasic?> VratiManekenaBasic(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.GetAsync<Maneken>(mbr);
                return maneken != null ? new(maneken) : null;
            }
            throw new Exception("Konekcija sa bazom nije ostvarena!");
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

    public static async Task<bool> DodajManekena(ManekenBasic maneken)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken noviManeken = Helper.NewManeken(maneken);
                await session.SaveAsync(noviManeken);
                await session.FlushAsync();
                return true;
            }
            throw new Exception("Konekcija sa bazom nije ostvarena!");

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

    public static async Task<bool> AzurirajManekena(ManekenBasic updateManeken)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.LoadAsync<Maneken>(updateManeken.MBR);
                Helper.UpdateManeken(maneken, updateManeken);
                await session.UpdateAsync(maneken);
                await session.FlushAsync();
                return true;
            }
            throw new Exception("Konekcija sa bazom nije ostvarena!");
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

    public static async Task<bool> ObrisiManekena(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.LoadAsync<Maneken>(mbr);
                await session.DeleteAsync(maneken);
                await session.FlushAsync();
                return true;
            }
            else
            {
                throw new Exception("Konekcija sa bazom nije ostvarena!");
            }
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
                listaManekena.AddRange(manekeni.Select(maneken => new ManekenPregled(maneken)));
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
                listaManekena.AddRange(manekeni.Select(maneken => new ManekenNezaposlenPregled(maneken)));
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

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijaManekena(string mbrManekena)
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
                query.SetParameter("manekenMBR", mbrManekena);
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<IList<string>> VratiCasopiseManekena(string mbrManekena)
    {
        ISession? session = null;
        List<string> listaCasopisa = new List<string>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery($"SELECT NAZIV_CASOPISA FROM NAZIVI_CASOPISA WHERE MBR_MANEKENA={mbrManekena}");
                listaCasopisa.AddRange(await query.ListAsync<string>());
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

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijaNaKojimaNeUcestvujeManeken(string mbrManekena)
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
                query.SetParameter("manekenMBR", mbrManekena);
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<bool> ZaposliManekena(string mbrManekena, string pibAgencije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.GetAsync<Maneken>(mbrManekena);
                ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pibAgencije);
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

    public static async Task<bool> DajOtkazManeken(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.LoadAsync<Maneken>(mbr);
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

    public static async Task<bool> DodajRevijuManekenu(string manekenMBR, int? revijaRBR)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.GetAsync<Maneken>(manekenMBR);
                ModnaRevija revija = await session.GetAsync<ModnaRevija>(revijaRBR);
                if (maneken!=null && revija != null)
                {
                    maneken.Revije.Add(revija);
                    await session.UpdateAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri pribavljanju manekena ili revije!");
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

    public static async Task<bool> ObrisiRevijuManekenu(string manekenMBR, int? rbrRevije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.GetAsync<Maneken>(manekenMBR);
                ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbrRevije);
                if (maneken != null && revija != null)
                {
                    maneken.Revije.Remove(revija);
                    await session.UpdateAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                throw new Exception("Greška pri pribavljanju revije ili manekena!");
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
    public static async Task<ModnaRevijaBasic?> VratiModnuReviju(int? rbrRevije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbrRevije);
                return revija != null ? new(revija) : null;
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

    public static async Task<bool> DodajReviju(ModnaRevijaBasic revija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija novaRevija = Helper.NewModnaRevija(revija);
                await session.SaveAsync(novaRevija);
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

    public static async Task<bool> AzurirajReviju(ModnaRevijaBasic updateRevija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(updateRevija.RBR);
                Helper.UpdateRevija(revija, updateRevija);
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

    public static async Task<bool> ObrisiReviju(int? rbrRevije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(rbrRevije);
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
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<IList<ManekenPregled>> VratiManekeneModneRevije(int? rbrRevije)
    {
        ISession? session = null;
        List<ManekenPregled> listaManekena = new List<ManekenPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select m from Maneken m join m.Revije mr where mr.RBR= :rbrRevije";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("rbrRevije", rbrRevije);
                IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                listaManekena.AddRange(manekeni.Select(maneken => new ManekenPregled(maneken)));
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

    public static async Task<IList<ManekenPregled>> VratiManekeneKojeNisuNaModnojReviji(int? rbrRevije)
    {
        ISession session = DataLayer.GetSession();
        List<ManekenPregled> listaManekena = new List<ManekenPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select m from Maneken m where m.MBR not in (select m2.MBR from Maneken m2 join m2.Revije r where r.RBR= :rbrRevije)";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("rbrRevije", rbrRevije);
                IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                listaManekena.AddRange(manekeni.Select(maneken => new ManekenPregled(maneken)));
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

    public static async Task<bool> DodajModnogKreatoraReviji(int rbrRevije, string mbrKreatora)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(rbrRevije);
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(mbrKreatora);
                revija.Kreatori.Add(kreator);
                await session.UpdateAsync(revija);
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

    public static async Task<bool> ObrisiModnogKreatoraReviji(int rbrRevije, string mbrKreatora)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(rbrRevije);
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(mbrKreatora);
                revija.Kreatori.Remove(kreator);
                await session.UpdateAsync(revija);
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

    public static async Task<IList<ModniKreatorPregled>> VratiModneKreatoreModneRevije(int rbrRevije)
    {
        ISession? session = null;
        List<ModniKreatorPregled> listaKreatora = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select m from ModniKreator m join m.Revije mr where mr.RBR= :rbrRevije";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("rbrRevije", rbrRevije);
                IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                listaKreatora.AddRange(kreatori.Select(kreator => new ModniKreatorPregled(kreator)));
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

    public static async Task<IList<ModniKreatorPregled>> VratiModneKreatoreKojiNisuNaModnojReviji(int rbrRevije)
    {
        ISession? session = null;
        List<ModniKreatorPregled> listaKreatora = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select mk from ModniKreator mk where mk.MBR not in (select mk2.MBR from ModniKreator mk2 join mk2.Revije r where r.RBR= :rbrRevije)";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("rbrRevije", rbrRevije);
                IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                listaKreatora.AddRange(kreatori.Select(kreator => new ModniKreatorPregled(kreator)));
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
    #endregion

    #region ModnaAgencija
    public static async Task<ModnaAgencijaBasic?> VratiModnuAgenciju(string pibAgencije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pibAgencije);
                return agencija != null ? new(agencija) : null;
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

    public static async Task<bool> DodajModnuAgenciju(ModnaAgencijaBasic agencija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaAgencija novaAgencija = Helper.NewModnaAgencija(agencija);
                await session.SaveAsync(novaAgencija);
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

    public static async Task<bool> AzurirajModnuAgenciju(ModnaAgencijaBasic updateAgencija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaAgencija agencija = await session.LoadAsync<ModnaAgencija>(updateAgencija.PIB);
                Helper.UpdateAgencija(agencija, updateAgencija);
                await session.UpdateAsync(agencija);
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

    public static async Task<bool> ObrisiModnuAgenciju(string pibAgencije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaAgencija agencija = await session.LoadAsync<ModnaAgencija>(pibAgencije);
                await session.DeleteAsync(agencija);
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

    public static async Task<bool> IsInostrana(string pibAgencije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pibAgencije);
                return agencija is InostranaAgencija;
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
            session.Close();
        }
    }

    public static async Task<IList<ModnaAgencijaPregled>> VratiModneAgencije()
    {
        ISession? session = null;
        List<ModnaAgencijaPregled> listaAgencija = new List<ModnaAgencijaPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNA_AGENCIJA");
                query.AddEntity(typeof(ModnaAgencija));
                IList<ModnaAgencija> agencije = await query.ListAsync<ModnaAgencija>();
                listaAgencija.AddRange(agencije.Select(agencija => new ModnaAgencijaPregled(agencija)));
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

    public static async Task<IList<ManekenPregled>> VratiManekeneModneAgencije(string pibAgencije)
    {
        ISession? session = null;
        List<ManekenPregled> listaManekena = new List<ManekenPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select m from Maneken m join m.RadiUAgenciji r where r.PIB= :agencijaPIB";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("agencijaPIB", pibAgencije);
                IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                listaManekena.AddRange(manekeni.Select(maneken => new ManekenPregled(maneken)));
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
    #endregion

    #region NaziviZemalja
    public static async Task<bool> DodajZemlju(string pibAgencija, string nazivZemlje)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                InostranaAgencija agencija = await session.LoadAsync<InostranaAgencija>(pibAgencija);
                ISQLQuery query = session.CreateSQLQuery($"SELECT * FROM NAZIVI_ZEMALJA WHERE PIB_INOSTRANE={agencija.PIB}");
                query.AddEntity(typeof(NazivZemlje));
                IList<NazivZemlje> naziviZemalja = await query.ListAsync<NazivZemlje>();
                foreach (var zemlja in naziviZemalja)
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

    public static async Task<bool> ObrisiZemlju(string pibAgencije, string nazivZemlje)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                NazivZemlje zemlja = new NazivZemlje()
                {
                    Id = new NazivZemljeId()
                    {
                        InostranaAgencija = await session.LoadAsync<InostranaAgencija>(pibAgencije),
                        NazivZemlje = nazivZemlje
                    }
                };
                await session.DeleteAsync(zemlja);
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

    public static async Task<IList<string>> VratiZemljeUKojimaPoslujeAgencijaPregled(string pibAgencije)
    {
        ISession? session = null;
        List<string> listaZemalja = new List<string>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery($"SELECT NAZIV_ZEMLJE FROM NAZIVI_ZEMALJA WHERE PIB_INOSTRANE={pibAgencije}");
                listaZemalja.AddRange(await query.ListAsync<string>());
                return listaZemalja;
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

    #region NaziviCasopisa
    public static async Task<bool> DodajCasopis(string manekenMBR, string nazivCasopis)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.LoadAsync<Maneken>(manekenMBR);
                foreach(var tmp in maneken.Casopisi)
                {
                    if (tmp.Id.NazivCasopisa == nazivCasopis)
                    {
                        throw new Exception($"Maneken {maneken.Ime.ToString()} je već u časopisu {nazivCasopis}!");
                    }
                }
                Casopis casopis = new Casopis()
                {
                    Id = new CasopisId()
                    {
                        Maneken = maneken,
                        NazivCasopisa = nazivCasopis
                    }
                };
                await session.SaveAsync(casopis);
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

    public static async Task<bool> ObrisiCasopis(string manekenMBR, string nazivCasopisa)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Maneken maneken = await session.LoadAsync<Maneken>(manekenMBR);
                CasopisId id = new CasopisId()
                {
                    Maneken = maneken,
                    NazivCasopisa = nazivCasopisa
                };
                Casopis casopis = await session.LoadAsync<Casopis>(id);
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
    public static async Task<ModniKreatorBasic?> VratiModnogKreatora(string mbrKreatora)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator kreator = await session.GetAsync<ModniKreator>(mbrKreatora);
                return kreator != null ? new(kreator) : null;
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

    public static async Task<bool> DodajModnogKreatora(ModniKreatorBasic kreator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator noviKreator = Helper.NewKreator(kreator);
                await session.SaveAsync(noviKreator);
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

    public static async Task<bool> AzurirajModnogKreatora(ModniKreatorBasic kreatorUpdate)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(kreatorUpdate.MBR);
                Helper.UpdateKreator(kreator, kreatorUpdate);
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

    public static async Task<bool> ObrisiModnogKreatora(string mbrKreatora)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(mbrKreatora);
                await session.DeleteAsync(kreator);
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

    public static async Task<bool> DodajModnuKucuModnomKreatoru(string mbrKreatora, string nazivKuce)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(mbrKreatora);
                ModnaKuca kuca = await session.LoadAsync<ModnaKuca>(nazivKuce);
                kreator.RadiU = kuca;
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

    public static async Task<bool> ObrisiModnuKucuModnomKreatoru(string mbrKreatora, string nazivKuce)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModniKreator kreator = await session.LoadAsync<ModniKreator>(mbrKreatora);
                ModnaKuca kuca = await session.LoadAsync<ModnaKuca>(nazivKuce);
                kreator.RadiU = null;
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

    public static async Task<IList<ModniKreatorPregled>> VratiModneKreatore()
    {
        ISession? session = null;
        List<ModniKreatorPregled> listaKreatora = new List<ModniKreatorPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNI_KREATOR");
                query.AddEntity(typeof(ModniKreator));
                IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                listaKreatora.AddRange(kreatori.Select(kreator => new ModniKreatorPregled(kreator)));
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

    public static async Task<IList<ModniKreatorPregled>> VratiNezaposleneModneKreatore()
    {
        ISession? session = DataLayer.GetSession();
        List<ModniKreatorPregled> listaKreatora = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNI_KREATOR WHERE NAZIV_KUCE IS NULL");
                query.AddEntity(typeof(ModniKreator));
                IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                listaKreatora.AddRange(kreatori.Select(kreator => new ModniKreatorPregled(kreator)));
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

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijeModnogKreatora(string mbrKreatora)
    {
        ISession? session = null;
        List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select r from ModnaRevija r join r.Kreatori k where k.MBR= :kreatorMBR";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("kreatorMBR", mbrKreatora);
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijeNaKojimaNeUcestvujeKreator(string mbrKreatora)
    {
        ISession? session = null;
        List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select mr from ModnaRevija mr where mr.RBR not in (select mr2 from ModnaRevija mr2 join mr2.Kreatori m where m.MBR= :kreatorMBR)";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("kreatorMBR", mbrKreatora);
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijeBezOrganizatora()
    {
        ISession? session = null;
        List<ModnaRevijaPregled> listaRevija = new List<ModnaRevijaPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNA_REVIJA WHERE ORGANIZATOR_ID IS NULL");
                query.AddEntity(typeof(ModnaRevija));
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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

    public static async Task<bool> DodajOrganizatoraModnojReviji(int rbrRevije, int idOrganizatora)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(rbrRevije);
                Organizator organizator = await session.LoadAsync<Organizator>(idOrganizatora);
                revija.Organizator = organizator;
                await session.UpdateAsync(revija);
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

    public static async Task<bool> ObrisiOrganizatoraModnojReviji(int rbrRevije)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaRevija revija = await session.LoadAsync<ModnaRevija>(rbrRevije);
                revija.Organizator = null;
                await session.UpdateAsync(revija);
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

    #region ModnaKuca
    public static async Task<ModnaKucaBasic?> VratiModnuKucu(string naziv)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca modnaKuca = await session.GetAsync<ModnaKuca>(naziv);
                return modnaKuca != null ? new(modnaKuca) : null;
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

    public static async Task<bool> DodajModnuKucu(ModnaKucaBasic kuca)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca modnaKuca = Helper.NewModnaKuca(kuca);
                await session.SaveAsync(modnaKuca);
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

    public static async Task<bool> AzurirajModnuKucu(ModnaKucaBasic kuca)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca modnaKuca = await session.LoadAsync<ModnaKuca>(kuca.Naziv);
                Helper.UpdateModnaKuca(modnaKuca, kuca);
                await session.UpdateAsync(modnaKuca);
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

    public static async Task<bool> ObrisiModnuKucu(string nazivModneKuce)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca modnaKuca = await session.LoadAsync<ModnaKuca>(nazivModneKuce);
                await session.DeleteAsync(modnaKuca);
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

    public static async Task<IList<ModnaKucaPregled>> VratiModneKuce()
    {
        ISession? session = null;
        List<ModnaKucaPregled> listaModnihKuca = new List<ModnaKucaPregled>();
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {

                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MODNA_KUCA");
                query.AddEntity(typeof(ModnaKuca));
                IList<ModnaKuca> modneKuce = await query.ListAsync<ModnaKuca>();
                listaModnihKuca.AddRange(modneKuce.Select(kuca => new ModnaKucaPregled(kuca)));
                return listaModnihKuca;
            }
            throw new Exception("Greška pri povezivanju sa bazom!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return listaModnihKuca;
        }
        finally
        {
            session?.Close();
        }
    }

    public static async Task<IList<ModniKreatorPregled>> VratiModneKreatoreModneKuce(string nazivModneKuce)
    {
        ISession? session = null;
        List<ModniKreatorPregled> listaKreatora = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select mk from ModniKreator mk join mk.RadiU k where k.Naziv= :nazivKuce";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("nazivKuce", nazivModneKuce);
                IList<ModniKreator> kreatori = await query.ListAsync<ModniKreator>();
                listaKreatora.AddRange(kreatori.Select(kreator => new ModniKreatorPregled(kreator)));
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

    #endregion

    #region ImeVlasnika
    public static async Task<bool> DodajImeVlasnika(string modnaKucaNaziv, Ime ime)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca modnaKuca = await session.LoadAsync<ModnaKuca>(modnaKucaNaziv);
                ImeVlasnika imeVlasnika = new()
                {
                    Id = new()
                    {
                        ModnaKuca = modnaKuca,
                        LicnoIme = ime.LicnoIme,
                        Prezime = ime.Prezime
                    }
                };
                await session.SaveAsync(imeVlasnika);
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

    public static async Task<bool> ObrisiImeVlasnika(string modnaKucaNaziv, Ime ime)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ModnaKuca kuca = await session.LoadAsync<ModnaKuca>(modnaKucaNaziv);
                ImeVlasnika vlasnik = new()
                {
                    Id = new()
                    {
                        ModnaKuca = kuca,
                        LicnoIme = ime.LicnoIme,
                        Prezime=ime.Prezime
                    }
                };
                await session.DeleteAsync(vlasnik);
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

    public static async Task<IList<Ime>> VratiImenaVlasnika(string nazivKuce)
    {
        ISession? session = null;
        List<Ime> listaVlasnika = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                IQuery query = session.CreateSQLQuery($"SELECT LICNO_IME AS LicnoIme, PREZIME AS Prezime FROM IMENA_VLASNIKA WHERE NAZIV_KUCE= :nazivKuce")
                                         .SetParameter("nazivKuce", nazivKuce)
                                         .SetResultTransformer(Transformers.AliasToBean(typeof(Ime)));
                var lista = await query.ListAsync();
                foreach(Ime ime in lista)
                {
                    listaVlasnika.Add(ime);
                }
                return listaVlasnika;
            }
            throw new Exception("Greška pri povezivanju sa bazom!");
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message);
            return listaVlasnika;
        }
        finally
        {
            session?.Close();
        }
    }
    #endregion

    #region Organizator
    public static async Task<OrganizatorBasic?> VratiOrganizatora(int id)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Organizator organizator = await session.GetAsync<Organizator>(id);
                return organizator != null ? new(organizator) : null;
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

    public static async Task<bool> DodajOrganizatora(OrganizatorBasic organizator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Organizator newOrganizator = Helper.NewOrganizator(organizator);
                await session.SaveAsync(newOrganizator);
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

    public static async Task<bool> AzurirajOrganizatora(OrganizatorBasic updateOrganizator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Organizator organizator = await session.LoadAsync<Organizator>(updateOrganizator.Id);
                Helper.UpdateOrganizator(organizator, updateOrganizator);
                await session.UpdateAsync(organizator);
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
    
    public static async Task<bool> ObrisiOrganizatora(int id)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                Organizator organizator = await session.LoadAsync<Organizator>(id);
                await session.DeleteAsync(organizator);
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

    public static async Task<IList<OrganizatorPregled>> VratiOrganizatore()
    {
        ISession? session = null;
        List<OrganizatorPregled> listaOrganizatora = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                ISQLQuery query = session.CreateSQLQuery("SELECT * FROM ORGANIZATOR");
                query.AddEntity(typeof(Organizator));
                var organizatori = await query.ListAsync<Organizator>();
                listaOrganizatora.AddRange(organizatori.Select(organizator => new OrganizatorPregled(organizator)));
                return listaOrganizatora;
            }
            throw new Exception("Greška pri povezivanju sa bazom!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return listaOrganizatora;
        }
        finally
        {
            session?.Close();
        }
    }

    public static async Task<IList<ModnaRevijaPregled>> VratiModneRevijeOrganizatora(int id)
    {
        ISession? session = null;
        List<ModnaRevijaPregled> listaRevija = [];
        try
        {
            session = DataLayer.GetSession();
            if (session != null)
            {
                string strQuery = "select r from ModnaRevija r join r.Organizator o where o.Id= :organizatorId";
                IQuery query = session.CreateQuery(strQuery);
                query.SetParameter("organizatorId", id);
                IList<ModnaRevija> revije = await query.ListAsync<ModnaRevija>();
                listaRevija.AddRange(revije.Select(revija => new ModnaRevijaPregled(revija)));
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
    #endregion

    #region SpecijalanGost
    #endregion
}