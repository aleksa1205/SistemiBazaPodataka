using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek_Library.DTO
{
    public class ImeVlasnikaView
    {
        public ImeVlasnikaIdView Id { get; set; }   
        
        public ImeVlasnikaView() { }
        internal ImeVlasnikaView(ImeVlasnika imeVlasnika)
        {
            Id = new ImeVlasnikaIdView(imeVlasnika.Id);
        }
    }
}
