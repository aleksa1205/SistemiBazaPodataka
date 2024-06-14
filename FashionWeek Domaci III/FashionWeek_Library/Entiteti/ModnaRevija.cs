namespace FashionWeek_Library.Entiteti;

internal class ModnaRevija
{
    internal protected virtual int RBR { get; set; }
    internal protected virtual string? Naziv { get; set; }
    internal protected virtual Adresa? Mesto { get; set; }
    internal protected virtual DateTime Termin { get; set; }
    internal protected virtual IList<Maneken> Manekeni { get; set; } = [];
    internal protected virtual IList<ModniKreator> Kreatori { get; set; } = [];
    internal protected virtual Organizator? Organizator { get; set; }
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
        ModnaRevija compare = (obj as ModnaRevija);
        return this.RBR == compare.RBR;
    }
    public override int GetHashCode()
    {
        return this.RBR.GetHashCode();
    }
    #endregion
}