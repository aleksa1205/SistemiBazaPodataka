using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek_Library.DTO.Basic
{
    public class ModnaAgencijaBasic
    {
        public string PIB { get; set; }
        public string Naziv { get; set; }
        public char Inostrana { get; set; }
        public Adresa Sediste { get; set; }
        public DateTime DatumOsnivanja { get; set; }
    }
}
