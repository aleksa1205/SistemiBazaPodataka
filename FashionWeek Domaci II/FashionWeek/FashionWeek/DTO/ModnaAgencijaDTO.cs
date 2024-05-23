using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.DTO;

public class ModnaAgencijaPregled
{
    public string PIB;
    public string Naziv;
    public char Inostrana;
    public Adresa? Sediste;
    public DateTime DatumOsnivanja;

    #region Constructors
    public ModnaAgencijaPregled() { }
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
    public string PIB;
    public string Naziv;
    public char Inostrana;
    public Adresa Sediste;
    public DateTime DatumOsnivanja;
    public virtual IList<ManekenBasic> Manekeni { get; set; } = [];

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
        foreach(var maneken in agencija.Manekeni)
        {
            Manekeni.Add(new ManekenBasic(maneken));
        }
    }
    #endregion
}