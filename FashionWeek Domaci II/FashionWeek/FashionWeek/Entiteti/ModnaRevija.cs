namespace FashionWeek.Entiteti;

public class ModnaRevija
{
    public virtual int RBR { get; set; }
    public virtual required string Naziv { get; set; }
    public virtual Adresa? Mesto { get; set; }
    public virtual DateTime Termin { get; set; }
    public virtual IList<Maneken> Manekeni { get; set; } = [];
    public virtual IList<ModniKreator> Kreatori { get; set; } = [];
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
        ModnaRevija compare = (obj as ModnaRevija);
        return this.RBR == compare.RBR;
    }
    public override int GetHashCode()
    {
        return this.RBR.GetHashCode();
    }
    #endregion
}