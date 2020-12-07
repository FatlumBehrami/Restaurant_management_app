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
        private int id_e_tavolines = 0;
        private int numri_i_karrikave = 0;
        public bool eZene = false;
        public int Id_e_tavolines
        {
            get { return id_e_tavolines; }
            set
            {
                if (value > 0)
                {
                    id_e_tavolines = value;
                }
                else
                {
                    MessageBox.Show("Keni shenuar id gabim!");
                }
            }
        }


        public int NumriKarrikave
        {
            get { return numri_i_karrikave; }
            set
            {
                if (value > 1)
                {
                    numri_i_karrikave = value;
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

        public void RezervoTavolinen()
        {
            eZene = true;
        }

        public bool EZene()
        {
            return eZene;
        }


    }
}
