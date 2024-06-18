using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek_Library.DTO.Basic
{
    public class ModniKreatorBasic
    {
        public string MBR { get; set; }
        public Ime Ime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public char Pol { get; set; }
        public string? ZemljaPorekla { get; set; }
    }
}
