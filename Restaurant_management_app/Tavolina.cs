using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Tavolina
    {
        int _id_e_tavolines = 0;
        int _numri_i_karrikave = 0;

        public int Id_e_tavolines
        {
            get { return _id_e_tavolines; }
            set
            {
                if (value > 0)
                {
                    _id_e_tavolines = value;
                }
                else
                {
                    MessageBox.Show("Keni shenuar id gabim!..");
                }
            }
        }


        public int Karrikat
        {
            get { return _numri_i_karrikave; }
            set
            {
                if (value > 1)
                {
                    _numri_i_karrikave = value;
                }
                else
                {
                    MessageBox.Show("Numri i pamjaftueshem i karrikave!..");
                }
            }
        }
    }
}
