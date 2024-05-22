using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.DTO;

public class ModnaRevijaPregled
{
    public int RBR { get; set; }
    public string Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }

    public ModnaRevijaPregled() { }

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
        Termin = revija.Termin;

            Mesto = revija.Mesto;
    }
}