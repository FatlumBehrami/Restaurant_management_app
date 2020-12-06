using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Menyja
    {
        public static List<Ushqimi> Ushqimet { get; set; } = new List<Ushqimi>();
        
        public Menyja(Ushqimi ushqimet)
        {
            Ushqimet.Add(ushqimet);
        }

    }
}
