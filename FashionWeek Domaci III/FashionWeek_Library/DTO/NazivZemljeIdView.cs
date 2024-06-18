namespace FashionWeek_Library.DTO;

public class NazivZemljeIdView
{
    public InostranaAgencijaView InostranaAgencija { get; set; } 
    public string NazivZemlje {  get; set; }

    public NazivZemljeIdView() { }
    internal NazivZemljeIdView(NazivZemljeId Id)
    {
        InostranaAgencija = new(Id.InostranaAgencija);
        NazivZemlje = Id.NazivZemlje;
    }
}
