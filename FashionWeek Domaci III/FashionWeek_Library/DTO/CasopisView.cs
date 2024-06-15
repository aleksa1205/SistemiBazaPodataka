namespace FashionWeek_Library.DTO;

public class CasopisView
{
    public CasopisIdView Id { get; set; }
    
    public CasopisView() { }
    internal CasopisView(Casopis c)
    {
        Id = new CasopisIdView(c.Id);
    }
}
