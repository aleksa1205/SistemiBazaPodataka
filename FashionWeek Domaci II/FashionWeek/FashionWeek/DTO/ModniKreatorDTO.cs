using FashionWeek.Entiteti.Helper;

namespace FashionWeek.DTO;
public class ModniKreatorPregled
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? ZemljaPorekla { get; set; }
    public string? RadiU { get; set; }

    #region Constructors
    public ModniKreatorPregled(string mbr, Ime ime, DateTime datumRodjenja, char pol, string? zemljaPorekla, string? radiU)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        ZemljaPorekla = zemljaPorekla;
        RadiU = radiU;
    }
    public ModniKreatorPregled(ModniKreator kreator)
    {
        MBR = kreator.MBR;
        Ime = kreator.Ime;
        DatumRodjenja = kreator.DatumRodjenja;
        Pol = kreator.Pol;
        ZemljaPorekla = kreator.ZemljaPorekla;
        RadiU = kreator.RadiU?.Naziv;
    }
    #endregion

    #region Overrides
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if(ReferenceEquals(this, obj)) 
        {
            return true;
        }
        ModniKreatorPregled compare = (obj as ModniKreatorPregled)!;
        return MBR == compare.MBR;
    }
    public override int GetHashCode()
    {
        return MBR.GetHashCode();
    }
    #endregion
}

public class ModniKreatorBasic
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? ZemljaPorekla { get; set; }
    public ModnaKucaBasic? RadiU { get; set; }
    public OrganizatorBasic? Organizator { get; set; }
    public List<ModnaRevijaBasic> Revije { get; set; } = [];
    public List<SpecijalanGostBasic> SpecijalniGosti { get; set; } = [];

    #region Constuctors
    public ModniKreatorBasic() { }
    public ModniKreatorBasic(string mbr, Ime ime, DateTime datumRodjenja, char pol, string zemljaPorekla)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        ZemljaPorekla = zemljaPorekla;
    }
    public ModniKreatorBasic(ModniKreator kreator)
    {
        MBR = kreator.MBR;
        Ime = kreator.Ime;
        DatumRodjenja = kreator.DatumRodjenja;
        Pol = kreator.Pol;
        ZemljaPorekla = kreator.ZemljaPorekla;
        RadiU = kreator.RadiU != null ? new(kreator.RadiU) : null;
        Organizator = kreator.Organizator != null ? new(kreator.Organizator) : null;
    }
    #endregion
}