using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.DTO;

public class ModniKreatorPregled
{
    public string MBR { get; set; }
    public Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? ZemljaPorekla { get; set; }
    public string? RadiU { get; set; }

    public ModniKreatorPregled() { }

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
}

public class ModniKreatorBasic
{
    public virtual required string MBR { get; set; }
    public virtual required Ime Ime { get; set; }
    public virtual DateTime DatumRodjenja { get; set; }
    public virtual char Pol { get; set; }
    public virtual string? ZemljaPorekla { get; set; }

    public virtual ModnaKuca? RadiU { get; set; }
    public virtual Organizator? Organizator { get; set; }
    public virtual IList<ModnaRevija> Revije { get; set; } 
    public virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];

    public ModniKreatorBasic()
    {
        Revije = new List<ModnaRevija>();
    }
}