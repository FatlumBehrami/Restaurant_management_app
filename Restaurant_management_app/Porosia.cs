using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Porosia
    {
        private int _nr_i_tavolines; 
        public int nr_i_tavolines {
            get  { return _nr_i_tavolines; }
            set
            {
                if (value<0)
                {
                    MessageBox.Show("Vlere negative!");
                }
                else
                {
                    _nr_i_tavolines = value;
                }
            }
        }
        Produkti_i_porositur produkti;
        public static List<Produkti_i_porositur> produktet { get; set; } = new List<Produkti_i_porositur>();

        public Porosia() { }
        public Porosia(string produkti_i_porositur, int sasia_e_porosise)
        {
            this.nr_i_tavolines = nr_i_tavolines;
            produkti = new Produkti_i_porositur(produkti_i_porositur, sasia_e_porosise);
        }

        public static void ShtoProduktet(Produkti_i_porositur produkti)
        {
            produktet.Add(produkti);
        }
    }
}
