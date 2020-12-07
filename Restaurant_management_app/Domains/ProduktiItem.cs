using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class ProduktiItem
    {

        public Produkti Ushqimi { get; set; }

        private int sasiaEPorosise;
        public int SasiaEPorosise
        {
            get { return sasiaEPorosise; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Vlere e pamjaftueshme!");
                }
                else
                {
                    sasiaEPorosise = value;
                }
            }
        }

        public ProduktiItem() { }

        public ProduktiItem(Produkti produkti, int sasia)
        {
            Ushqimi = produkti;
            SasiaEPorosise = sasia;
        }
    }
}
