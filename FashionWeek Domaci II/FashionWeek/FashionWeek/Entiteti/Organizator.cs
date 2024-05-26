namespace FashionWeek.Entiteti;

public class Organizator
{
    public virtual int Id { get; set; }
    public virtual char PrvaRevija { get; set; }
    public virtual string? InformacijeOKolekciji { get; set; }

    public virtual IList<ModniKreator> Kreatori { get; set; } = [];
    public virtual IList<ModnaKuca> ModneKuce { get; set; } = [];
    public virtual IList<ModnaRevija> ModneRevije { get; set; } = [];
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
        Organizator compare = (obj as Organizator);
        return this.Id == compare.Id;
    }
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
    #endregion
}
