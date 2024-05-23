namespace FashionWeek.DTO;

public class ModnaAgencijaPregled
{
    public string PIB { get; set; }
    public string Naziv { get; set; }
    public Adresa? Sediste { get; set; }
    public DateTime DatumOsnivanja { get; set; }

    #region Constructors
    public ModnaAgencijaPregled(string pib, string naziv, Adresa? sediste, DateTime datumOsnivanja)
    {
        PIB = pib;
        Naziv = naziv;
        Sediste = sediste;
        DatumOsnivanja = datumOsnivanja;
    }
    public ModnaAgencijaPregled(ModnaAgencija agencija)
    {
        PIB = agencija.PIB;
        Naziv = agencija.Naziv;
        Sediste = agencija.Sediste;
        DatumOsnivanja = agencija.DatumOsnivanja;
    }
    #endregion
}

public class ModnaAgencijaBasic
{
    public string PIB { get; set; }
    public string Naziv { get; set; }
    public char Inostrana { get; set; }
    public Adresa? Sediste { get; set; }
    public DateTime DatumOsnivanja { get; set; }
    public List<ManekenBasic> Manekeni { get; set; } = [];

    #region Constructors
    public ModnaAgencijaBasic() { }
    public ModnaAgencijaBasic(string pib, string naziv, char inostrana, Adresa sediste, DateTime datumOsnivanja)
    {
        PIB = pib;
        Naziv = naziv;
        Inostrana = inostrana;
        Sediste = sediste;
        DatumOsnivanja = datumOsnivanja;
    }
    public ModnaAgencijaBasic(ModnaAgencija agencija)
    {
        PIB = agencija.PIB;
        Naziv = agencija.Naziv;
        Inostrana = agencija.Inostrana;
        Sediste = agencija.Sediste;
        DatumOsnivanja = agencija.DatumOsnivanja;
        Manekeni.AddRange(agencija.Manekeni.Select(maneken => new ManekenBasic(maneken)));
    }
    #endregion
}