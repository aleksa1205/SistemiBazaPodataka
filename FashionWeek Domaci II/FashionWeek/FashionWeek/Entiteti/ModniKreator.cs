using FluentNHibernate.Visitors;

namespace FashionWeek.Entiteti;

public class ModniKreator : Osoba
{
    public virtual string? ZemljaPorekla { get; set; }

    public virtual ModnaKuca? RadiU { get; set; }
    public virtual IList<ModnaRevija> Revije { get; set; } = [];
    public virtual Organizator? Organizator { get; set; }
    public virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];

    #region Overrides
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if(ReferenceEquals(this, obj))
        {
            return true;
        }
        ModniKreator compare = (obj as ModniKreator);
        return this.MBR == compare.MBR;
    }
    public override int GetHashCode()
    {
        return this.MBR.GetHashCode();
    }
    #endregion
}
