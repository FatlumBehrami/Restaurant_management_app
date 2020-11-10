using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    static class ListaEPorosive
    {
        public static List<Porosia> ListaPorosive { get; set; } = new List<Porosia>();

        public static void ShtoPorosi(Porosia porosia)
        {
            ListaPorosive.Add(porosia);
        }
    }
}
