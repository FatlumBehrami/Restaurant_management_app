using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Produkti_i_porositur
    {
        public string produkti_i_porositur { get; set; }
        private int sasia_e_porosise;
        public int Sasia_e_porosise
        {
            get { return sasia_e_porosise; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Vlere e pamjaftueshme!");
                }
                else
                {
                    sasia_e_porosise = value;
                }
            }
        }
        public Produkti_i_porositur() { }
        public Produkti_i_porositur(string produkti, int sasia)
        {
            produkti_i_porositur = produkti;
            Sasia_e_porosise = sasia;
        }
    }
}
