using System.Linq;

namespace FashionWeek.DTO;

public class ModnaRevijaPregled
{
    public int RBR { get; set; }
    public string Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }

    #region Constructors
    public ModnaRevijaPregled(int rbr, string naziv, Adresa? mesto, DateTime termin)
    {
        RBR = rbr;
        Naziv = naziv;
        Termin = termin;
        Mesto = mesto;
    }
    public ModnaRevijaPregled(ModnaRevija revija)
    {
        RBR = revija.RBR;
        Naziv = revija.Naziv;
        Mesto = revija.Mesto;
        Termin = revija.Termin;
    }
    #endregion
}

public class ModnaRevijaBasic
{
    public int RBR { get; set; }
    public string? Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }
    public List<ManekenBasic> Manekeni { get; set; } = [];
    public List<ModniKreatorBasic> Kreatori { get; set; } = [];
    public OrganizatorBasic? Organizator { get; set; }
    public List<SpecijalanGostBasic> SpecijalniGosti { get; set; } = [];

    #region Constructors
    public ModnaRevijaBasic() { }
    public ModnaRevijaBasic(int rbr, string naziv, Adresa mesto, DateTime termin)
    {
        RBR = rbr;
        Naziv = naziv;
        Mesto = mesto;
        Termin = termin;
    }
    public ModnaRevijaBasic(ModnaRevija revija)
    {
        RBR = revija.RBR;
        Naziv = revija.Naziv;
        Mesto = revija.Mesto;
        Termin = revija.Termin;
    }
    #endregion
}