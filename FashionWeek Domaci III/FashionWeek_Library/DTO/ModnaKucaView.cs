namespace FashionWeek_Library.DTO;

public class ModnaKucaView
{
    public string? Naziv { get; set; }
    public Ime? Osnivac { get; set; }
    public Adresa? Sediste { get; set; }
    //kreatori
    //organizator
    //vlasnici

    public ModnaKucaView() { }
    internal ModnaKucaView(ModnaKuca modnaKuca)
    {
        Naziv = modnaKuca.Naziv;
        Osnivac = modnaKuca.Osnivac;
        Sediste = modnaKuca.Sediste;
    }
}
