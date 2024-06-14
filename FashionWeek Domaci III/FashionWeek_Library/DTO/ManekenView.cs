namespace FashionWeek_Library.DTO;

public class ManekenView : OsobaView
{
    public int Visina { get; set; }
    public double Tezina { get; set; }
    public string? BojaOciju { get; set; }
    public string? BojaKose { get; set; }
    public string? KonfekcijskiBroj { get; set; }
    public string? Zanimanje { get; set; }
    //public ModnaAgencijaView? RadiUAgenciji { get; set; }

    public ManekenView() { }
    internal ManekenView(Maneken maneken)
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
        //radi u agenciji
    }

    public override string ToString()
    {
        //if (RadiUAgenciji != null)
        //{
        //    return MBR + ' ' + Ime.ToString() + ' ' + RadiUAgenciji.Naziv;

        //}
        return MBR + ' ' + Ime.ToString();
    }
}
