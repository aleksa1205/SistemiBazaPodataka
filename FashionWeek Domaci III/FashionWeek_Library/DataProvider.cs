namespace FashionWeek_Library;

public static class DataProvider
{
    #region Maneken
    public static async Task<Result<List<ManekenView>, ErrorMessage>> VratiSveManekene()
    {
        List<ManekenView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<Maneken>().ListAsync())
                            .Select(maneken => new ManekenView(maneken)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o mankenima!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<ManekenView, ErrorMessage>> VratiManekena(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Maneken maneken = await session.QueryOver<Maneken>().Where(x => x.MBR == mbr).SingleOrDefaultAsync();
            return new ManekenView(maneken);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o manekenu sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<List<ManekenView>, ErrorMessage>> VratiManekeneModneAgencije(string pib)
    {
        List<ManekenView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if(!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<Maneken>().ListAsync())
                                .Where(x => x.RadiUAgenciji?.PIB == pib)
                                .Select(x => new ManekenView(x)).ToList();
            return data;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o manekenima modne agencije sa PIB-om {pib}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ModniKreator
    public static async Task<Result<List<ModniKreatorView>, ErrorMessage>> VratiSveModneKreatore()
    {
        List<ModniKreatorView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ModniKreator>().ListAsync())
                            .Select(kreator => new ModniKreatorView(kreator)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o modnim kreatorima!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<ModniKreatorView, ErrorMessage>> VratiModnogKreatora(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModniKreator kreator = await session.QueryOver<ModniKreator>().Where(kreator => kreator.MBR == mbr).SingleOrDefaultAsync();
            return new ModniKreatorView(kreator);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnom kreatoru sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<List<ModniKreatorView>, ErrorMessage>> VratiModneKreatoreModneKuce(string naziv)
    {
        List<ModniKreatorView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ModniKreator>().ListAsync())
                            .Where(x => x.RadiU?.Naziv == naziv)
                            .Select(kreator => new ModniKreatorView(kreator)).ToList();
            return data;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanu informacija o modnim kreatorima modne kuće {naziv}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ModnaKuca
    public static async Task<Result<List<ModnaKucaView>, ErrorMessage>> VratiSveModneKuce()
    {
        List<ModnaKucaView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ModnaKuca>().ListAsync())
                            .Select(kuca => new ModnaKucaView(kuca)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o modnim kucama!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<ModnaKucaView, ErrorMessage>> VratiModnuKucu(string naziv)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModnaKuca kuca = await session.QueryOver<ModnaKuca>().Where(kuca => kuca.Naziv == naziv).SingleOrDefaultAsync();
            return new ModnaKucaView(kuca);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnoj kući sa nazivom {naziv}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ModnaRevija
    public static async Task<Result<List<ModnaRevijaView>, ErrorMessage>> VratiSveModneRevije()
    {
        List<ModnaRevijaView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ModnaRevija>().ListAsync())
                            .Select(revija => new ModnaRevijaView(revija)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o modnim revijama!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<ModnaRevijaView, ErrorMessage>> VratiModnuReviju(int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModnaRevija revija = await session.QueryOver<ModnaRevija>().Where(revija => revija.RBR == rbr).SingleOrDefaultAsync();
            return new ModnaRevijaView(revija);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnoj reviji sa rednim brojem {rbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ModnaAgencija
    public static async Task<Result<List<ModnaAgencijaView>, ErrorMessage>> VratiSveModneAgencije()
    {
        List<ModnaAgencijaView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ModnaAgencija>().ListAsync())
                            .Select(agencija => new ModnaAgencijaView(agencija)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o modnim agencijama!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<ModnaAgencijaView, ErrorMessage>> VratiModnuAgenciju(string pib)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModnaAgencija agencija = await session.QueryOver<ModnaAgencija>().Where(x => x.PIB == pib).SingleOrDefaultAsync();
            return new ModnaAgencijaView(agencija);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnoj agenciji sa PIB-om {pib}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region Casopis
    public static async Task<Result<List<string>,ErrorMessage>> VratiCasopiseManekena(string mbr)
    {
        List<string> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if(!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<Casopis>().ListAsync())
                                .Where(x => x.Id.Maneken.MBR == mbr)
                                .Select(x => x.Id.NazivCasopisa).ToList()!;
            return data;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o casopisima u kojima se pojavljuje maneken sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ImeVlasnika
    public static async Task<Result<List<Ime>, ErrorMessage>> VratiImenaVlasnikaModneKuce(string naziv)
    {
        List<Ime> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ImeVlasnika>().ListAsync())
                                        .Where(x => x.Id.ModnaKuca.Naziv == naziv)
                                        .Select(x => new Ime(x.Id.LicnoIme, x.Id.Prezime)).ToList();
            return data;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o vlasnicima modne kuće {naziv}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion
}