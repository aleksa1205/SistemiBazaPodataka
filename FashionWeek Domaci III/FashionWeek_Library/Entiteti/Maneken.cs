namespace FashionWeek_Library.Entiteti;

internal class Maneken : Osoba
{
    internal protected virtual int Visina { get; set; }
    internal protected virtual double Tezina { get; set; }
    internal protected virtual string? BojaOciju { get; set; }
    internal protected virtual string? BojaKose { get; set; }
    internal protected virtual string? KonfekcijskiBroj { get; set; }
    internal protected virtual string? Zanimanje { get; set; }

    internal protected virtual ModnaAgencija? RadiUAgenciji { get; set; }
    internal protected virtual IList<ModnaRevija> Revije { get; set; } = [];
    internal protected virtual IList<Casopis> Casopisi { get; set; } = [];
}
