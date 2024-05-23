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
    public int RBR;
    public string Naziv;
    public Adresa? Mesto;
    public DateTime Termin;

    public ModnaRevijaPregled() { }

    public ModnaRevijaPregled(int rbr, string naziv, Adresa? mesto, DateTime termin)
    {
        RBR = rbr;
        Naziv = naziv;
        Termin = termin;
        Mesto = mesto != null ? new Adresa(mesto) : new Adresa();
    }

    public ModnaRevijaPregled(ModnaRevija revija)
    {
        RBR = revija.RBR;
        Naziv = revija.Naziv;
        Termin = revija.Termin;
        Mesto = revija.Mesto != null ? new Adresa(revija.Mesto) : new Adresa();
    }
}

public class ModnaRevijaBasic
{
    public int RBR;
    public string Naziv;
    public Adresa Mesto;
    public DateTime Termin;
    public virtual IList<ManekenBasic> Manekeni { get; set; }
    public virtual IList<ModniKreatorBasic> Kreatori { get; set; }
    //organizator
    //specijalnigosti

    #region Constructors

    #endregion
}