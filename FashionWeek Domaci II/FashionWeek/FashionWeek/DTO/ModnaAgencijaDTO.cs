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
    public string? PIB { get; set; }
    public string? Naziv { get; set; }
    public char Inostrana { get; set; }
    public Adresa? Sediste { get; set; }
    public DateTime DatumOsnivanja { get; set; }

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
