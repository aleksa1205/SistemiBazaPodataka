using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FashionWeek.DTO;

public class ManekenPregled
{
    public string? MBR { get; set; }
    public Ime? Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public ManekenPregled() { }

    public ManekenPregled(string mbr, Ime ime, DateTime datumRodjenja, char pol)
    {
        MBR = mbr;
        Ime = ime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
    }

    public ManekenPregled(Maneken maneken)
    {
        MBR = maneken.MBR;
        Ime = maneken.Ime;
        DatumRodjenja = maneken.DatumRodjenja;
        Pol = maneken.Pol;
    }
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
    //virtual?
    public virtual ModnaAgencija? RadiUAgenciji { get; set; }
    public virtual IList<ModnaRevija> Revije { get; set; }
    public virtual IList<Casopis> Casopisi { get; set; }

    public ManekenBasic()
    {
        Revije = new List<ModnaRevija>();
        Casopisi = new List<Casopis>();
    }

    public ManekenBasic(string mbr, Ime ime, DateTime datumRodjenja, char pol, int visina, double tezina, string bojaOciju, string bojaKose, string konfBroj, string zanimanje) : this()
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
        RadiUAgenciji = maneken.RadiUAgenciji;
        Revije = new List<ModnaRevija>(maneken.Revije);
        Casopisi = new List<Casopis>(maneken.Casopisi);
    }
}