namespace FashionWeek_Library.Mapiranja;

internal class AdresaMapiranje : ComponentMap<Adresa>
{
    public AdresaMapiranje()
    {
        Map(x => x.Drzava).Column("DRZAVA");
        Map(x => x.Grad).Column("GRAD");
        Map(x => x.Ulica).Column("ULICA");
    }
}
