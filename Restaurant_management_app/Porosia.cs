using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Porosia
    {
        int _nr_i_tavolines; 
        string _produkti_i_porositur;
        int _sasia_e_porosise;

        public Porosia(int nr_i_tavolines, string produkti_i_porositur, int sasia_e_porosise)
        {
            this._nr_i_tavolines = nr_i_tavolines;
            this._produkti_i_porositur = produkti_i_porositur;
            this._sasia_e_porosise = sasia_e_porosise;
        }
    }
}
