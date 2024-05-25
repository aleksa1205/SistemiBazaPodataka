namespace FashionWeek.DTO;

public class ManekenPregled
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? RadiU { get; set; }

    #region Constructors
    public ManekenPregled(string mbr, Ime ime, DateTime datumRodjenja, char pol, string radiu)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        RadiU = radiu;
    }

    public ManekenPregled(Maneken maneken)
    {
        MBR = maneken.MBR;
        Ime = maneken.Ime;
        DatumRodjenja = maneken.DatumRodjenja;
        Pol = maneken.Pol;
        //RadiU = maneken.RadiUAgenciji?.Naziv;
    }
    #endregion
}

public class ManekenNezaposlenPregled
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? Zanimanje { get; set; }

    #region Constructors
    public ManekenNezaposlenPregled(string mbr, Ime ime, DateTime datumRodjenja, char pol, string zanimanje)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        Zanimanje = zanimanje;
    }
    public ManekenNezaposlenPregled(Maneken maneken)
    {
        MBR = maneken.MBR;
        Ime = maneken.Ime;
        DatumRodjenja = maneken.DatumRodjenja;
        Pol = maneken.Pol;
        Zanimanje = maneken.Zanimanje;
    }
    #endregion
}

public class ManekenBasic
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public int Visina { get; set; }
    public double Tezina { get; set; }
    public string? BojaOciju { get; set; }
    public string? BojaKose { get; set; }
    public string? KonfekcijskiBroj { get; set; }
    public string? Zanimanje { get; set; }
    public ModnaAgencijaBasic? RadiUAgenciji { get; set; }
    public List<ModnaRevijaBasic> Revije { get; set; } = [];
    public List<CasopisBasic> Casopisi { get; set; } = [];

    #region Constructors
    public ManekenBasic() { }
    public ManekenBasic(string mbr, Ime ime, DateTime datumRodjenja, char pol, int visina, double tezina, string bojaOciju, string bojaKose, string konfBroj, string zanimanje)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        Visina = visina;
        Tezina = tezina;
        BojaOciju = bojaOciju;
        BojaKose = bojaKose;
        KonfekcijskiBroj = konfBroj;
        Zanimanje = zanimanje;
    }
    public ManekenBasic(Maneken maneken)
    {
        MBR = maneken.MBR;
        Ime = maneken.Ime;
        DatumRodjenja = maneken.DatumRodjenja;
        Pol = maneken.Pol;
        Visina = maneken.Visina;
        Tezina = maneken.Tezina;
        BojaOciju = maneken.BojaOciju;
        BojaKose = maneken.BojaKose;
        KonfekcijskiBroj = maneken.KonfekcijskiBroj;
        Zanimanje = maneken.Zanimanje;
    }
    #endregion
}