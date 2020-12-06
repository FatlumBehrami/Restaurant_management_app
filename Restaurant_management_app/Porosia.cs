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
        private int nr_i_tavolines; 
        public int Nr_i_tavolines {
            get  { return nr_i_tavolines; }
            set
            {
                if (value<0)
                {
                    MessageBox.Show("Vlere negative!");
                }
                else
                {
                    nr_i_tavolines = value;
                }
            }
        }

        Produkti_i_porositur produkti;
        public static List<Produkti_i_porositur> Produktet { get; set; } = new List<Produkti_i_porositur>();

        public Porosia() { }
        public Porosia(string produkti_i_porositur, int sasia_e_porosise)
        {
            produkti = new Produkti_i_porositur(produkti_i_porositur, sasia_e_porosise);
        }

        public void ShtoProduktet(Produkti_i_porositur produkti)
        {
            Produktet.Add(produkti);
        }
    }
}
