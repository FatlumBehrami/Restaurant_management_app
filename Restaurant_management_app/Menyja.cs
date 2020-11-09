using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Menyja
    {
        List<Ushqimi> _ushqimet = new List<Ushqimi>();
        List<Pije> _pijet = new List<Pije>();


        public Menyja(List<Pije> pijet)
        {
            this._pijet = pijet;
        }

        public Menyja(List<Ushqimi> ushqimet)
        {
            this._ushqimet = ushqimet;
        }


    }
}
