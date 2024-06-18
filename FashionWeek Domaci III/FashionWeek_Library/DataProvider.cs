using FashionWeek_Library.DTO.Basic;

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
            if(maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} ne postoji!".ToError(404);
            }
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

    public static async Task<Result<List<ManekenView>, ErrorMessage>> VratiManekeneModneRevije(int rbr)
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
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if(revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} ne postoji!".ToError(404);
            }
            return revija.Manekeni.Select(x => new ManekenView(x)).ToList();
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o manekenima sa modne revije sa rednim brojem {rbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajManekena(ManekenBasic maneken)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            if (maneken.MBR.Length != 13)
            {
                return "MBR mora biti dužine 13!".ToError(400);
            }
            if (string.IsNullOrEmpty(maneken.Ime.LicnoIme) || string.IsNullOrEmpty(maneken.Ime.Prezime))
            {
                return "Morate da unesete ime i prezime!".ToError(400);
            }
            if (maneken.Pol is not 'M' or 'Z')
            {
                return "Morate izabrati odgovarajući pol!".ToError(400);
            }
            if (maneken.KonfekcijskiBroj.Length > 4)
            {
                return "Konfekcijski broj može najviše biti dužien 4!".ToError(400);
            }

            Maneken tmpManeken = await session.GetAsync<Maneken>(maneken.MBR);
            ModniKreator tmpKreator = await session.GetAsync<ModniKreator>(maneken.MBR);
            if(tmpManeken is not null || tmpKreator is not null)
            {
                return $"MBR {maneken.MBR} se već nalazi u bazi!".ToError(405);
            }

            Maneken newManeken = new Maneken()
            {
                MBR = maneken.MBR,
                Ime = new(maneken.Ime),
                DatumRodjenja = maneken.DatumRodjenja,
                Pol = maneken.Pol,
                Visina = maneken.Visina,
                Tezina = maneken.Tezina,
                BojaKose = maneken.BojaKose,
                BojaOciju = maneken.BojaOciju,
                KonfekcijskiBroj = maneken.KonfekcijskiBroj,
                Zanimanje = maneken.Zanimanje,
            };

            await session.SaveAsync(newManeken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju manekena!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> AzurirajManekena(ManekenBasic maneken)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            if (maneken.MBR.Length != 13)
            {
                return "MBR mora biti dužine 13!".ToError(400);
            }
            Maneken orgManeken = await session.GetAsync<Maneken>(maneken.MBR);
            if(orgManeken is null)
            {
                return $"Maneken sa MBR-om nije pronađen {maneken.MBR}!".ToError(404);
            }
            if (string.IsNullOrEmpty(maneken.Ime.LicnoIme) || string.IsNullOrEmpty(maneken.Ime.Prezime))
            {
                return "Morate da unesete ime i prezime!".ToError(400);
            }
            if (maneken.Pol is not 'M' or 'Z')
            {
                return "Morate izabrati odgovarajući pol!".ToError(400);
            }
            if (maneken.KonfekcijskiBroj.Length > 4)
            {
                return "Konfekcijski broj može najviše biti dužine 4!".ToError(400);
            }

            orgManeken.Ime = new(maneken.Ime);
            orgManeken.DatumRodjenja = maneken.DatumRodjenja;
            orgManeken.Pol = maneken.Pol;
            orgManeken.Visina = maneken.Visina;
            orgManeken.Tezina = maneken.Tezina;
            orgManeken.BojaKose = maneken.BojaKose;
            orgManeken.BojaOciju = maneken.BojaOciju;
            orgManeken.KonfekcijskiBroj = maneken.KonfekcijskiBroj;
            orgManeken.Zanimanje = maneken.Zanimanje;

            await session.UpdateAsync(orgManeken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri ažuriranju manekena!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnuAgencijuManekenu(string mbr, string pib)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            if (maneken.RadiUAgenciji is not null)
            {
                return $"Maneken {mbr}: {maneken.Ime.ToString()} je već zapošljen!".ToError(400);
            }
            ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
            if (agencija is null)
            {
                return $"Agencija sa PIB-om {pib} nije pronadjena!".ToError(400);
            }
            maneken.RadiUAgenciji = agencija;
            await session.UpdateAsync(maneken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju agencija sa PIB-om {pib} manekenu sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuAgencijuManekenu(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            if (maneken.RadiUAgenciji is null)
            {
                return $"Maneken {mbr}: {maneken.Ime.ToString()} je već bez agencije!".ToError(400);
            }
            maneken.RadiUAgenciji = null;
            await session.UpdateAsync(maneken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju agencije manekenu sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnuRevijuManekenu(string mbr, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} nije pronadjena!".ToError(400);
            }
            if (maneken.Revije.Contains(revija))
            {
                return $"Maneken sa MBR-om {mbr} je već na reviji sa rednim brojem {rbr}!".ToError(400);
            }
            maneken.Revije.Add(revija);
            await session.UpdateAsync(maneken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju modne revija sa rednim brojem {rbr} manekenu sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuRevijuManekenu(string mbr, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} nije pronadjena!".ToError(400);
            }
            if (!maneken.Revije.Contains(revija))
            {
                return $"Maneken sa MBR-om {mbr} nije na reviji sa rednim brojem {rbr}!".ToError(400);
            }
            maneken.Revije.Remove(revija);
            await session.UpdateAsync(maneken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne revija sa rednim brojem {rbr} manekenu sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiManekena(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if(maneken is null)
            {
                return $"Maneken sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            await session.DeleteAsync(maneken);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju manekena sa MBR-om {mbr}!".ToError(400);
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
            if(kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} ne postoji!".ToError(404);
            }
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

    public static async Task<Result<List<ModniKreatorView>, ErrorMessage>> VratiModneKreatoreModneRevije(int rbr)
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
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if(revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} ne postoji!".ToError(404);
            }
            return revija.Kreatori.Select(x => new ModniKreatorView(x)).ToList();
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanu informacija o modnim kreatorima koji učestvuju na modnoj reviji sa rednim brojem {rbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnogKreatora(ModniKreatorBasic kreator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            if (kreator.MBR.Length != 13)
            {
                return "MBR mora biti dužine 13!".ToError(400);
            }
            if (string.IsNullOrEmpty(kreator.Ime.LicnoIme) || string.IsNullOrEmpty(kreator.Ime.Prezime))
            {
                return "Morate da unesete ime i prezime!".ToError(400);
            }
            if (kreator.Pol is not 'M' or 'Z')
            {
                return "Morate izabrati odgovarajući pol!".ToError(400);
            }

            Maneken tmpManeken = await session.GetAsync<Maneken>(kreator.MBR);
            ModniKreator tmpKreator = await session.GetAsync<ModniKreator>(kreator.MBR);
            if (tmpManeken is not null || tmpKreator is not null)
            {
                return $"MBR {kreator.MBR} se već nalazi u bazi!".ToError(405);
            }

            ModniKreator newKreator = new ModniKreator()
            {
                MBR = kreator.MBR,
                Ime = new(kreator.Ime),
                DatumRodjenja = kreator.DatumRodjenja,
                Pol = kreator.Pol,
                ZemljaPorekla = kreator.ZemljaPorekla
            };

            await session.SaveAsync(newKreator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju modnog kreatora!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> AzurirajModnogKreatora(ModniKreatorBasic kreator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            if (kreator.MBR.Length != 13)
            {
                return "MBR mora biti dužine 13!".ToError(400);
            }
            ModniKreator orgKreator = await session.GetAsync<ModniKreator>(kreator.MBR);
            if(orgKreator is null)
            {
                return $"Modni kreator sa MBR-om {kreator.MBR} nije pronadjen!".ToError(404);
            }
            if (string.IsNullOrEmpty(kreator.Ime.LicnoIme) || string.IsNullOrEmpty(kreator.Ime.Prezime))
            {
                return "Morate da unesete ime i prezime!".ToError(400);
            }
            if (kreator.Pol is not 'M' or 'Z')
            {
                return "Morate izabrati odgovarajući pol!".ToError(400);
            }

            orgKreator.Ime = new(kreator.Ime);
            orgKreator.DatumRodjenja = kreator.DatumRodjenja;
            orgKreator.Pol = kreator.Pol;
            orgKreator.ZemljaPorekla = kreator.ZemljaPorekla;

            await session.UpdateAsync(orgKreator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri ažuriranju modnog kreatora!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnuKucuModnomKreatoru(string mbr, string naziv)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
            if (kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            if(kreator.RadiU is not null)
            {
                return $"Modni kreator {mbr}: {kreator.Ime.ToString()} je već zapošljen!".ToError(400);
            }
            ModnaKuca kuca = await session.GetAsync<ModnaKuca>(naziv);
            if (kuca is null)
            {
                return $"Modna kuća sa nazivom {naziv} ne postoji!".ToError(404);
            }
            kreator.RadiU = kuca;
            await session.UpdateAsync(kreator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju modne kuće sa nazivom {naziv} modnom kreatoru sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuKucuModnomKreatoru(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
            if (kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            if (kreator.RadiU is null)
            {
                return $"Modni kreator {mbr}: {kreator.Ime.ToString()} je već bez modne kuće!".ToError(400);
            }
            kreator.RadiU = null;
            await session.UpdateAsync(kreator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne kuće modnom kreatoru sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnuRevijuModnomKreatoru(string mbr, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
            if (kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} ne postoji!".ToError(404);
            }
            if (kreator.Revije.Contains(revija))
            {
                return $"Modni kreator sa MBR-om {mbr} je već na modnoj reviji sa rednim brojem {rbr}!".ToError(400);
            }
            revija.Kreatori.Add(kreator);
            await session.UpdateAsync(revija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju modne revija sa rednim brojem {rbr} modnom kreatoru sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuRevijuModnomKreatoru(string mbr, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
            if (kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} ne postoji!".ToError(404);
            }
            if (!kreator.Revije.Contains(revija))
            {
                return $"Modni kreator sa MBR-om {mbr} nije na modnoj reviji sa rednim brojem {rbr}!".ToError(400);
            }
            revija.Kreatori.Remove(kreator);
            await session.UpdateAsync(revija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne revija sa rednim brojem {rbr} modnom kreatoru sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnogKreatora(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModniKreator kreator = await session.GetAsync<ModniKreator>(mbr);
            if (kreator is null)
            {
                return $"Modni kreator sa MBR-om {mbr} nije pronadjen!".ToError(404);
            }
            await session.DeleteAsync(kreator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modnog kreatora sa MBR-om {mbr}!".ToError(400);
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
            if(kuca is null)
            {
                return $"Modna kuća {naziv} ne postoji!".ToError(404);
            }
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

    public static async Task<Result<bool, ErrorMessage>> DodajModnuKucu(ModnaKucaBasic kuca)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaKuca tmpModnaKuca = await session.GetAsync<ModnaKuca>(kuca.Naziv);
            if (tmpModnaKuca is not null)
            {
                return $"Modna kuća sa nazivom {kuca.Naziv} već postoji!".ToError(405);
            }

            ModnaKuca newKuca = new ModnaKuca
            {
                Naziv = kuca.Naziv,
                Osnivac = kuca.Osnivac,
                Sediste = kuca.Sediste
            };

            await session.SaveAsync(newKuca);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju modne kuće!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> AzurirajModnuKucu(ModnaKucaBasic kuca)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaKuca orgKuca = await session.GetAsync<ModnaKuca>(kuca.Naziv);
            if (orgKuca is null)
            {
                return $"Modna kuća sa nazivom {kuca.Naziv} ne postoji!".ToError(405);
            }

            orgKuca.Osnivac = kuca.Osnivac;
            orgKuca.Sediste = kuca.Sediste;

            await session.UpdateAsync(orgKuca);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri ažuriranju modne kuće!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuKucu(string naziv)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaKuca modnaKuca = await session.GetAsync<ModnaKuca>(naziv);
            if (modnaKuca is null)
            {
                return $"Modna kuća sa nazivom {naziv} nije pronadjena!".ToError(404);
            }
            await session.DeleteAsync(modnaKuca);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne kuće sa nazivom {naziv}!".ToError(400);
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
            if(revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} ne postoji!".ToError(404);
            }
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

    public static async Task<Result<List<ModnaRevijaView>, ErrorMessage>> VratiModneRevijeManekena(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken == null)
            {
                return $"Maneken sa MBR-om ne postoji {mbr}!"!.ToError(404);
            }
            return maneken.Revije.Select(x => new ModnaRevijaView(x)).ToList();
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnim revijama manekena sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<List<ModnaRevijaView>, ErrorMessage>> VratiModneRevijeModnogKreatora(string mbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModniKreator modniKreator = await session.GetAsync<ModniKreator>(mbr);
            if (modniKreator == null)
            {
                return $"Modni kreator sa MBR-om ne postoji {mbr}!"!.ToError(404);
            }
            return modniKreator.Revije.Select(x => new ModnaRevijaView(x)).ToList();
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnim revijama modnog kreatora sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<List<ModnaRevijaView>, ErrorMessage>> VratiModneRevijeOrganizatora(int id)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Organizator organizator = await session.GetAsync<Organizator>(id);
            if(organizator is null)
            {
                return $"Organizator sa ID-em {id} nije pronađen!".ToError(404);
            }
            return organizator.ModneRevije.Select(x => new ModnaRevijaView(x)).ToList();
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o modnim revijama organizatora sa ID-em {id}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    public static async Task<Result<bool, ErrorMessage>> DodajModnuReviju(ModnaRevijaBasic revija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaRevija newRevija = new ModnaRevija
            {
                Naziv = revija.Naziv,
                Mesto = revija.Mesto,
                Termin = revija.Termin
            };

            await session.SaveAsync(newRevija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju modne revije!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> AzurirajModnuReviju(ModnaRevijaBasic revija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaRevija orgRevija = await session.GetAsync<ModnaRevija>(revija.RBR);
            if(orgRevija is null)
            {
                return $"Modna revija sa rednim brojem {revija.RBR} nije pronađena!".ToError(404);
            }
            orgRevija.Naziv = revija.Naziv;
            orgRevija.Mesto = revija.Mesto;
            orgRevija.Termin = revija.Termin;

            await session.UpdateAsync(orgRevija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri ažuriranju modne revije!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuReviju(int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} nije pronadjena!".ToError(404);
            }
            await session.DeleteAsync(revija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne revije sa rednim brojem {rbr}!".ToError(400);
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
            if(agencija is null)
            {
                return $"Modna agencija sa PIB-om {pib} ne postoji!".ToError(404);
            }
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

    public static async Task<Result<bool, ErrorMessage>> DodajModnuAgenciju(ModnaAgencijaBasic agencija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            if (agencija.PIB.Length != 8)
            {
                return "PIB mora imati 8 cifara!".ToError(400);
            }
            if(agencija.Inostrana != 'Y' && agencija.Inostrana !='N')
            {
                return "Morate izabrati YES ili NO za inostranu agenciju!".ToError(400);
            }

            ModnaAgencija tmpAgencija = await session.GetAsync<ModnaAgencija>(agencija.PIB);
            if(tmpAgencija is not null)
            {
                return $"Modna agencija sa PIB-om {agencija.PIB} već postoji!".ToError(405);
            }

            ModnaAgencija newAgencija;
            if (agencija.Inostrana == 'Y')
            {
                newAgencija = new InostranaAgencija()
                {
                    PIB = agencija.PIB,
                    Naziv = agencija.Naziv,
                    Inostrana = agencija.Inostrana,
                    Sediste = agencija.Sediste,
                    DatumOsnivanja = agencija.DatumOsnivanja
                };
            }
            else
            {
                newAgencija = new DomacaAgencija()
                {
                    PIB = agencija.PIB,
                    Naziv = agencija.Naziv,
                    Inostrana = agencija.Inostrana,
                    Sediste = agencija.Sediste,
                    DatumOsnivanja = agencija.DatumOsnivanja
                };
            }

            await session.SaveAsync(newAgencija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju modne agencije!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> AzurirajModnuAgenciju(ModnaAgencijaBasic agencija)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaAgencija orgAgencija = await session.GetAsync<ModnaAgencija>(agencija.PIB);
            if (orgAgencija is null)
            {
                return $"Modna agencija sa PIB-om {agencija.PIB} nije pronađena!".ToError(405);
            }
            orgAgencija.Naziv = agencija.Naziv;
            orgAgencija.Sediste = agencija.Sediste;
            orgAgencija.DatumOsnivanja = agencija.DatumOsnivanja;

            await session.UpdateAsync(orgAgencija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri ažuriranju modne agencije!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuAgenciju(string pib)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
            if (agencija is null)
            {
                return $"Modna agenciju sa PIB-om {pib} nije pronadjena!".ToError(404);
            }
            await session.DeleteAsync(agencija);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne agencije sa PIB-om {pib}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region Organizator
    public static async Task<Result<List<OrganizatorView>, ErrorMessage>> VratiSveOrganizatore()
    {
        List<OrganizatorView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<Organizator>().ListAsync())
                            .Select(organizator => new OrganizatorView(organizator)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o organizatorima!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<OrganizatorView, ErrorMessage>> VratiOrganizatora(int id)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Organizator organizator = await session.QueryOver<Organizator>().Where(x => x.Id == id).SingleOrDefaultAsync();
            if (organizator is null)
            {
                return $"Organizator sa ID-em {id} ne postoji!".ToError(404);
            }
            return new OrganizatorView(organizator);
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o organizatoru sa ID-oem {id}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajOrganizatora(OrganizatorView organizator)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            
            if(organizator.PrvaRevija!='Y' && organizator.PrvaRevija != 'N')
            {
                return "Mora se izabrati da li je prva revija YES ili NO!".ToError(400);
            }
            Organizator newOrganizator = new Organizator
            {
                PrvaRevija = organizator.PrvaRevija,
                InformacijeOKolekciji = organizator.InformacijeOKolekciji
            };
            await session.SaveAsync(newOrganizator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju organizatora!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajModnuRevijuOrganizatoru(int id, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Organizator organizator = await session.GetAsync<Organizator>(id);
            if (organizator is null)
            {
                return $"Organizator sa ID-em {id} nije pronađen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} nije pronađena!".ToError(404);
            }
            if (revija.Organizator != null)
            {
                return $"Modna revija sa rednim brojem {rbr} već ima organizatora!".ToError(404);
            }
            organizator.ModneRevije.Add(revija);
            await session.UpdateAsync(organizator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri dodavanju modne revije sa rednim brojem {rbr} organizatoru sa ID-em {id}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiModnuRevijuOrganizatoru(int id, int rbr)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            Organizator organizator = await session.GetAsync<Organizator>(id);
            if (organizator is null)
            {
                return $"Organizator sa ID-em {id} nije pronađen!".ToError(404);
            }
            ModnaRevija revija = await session.GetAsync<ModnaRevija>(rbr);
            if (revija is null)
            {
                return $"Modna revija sa rednim brojem {rbr} nije pronađena!".ToError(404);
            }
            if (!organizator.ModneRevije.Contains(revija))
            {
                return $"Organizator sa ID-em {id} nije organizator revije sa rednim brojem {rbr}!".ToError(400);
            }
            organizator.ModneRevije.Remove(revija);
            await session.UpdateAsync(organizator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju modne revije sa rednim brojem {rbr} organizatoru sa ID-em {id}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiOrganizatora(int id)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Organizator organizator = await session.GetAsync<Organizator>(id);
            if(organizator is null)
            {
                return $"Orgnizator sa ID-em {id} nije pronađen!".ToError(404);
            }
            await session.DeleteAsync(organizator);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju organizatora!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region Casopis
    public static async Task<Result<List<CasopisView>, ErrorMessage>> VratiSveCasopise()
    {
        List<CasopisView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<Casopis>().ListAsync())
                            .Select(x => new CasopisView(x)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o časopisima!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();

        }
    }

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

    public static async Task<Result<bool, ErrorMessage>> DodajCasopis(string mbr, string nazivCasopisa)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if(maneken is null)
            {
                return $"Ne postoji maneken sa MBR-om {mbr}!".ToError(404);
            }
            CasopisId id = new CasopisId()
            {
                Maneken = maneken,
                NazivCasopisa = nazivCasopisa
            };
            Casopis tmpCasopis = await session.GetAsync<Casopis>(id);
            if(tmpCasopis is not null)
            {
                return $"Maneken {maneken.MBR}: {maneken.Ime.ToString()} već se pojavljuje u časopisu {nazivCasopisa}!".ToError(400);
            }
            Casopis casopis = new Casopis()
            {
                Id = id
            };

            await session.SaveAsync(casopis);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju časopisa!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiCasopis(string mbr, string nazivCasopisa)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            Maneken maneken = await session.GetAsync<Maneken>(mbr);
            if (maneken is null)
            {
                return $"Ne postoji maneken sa MBR-om {mbr}!".ToError(404);
            }
            CasopisId id = new CasopisId()
            {
                Maneken = maneken,
                NazivCasopisa = nazivCasopisa
            };
            Casopis casopis = await session.GetAsync<Casopis>(id);
            if (!maneken.Casopisi.Contains(casopis))
            {
                return $"Maneken {maneken.Ime.ToString()} ne učestvuje u časopisu sa nazivom {nazivCasopisa}!".ToError(404);
            }
            maneken.Casopisi.Remove(casopis);
            await session.UpdateAsync(maneken);
            await session.DeleteAsync(casopis);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju časopisa sa nazivom {nazivCasopisa} kod maneken sa MBR-om {mbr}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region ImeVlasnika
    public static async Task<Result<List<ImeVlasnikaView>, ErrorMessage>> VratiImenaVlasnika()
    {
        List<ImeVlasnikaView> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            data = (await session.QueryOver<ImeVlasnika>().ListAsync())
                            .Select(x => new ImeVlasnikaView(x)).ToList();
            return data;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri prikupljanu informacija o imenima vlasnika!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
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

    public static async Task<Result<bool, ErrorMessage>> DodajImeVlasnika(string naziv, Ime ime)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaKuca kuca = await session.GetAsync<ModnaKuca>(naziv);
            if (kuca is null)
            {
                return $"Ne postoji modna kuća sa nazivom {naziv}!".ToError(404);
            }
            foreach (var el in kuca.Vlasnici)
            {
                if (el.Id.LicnoIme == ime.LicnoIme && el.Id.Prezime == ime.Prezime)
                {
                    return $"Modna kuća {naziv} već poseduje vlasnika sa imenom {ime.ToString()}!".ToError(400);
                }
            }
            ImeVlasnika vlasnik = new ImeVlasnika()
            {
                Id = new ImeVlasnikaId()
                {
                    ModnaKuca = kuca,
                    LicnoIme = ime.LicnoIme,
                    Prezime = ime.Prezime
                }
            };
            await session.SaveAsync(vlasnik);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju vlasnika modnoj kući!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiImeVlasnika(string naziv, Ime ime)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaKuca kuca = await session.GetAsync<ModnaKuca>(naziv);
            if (kuca is null)
            {
                return $"Ne postoji modna kuća sa nazivom {naziv}!".ToError(404);
            }
            bool check = false;
            foreach (var el in kuca.Vlasnici)
            {
                if (el.Id.LicnoIme == ime.LicnoIme && el.Id.Prezime == ime.Prezime)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return $"Modna kuća {naziv} nema vlasnika {ime.ToString()}!".ToError(404);
            }
            ImeVlasnikaId id = new ImeVlasnikaId()
            {
                ModnaKuca = kuca,
                LicnoIme = ime.LicnoIme,
                Prezime = ime.Prezime,
            };
            ImeVlasnika vlasnik = await session.LoadAsync<ImeVlasnika>(id);
            kuca.Vlasnici.Remove(vlasnik);
            await session.UpdateAsync(kuca);
            await session.DeleteAsync(vlasnik);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri brisanju vlasnika {ime.ToString()} kod modne kuće sa nazivom {naziv}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion

    #region NazivZemlje
    public static async Task<Result<List<string>, ErrorMessage>> VratiNaziveZemaljaInostraneAgencije(string pib)
    {
        List<string> data = new();
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }
            ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
            if(agencija is null)
            {
                return $"Modna agencija sa PIB-om ne postoji {pib}!"!.ToError(404);
            }
            if (agencija is not InostranaAgencija)
            {
                return $"PIB {pib} je vezan za domaću agenciju!".ToError(405);
            }
            data = (await session.QueryOver<NazivZemlje>().ListAsync())
                                        .Where(x => x.Id.InostranaAgencija.PIB == pib)
                                        .Select(x => x.Id.NazivZemlje).ToList()!;
            return data;
        }
        catch (Exception)
        {
            return $"Došlo je do greške pri prikupljanju informacija o zemljama u kojima posluje modna agencija sa PIB-om {pib}!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> DodajZemlju(string pib, string nazivZemlje)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
            if (agencija is null)
            {
                return $"Ne postoji modna agencija sa PIB-om {pib}!".ToError(404);
            }
            if(agencija is not InostranaAgencija)
            {
                return "Agencija nije inostrana!".ToError(400);
            }
            NazivZemljeId id = new NazivZemljeId()
            {
                InostranaAgencija = agencija as InostranaAgencija,
                NazivZemlje = nazivZemlje
            };
            NazivZemlje tmpZemlja = await session.GetAsync<NazivZemlje>(id);
            if (tmpZemlja is not null)
            {
                return $"Agencija {agencija.PIB}: {agencija.Naziv} već posluje u {nazivZemlje}!".ToError(400);
            }
            NazivZemlje zemlja = new NazivZemlje()
            {
                Id = id
            };

            await session.SaveAsync(zemlja);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri dodavanju zemlje!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }

    public static async Task<Result<bool, ErrorMessage>> ObrisiZemlju(string pib, string nazivZemlje)
    {
        ISession? session = null;
        try
        {
            session = DataLayer.GetSession();
            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju!".ToError(403);
            }

            ModnaAgencija agencija = await session.GetAsync<ModnaAgencija>(pib);
            if (agencija is null)
            {
                return $"Ne postoji modna agencija sa PIB-om {pib}!".ToError(404);
            }
            if (agencija is not InostranaAgencija)
            {
                return "Agencija nije inostrana!".ToError(400);
            }
            InostranaAgencija inostrana = await session.GetAsync<InostranaAgencija>(pib);
            NazivZemljeId id = new NazivZemljeId()
            {
                InostranaAgencija = inostrana,
                NazivZemlje = nazivZemlje
            };
            NazivZemlje zemlja = await session.GetAsync<NazivZemlje>(id);
            if (zemlja is  null)
            {
                return $"Agencija {agencija.PIB}: {agencija.Naziv} ne posluje u {nazivZemlje}!".ToError(400);
            }
            inostrana.Zemlje.Remove(zemlja);
            await session.UpdateAsync(inostrana);
            await session.DeleteAsync(zemlja);
            await session.FlushAsync();
            return true;
        }
        catch (Exception)
        {
            return "Došlo je do greške pri brisanju zemlje!".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
    }
    #endregion
}