namespace FashionWeek_Library.DTO;

public class CasopisIdView
{
    public ManekenView? Maneken { get; set; }
    public string? NazivCasopisa { get; set; }

    public CasopisIdView() { }
    internal CasopisIdView(CasopisId id)
    {
        Maneken = new ManekenView(id.Maneken);
        NazivCasopisa = id.NazivCasopisa;
    }
}
