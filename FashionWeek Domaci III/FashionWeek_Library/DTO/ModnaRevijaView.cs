namespace FashionWeek_Library.DTO;

public class ModnaRevijaView
{
    public int RBR { get; set; }
    public string? Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }
    //manekeni
    //kreatori
    //organizator
    //specijalnigosti

    public ModnaRevijaView() { }
    internal ModnaRevijaView(ModnaRevija revija)
    {
        RBR = revija.RBR;
        Naziv = revija.Naziv;
        Mesto = revija.Mesto;
        Termin = revija.Termin;
    }
}
