namespace FashionWeek_Library.DTO;

public class InostranaAgencijaView : ModnaAgencijaView
{
    public List<NazivZemljeView> NaziviZemalja { get; set; } = [];
    
    public InostranaAgencijaView() { }
    internal InostranaAgencijaView(InostranaAgencija agencija) 
    {
        PIB = agencija.PIB;
        Naziv = agencija.Naziv;
        Sediste = agencija.Sediste;
        DatumOsnivanja = agencija.DatumOsnivanja;
    }
}
