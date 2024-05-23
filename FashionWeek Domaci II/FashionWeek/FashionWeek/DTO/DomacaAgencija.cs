namespace FashionWeek.DTO;

public class DomacaAgencijaBasic : ModnaAgencijaBasic
{
    #region Constructors
    public DomacaAgencijaBasic() : base() { }
    public DomacaAgencijaBasic(string pib, string naziv, char inostrana, Adresa sediste, DateTime datumOsnivanja) : base(pib, naziv, inostrana, sediste, datumOsnivanja) { }
    #endregion
}
