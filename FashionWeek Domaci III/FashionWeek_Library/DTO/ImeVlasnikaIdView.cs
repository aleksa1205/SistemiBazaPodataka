namespace FashionWeek_Library.DTO;

public class ImeVlasnikaIdView
{
    public ModnaKucaView ModnaKuca { get; set; }
    public string LicnoIme { get; set; }
    public string Prezime { get; set; }

    public ImeVlasnikaIdView() { }
    internal ImeVlasnikaIdView(ImeVlasnikaId Id)
    {
        ModnaKuca = new ModnaKucaView(Id.ModnaKuca);
        LicnoIme = Id.LicnoIme;
        Prezime = Id.Prezime;
    }
}
