using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    //Som en klass
    //  MEN
    //en struct är en valuetyp, inte en referenstyp
    //saknar arv
    struct Auto
    {
        //kan ha variabler, konstruktorer, properties, metoder
        public Auto(string brand,int yearmodel)
        {
            Brand = brand;
            Yearmodel = yearmodel;
        }
        public string Brand
        {
            get; set;
        }

        public int Yearmodel
        {
            get; set;
        }

        
    }
}
