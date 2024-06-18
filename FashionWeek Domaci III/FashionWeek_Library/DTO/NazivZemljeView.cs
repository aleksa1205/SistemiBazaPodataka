namespace FashionWeek_Library.DTO;

public class NazivZemljeView
{
    public NazivZemljeIdView Id { get; set; }
    
    public NazivZemljeView() { }
    internal NazivZemljeView(NazivZemlje nazivZemlje)
    {
        Id = new NazivZemljeIdView(nazivZemlje.Id);
    }
}
