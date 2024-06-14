namespace FashionWeek_Library.Entiteti;

internal abstract class ModnaAgencija
{
    internal protected virtual string? PIB { get; set; }
    internal protected virtual required string? Naziv { get; set; }
    internal protected virtual char Inostrana { get; set; }
    internal protected virtual Adresa? Sediste { get; set; }
    internal protected virtual DateTime DatumOsnivanja { get; set; }
    internal protected virtual IList<Maneken> Manekeni { get; set; } = [];

}
