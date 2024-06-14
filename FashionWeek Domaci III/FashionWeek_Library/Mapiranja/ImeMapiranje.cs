namespace FashionWeek_Library.Mapiranja;

internal class ImeMapiranje : ComponentMap<Ime>
{
    public ImeMapiranje()
    {
        Map(x => x.LicnoIme).Column("LICNO_IME");
        Map(x => x.Prezime).Column("PREZIME");
    }
}
