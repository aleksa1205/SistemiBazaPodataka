namespace FashionWeek.Entiteti;

public class SpecijalanGost
{
    public virtual required SpecijalanGostId Id { get; set; }

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
