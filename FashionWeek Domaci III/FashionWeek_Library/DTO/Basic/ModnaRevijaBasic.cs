using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek_Library.DTO.Basic;

public class ModnaRevijaBasic
{
    public int RBR { get; set; }
    public string? Naziv { get; set; }
    public Adresa? Mesto { get; set; }
    public DateTime Termin { get; set; }
}
