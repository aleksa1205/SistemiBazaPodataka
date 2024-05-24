namespace FashionWeek.Entiteti;

public class InostranaAgencija : ModnaAgencija
{
    public virtual IList<NazivZemlje> Zemlje { get; set; } = [];
}
