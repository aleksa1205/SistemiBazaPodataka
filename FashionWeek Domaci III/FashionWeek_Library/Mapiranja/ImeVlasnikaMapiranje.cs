namespace FashionWeek_Library.Mapiranja;

internal class ImeVlasnikaMapiranje : ClassMap<ImeVlasnika>
{
    public ImeVlasnikaMapiranje()
    {
        Table("IMENA_VLASNIKA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.ModnaKuca, "NAZIV_KUCE")
            .KeyProperty(x => x.LicnoIme, "LICNO_IME")
            .KeyProperty(x => x.Prezime, "PREZIME");
    }
}
