using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class InostranaAgencija : ModnaAgencija
    {
        public virtual IList<NazivZemlje> Zemlje { get; set; } = [];
    }
}
