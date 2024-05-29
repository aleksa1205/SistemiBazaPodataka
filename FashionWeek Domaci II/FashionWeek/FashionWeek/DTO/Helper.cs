namespace FashionWeek.DTO;

public static class Helper
{
    #region Maneken
    public static Maneken NewManeken(ManekenBasic maneken)
    {
        Maneken newManeken = new Maneken()
        {
            MBR = maneken.MBR,
            Ime = maneken.Ime,
            DatumRodjenja = maneken.DatumRodjenja,
            Pol = maneken.Pol,
            Visina = maneken.Visina,
            Tezina = maneken.Tezina,
            BojaOciju = maneken.BojaOciju,
            BojaKose = maneken.BojaKose,
            KonfekcijskiBroj = maneken.KonfekcijskiBroj,
            Zanimanje = maneken.Zanimanje
        };
        return newManeken;
    }
    public static void UpdateManeken(Maneken maneken, ManekenBasic updateManeken)
    {
        maneken.Ime = updateManeken.Ime;
        maneken.DatumRodjenja = updateManeken.DatumRodjenja;
        maneken.Pol = updateManeken.Pol;
        maneken.Zanimanje = updateManeken.Zanimanje;
        maneken.Visina = updateManeken.Visina;
        maneken.Tezina = updateManeken.Tezina;
        maneken.BojaOciju = updateManeken.BojaOciju;
        maneken.BojaKose = updateManeken.BojaKose;
        maneken.KonfekcijskiBroj = updateManeken.KonfekcijskiBroj;
        maneken.Zanimanje = updateManeken.KonfekcijskiBroj;
    }
    #endregion

    #region ModnaRevija
    public static ModnaRevija NewModnaRevija(ModnaRevijaBasic revija)
    {
        ModnaRevija newRevija = new ModnaRevija()
        {
            Naziv = revija.Naziv!,
            Mesto = revija.Mesto,
            Termin = revija.Termin
        };
        return newRevija;
    }
    public static void UpdateRevija(ModnaRevija revija, ModnaRevijaBasic updateRevija)
    {
        revija.Naziv = updateRevija.Naziv!;
        revija.Mesto = updateRevija.Mesto;
        revija.Termin = updateRevija.Termin;
    }
    #endregion

    #region ModnaAgencije
    public static ModnaAgencija NewModnaAgencija(ModnaAgencijaBasic agencija)
    {
        ModnaAgencija newAgencija = null!;
        if (agencija.Inostrana == 'Y')
        {
            newAgencija = new InostranaAgencija()
            {
                PIB = agencija.PIB,
                Naziv = agencija.Naziv,
                Inostrana = 'Y',
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
                Inostrana = 'N',
                Sediste = agencija.Sediste,
                DatumOsnivanja = agencija.DatumOsnivanja
            };
        }
        return newAgencija;
    }
    public static void UpdateAgencija(ModnaAgencija agencija, ModnaAgencijaBasic updateAgencija)
    {
        agencija.Naziv = updateAgencija.Naziv!;
        agencija.Sediste = updateAgencija.Sediste;
        agencija.DatumOsnivanja = updateAgencija.DatumOsnivanja;
    }
    #endregion

    #region ModniKreator
    public static ModniKreator NewKreator(ModniKreatorBasic kreator)
    {
        ModniKreator newKreator = new ModniKreator()
        {
            MBR = kreator.MBR,
            Ime = kreator.Ime,
            DatumRodjenja = kreator.DatumRodjenja,
            Pol = kreator.Pol,
            ZemljaPorekla = kreator.ZemljaPorekla
        };
        return newKreator;
    }
    public static void UpdateKreator(ModniKreator kreator, ModniKreatorBasic updateKreator)
    {
        kreator.Ime = updateKreator.Ime;
        kreator.DatumRodjenja = updateKreator.DatumRodjenja;
        kreator.Pol = updateKreator.Pol;
        kreator.ZemljaPorekla = updateKreator.ZemljaPorekla;
    }
    #endregion

    #region ModnaKuca
    public static ModnaKuca NewModnaKuca(ModnaKucaBasic modnaKuca)
    {
        ModnaKuca newModnaKuca = new ModnaKuca
        {
            Naziv = modnaKuca.Naziv,
            Osnivac = modnaKuca.Osnivac,
            Sediste = modnaKuca.Sediste
        };
        return newModnaKuca;
    }
    
    public static void UpdateModnaKuca(ModnaKuca kuca, ModnaKucaBasic updateKuca)
    {
        kuca.Osnivac = updateKuca.Osnivac;
        kuca.Sediste = updateKuca.Sediste;
    }
    #endregion

    #region Organizator
    public static Organizator NewOrganizator(OrganizatorBasic organizator)
    {
        Organizator newOrganizator = new Organizator
        {
            PrvaRevija = organizator.PrvaRevija,
            InformacijeOKolekciji = organizator.InformacijeOKolekciji
        };
        return newOrganizator;
    }

    public static void UpdateOrganizator(Organizator organizator, OrganizatorBasic updateOrganizator)
    {
        organizator.PrvaRevija = updateOrganizator.PrvaRevija;
        organizator.InformacijeOKolekciji = updateOrganizator.InformacijeOKolekciji;
    }
    #endregion
}