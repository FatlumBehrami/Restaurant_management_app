using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app
{
    class ListaETavolinave
    {
        public static List<Tavolina> _lista { get; set; } = new List<Tavolina>();

        public ListaETavolinave(Tavolina tavolina)
        {
            _lista.Add(tavolina);
        }
    }
}
