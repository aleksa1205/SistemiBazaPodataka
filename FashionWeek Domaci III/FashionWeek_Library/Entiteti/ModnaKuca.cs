namespace FashionWeek_Library.Entiteti;

internal class ModnaKuca
{
    internal protected virtual string? Naziv { get; set; }
    internal protected virtual Ime? Osnivac { get; set; }
    internal protected virtual Adresa? Sediste { get; set; }

    internal protected virtual IList<ModniKreator> Kreatori { get; set; } = [];
    internal protected virtual Organizator? Organizator { get; set; }
    internal protected virtual IList<ImeVlasnika> Vlasnici { get; set; } = [];
}
