﻿namespace FashionWeek.DTO;
public class InostranaAgencijaBasic : ModnaAgencijaBasic
{
    public List<NazivZemljeBasic> NaziviZemalja { get; set; } = [];

    #region Constructors
    public InostranaAgencijaBasic() : base() { }
    public InostranaAgencijaBasic(string pib, string naziv, char inostrana, Adresa sediste, DateTime datumOsnivanja) : base(pib, naziv, inostrana, sediste, datumOsnivanja) { }
    public InostranaAgencijaBasic(InostranaAgencija agencija) : base(agencija) 
    {    }
    #endregion
}
