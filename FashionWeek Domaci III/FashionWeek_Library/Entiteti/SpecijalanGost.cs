namespace FashionWeek_Library.Entiteti;

internal class SpecijalanGost
{
    internal protected virtual SpecijalanGostId? Id { get; set; }

    #region Overrides
    public override bool Equals(object? obj)
    {
        if(obj == null) 
            return false;
        if(ReferenceEquals(this, obj))
        {
            return true;
        }
        SpecijalanGost specgost = (obj as SpecijalanGost)!;
        return Id == specgost!.Id;
    }
    #endregion
}
