using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Menyja
    {
        public static List<Produkti> Ushqimet { get; set; } = new List<Produkti>();
        
        public Menyja(Produkti ushqimet)
        {
            Add(ushqimet);
        }

        public void Add(Produkti ushqimet)
        {
            Ushqimet.Add(ushqimet);
        }
    }
}
