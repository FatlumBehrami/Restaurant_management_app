using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Sherbyesi
    {
        public int SherbyesiID { get; set; }
        public string Emri { get; set; }
        public bool IZene { get; set; }
        public int Shitjet { get; set; }

        public void MerrPorosine()
        {
            IZene = true;
        }

        public void PerfundoShitjen()
        {
            IZene = false;
            Shitjet++;
        }
    }
}
