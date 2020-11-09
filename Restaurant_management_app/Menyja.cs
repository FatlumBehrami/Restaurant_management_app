using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Menyja
    {
        List<Ushqimi> _ushqimet { get; set; } = new List<Ushqimi>();
        List<Pije> _pijet { get; set; } = new List<Pije>();


        public Menyja(Pije pijet)
        {
            _pijet.Add(pijet);
        }

        public Menyja(Ushqimi ushqimet)
        {
            _ushqimet.Add(ushqimet);
        }


    }
}
