using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management_app.Repository
{
    class ListaESherbysve
    {
        static List<Sherbyesi> ListaSherbysve = new List<Sherbyesi>();

        public ListaESherbysve(Sherbyesi sherbyesi)
        {
            Add(sherbyesi);
        }

        public void Add(Sherbyesi sherbyesi)
        {
            ListaSherbysve.Add(sherbyesi);
        }
    }
}
