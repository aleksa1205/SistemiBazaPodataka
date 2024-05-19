﻿using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti
{
    public class ModnaAgencija
    {
        public virtual required string PIB { get; set; }
        public virtual required string Naziv { get; set; }
        public virtual char Inostrana { get; set; }
        public virtual Adresa? Sediste { get; set; }
        public virtual DateTime DatumOsnivanja { get; set; }

        public virtual IList<Maneken> Manekeni { get; set; }
        public virtual IList<NazivZemlje> Zemlje { get; set; }

        public ModnaAgencija()
        {
            Manekeni = new List<Maneken>();
            Zemlje = new List<NazivZemlje>();
        }
    }
}