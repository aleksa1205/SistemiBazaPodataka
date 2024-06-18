namespace FashionWeek_Library.DTO;

public class ModnaAgencijaView
{
    public string? PIB { get; set; }
    public string? Naziv { get; set; }
    public char Inostrana {  get; set; }
    public Adresa? Sediste { get; set; }
    public DateTime DatumOsnivanja { get; set; }
    public virtual IList<ManekenView> Manekeni { get; set; } = [];

    public ModnaAgencijaView() { }
    internal ModnaAgencijaView(ModnaAgencija agencija) 
    {
        PIB = agencija.PIB;
        Naziv = agencija.Naziv;
        Inostrana = agencija.Inostrana;
        Sediste = agencija.Sediste;
        DatumOsnivanja = agencija.DatumOsnivanja;
    }
}
