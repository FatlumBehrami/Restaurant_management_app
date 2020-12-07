using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class Klienti:Personi
    {
        public int NrTelefoni { get; set; }

        public Klienti(string emri, int numri)
        {
            Emri = emri;
            NrTelefoni = numri;
        }
    }
}
