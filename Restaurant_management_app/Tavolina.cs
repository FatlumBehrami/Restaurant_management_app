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
        private int _id_e_tavolines = 0;
        private int _numri_i_karrikave = 0;

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
                    MessageBox.Show("Keni shenuar id gabim!");
                }
            }
        }


        public int NumriKarrikave
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
                    MessageBox.Show("Numri i pamjaftueshem i karrikave!");
                }
            }
        }

        public Tavolina(int id, int karrikat)
        {
            Id_e_tavolines = id;
            NumriKarrikave = karrikat;
        }
    }
}
