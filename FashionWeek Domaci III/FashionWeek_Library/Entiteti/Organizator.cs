namespace FashionWeek_Library.Entiteti;

internal class Organizator
{
    internal protected virtual int Id { get; set; }
    internal protected virtual char PrvaRevija { get; set; }
    internal protected virtual string? InformacijeOKolekciji { get; set; }

    internal protected virtual IList<ModniKreator> Kreatori { get; set; } = [];
    internal protected virtual IList<ModnaKuca> ModneKuce { get; set; } = [];
    internal protected virtual IList<ModnaRevija> ModneRevije { get; set; } = [];
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
        Organizator compare = (obj as Organizator);
        return this.Id == compare.Id;
    }
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
    #endregion
}
