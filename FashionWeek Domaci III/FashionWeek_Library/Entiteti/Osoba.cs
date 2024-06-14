namespace FashionWeek_Library.Entiteti;

internal abstract class Osoba
{
    internal protected virtual string? MBR { get; set; }
    internal protected virtual Ime? Ime { get; set; }
    internal protected virtual DateTime DatumRodjenja { get; set; }
    internal protected virtual char Pol { get; set; }
}
