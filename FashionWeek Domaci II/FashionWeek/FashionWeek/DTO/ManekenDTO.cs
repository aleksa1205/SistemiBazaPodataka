using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FashionWeek.DTO;

public class ManekenDTO
{
    public string MBR;
    public Ime Ime;
    public DateTime DatumRodjenja;
    public char Pol;
    public int Visina;
    public double Tezina;
    public string BojaOciju;
    public string BojaKose;
    public string KonfekcijskiBroj;
    public string Zanimanje;
    public ModnaAgencija? RadiUAgenciji;

    public ManekenDTO() { }

    public ManekenDTO(string mbr, string ime, string prezime, DateTime datumRodjenja, char pol, int visina, double tezina)
    {
        MBR = mbr;
        Ime!.LicnoIme = ime;
        Ime.Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        Pol = pol;
        Visina = visina;
        Tezina = tezina;
    }

    public ManekenDTO(string mbr, string ime, string prezime, DateTime datumRodjenja, char pol, int visina, double tezina, string bojaOciju, string bojaKose, string konfBroj, ModnaAgencija agencija) : this(mbr, ime, prezime, datumRodjenja, pol, visina, tezina)
    {
        BojaOciju = bojaOciju;
        BojaKose = bojaKose;
        KonfekcijskiBroj = konfBroj;
        RadiUAgenciji = agencija;
    }
}
