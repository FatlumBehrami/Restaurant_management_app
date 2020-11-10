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
        public static List<Pije> Pijet { get; set; } = new List<Pije>();


        public Menyja(Pije pijet)
        {
            Pijet.Add(pijet);
        }

        public Menyja(Ushqimi ushqimet)
        {
            Ushqimet.Add(ushqimet);
        }


    }
}
