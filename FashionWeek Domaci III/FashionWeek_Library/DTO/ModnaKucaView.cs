namespace FashionWeek_Library.DTO;

public class ModnaKucaView
{
    public string? Naziv { get; set; }
    public Ime? Osnivac { get; set; }
    public Adresa? Sediste { get; set; }
    public virtual IList<ModniKreatorView> Kreatori { get; set; } = [];
    public virtual OrganizatorView? Organizator { get; set; } = null;
    public virtual IList<ImeVlasnikaView> Vlasnici { get; set; } = [];

    public ModnaKucaView() { }
    internal ModnaKucaView(ModnaKuca modnaKuca)
    {
        Naziv = modnaKuca.Naziv;
        Osnivac = modnaKuca.Osnivac;
        Sediste = modnaKuca.Sediste;
    }
}
