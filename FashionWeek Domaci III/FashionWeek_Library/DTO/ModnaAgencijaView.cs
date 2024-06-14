namespace FashionWeek_Library.DTO;

public class ModnaAgencijaView
{
    public string? PIB { get; set; }
    public string? Naziv { get; set; }
    public Adresa? Sediste { get; set; }
    public DateTime DatumOsnivanja { get; set; }
    //manekeni

    public ModnaAgencijaView() { }
    internal ModnaAgencijaView(ModnaAgencija agencija) 
    {
        PIB = agencija.PIB;
        Naziv = agencija.Naziv;
        Sediste = agencija.Sediste;
        DatumOsnivanja = agencija.DatumOsnivanja;
    }
}
