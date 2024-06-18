namespace FashionWeek_Library.Entiteti;

internal class ModniKreator : Osoba
{
    internal protected virtual string? ZemljaPorekla { get; set; }
    internal protected virtual ModnaKuca? RadiU { get; set; } = null;
    internal protected virtual IList<ModnaRevija> Revije { get; set; } = [];
    internal protected virtual Organizator? Organizator { get; set; } = null;
    internal protected virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];

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
