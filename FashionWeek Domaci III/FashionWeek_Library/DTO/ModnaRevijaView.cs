namespace FashionWeek_Library.DTO;

public class ModnaRevijaView
{
    public int RBR { get; set; }
    public string? Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }
    public virtual IList<ManekenView> Manekeni { get; set; } = [];
    public virtual IList<ModniKreatorView> Kreatori { get; set; } = [];
    public virtual OrganizatorView? Organizator { get; set; } = null;
    public virtual IList<SpecijalanGostView> SpecijalniGosti { get; set; } = [];

    public ModnaRevijaView() { }
    internal ModnaRevijaView(ModnaRevija revija)
    {
        RBR = revija.RBR;
        Naziv = revija.Naziv;
        Mesto = revija.Mesto;
        Termin = revija.Termin;
    }
}
