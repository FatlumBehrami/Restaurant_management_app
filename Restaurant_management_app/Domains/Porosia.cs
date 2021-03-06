﻿using System;
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
        public int PorosiID { get; set; }

        public Sherbyesi Sherbyesi { get; set; }

        public DateTime Date = DateTime.Today;

        private int nrITavolines; 
        public int NrITavolines {
            get  { return nrITavolines; }
            set
            {
                if (value<0)
                {
                    MessageBox.Show("Vlere negative!");
                }
                else
                {
                    nrITavolines = value;
                }
            }
        }

        private decimal cmimiTotal = 0.0m;

        public ProduktiItem produkti { get; set; }

        public List<ProduktiItem> Produktet = new List<ProduktiItem>();

        public Porosia() { }

        public Porosia(Produkti produkti_i_porositur, int sasia_e_porosise, Sherbyesi sherbyesi)
        {
            produkti.Ushqimi = produkti_i_porositur;
            produkti.SasiaEPorosise = sasia_e_porosise;
            Sherbyesi = sherbyesi;
        }

        public void ShtoProdukt(ProduktiItem produkti)
        {
            Produktet.Add(produkti);
        }


        public decimal KalkuloFakturen()
        {
            foreach (var item in Produktet)
            {
                cmimiTotal += (item.Ushqimi.CmimiUshqimit*item.SasiaEPorosise);
            }
            return cmimiTotal;
        }
    }
}
