namespace FashionWeek.Entiteti;

public class ModniKreator : Osoba
{
    public virtual string? ZemljaPorekla { get; set; }

    public virtual ModnaKuca? RadiU { get; set; }
    public virtual IList<ModnaRevija> Revije { get; set; } = [];
    public virtual Organizator? Organizator { get; set; }
    public virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];
}
