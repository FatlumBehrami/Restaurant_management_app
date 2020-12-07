using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Produkti
    {
        
        public int Id { get; set; }

        public int NumriShitjeve { get; set; }

        private string emriUshqimit = "";
        private decimal cmimiUshqimit = 0;

        public string MadhesiaEUshqimit { get; set; }

        public string EmriUshqimit {
            get
            {
                return emriUshqimit;
            }
            set
            {
                if (value != "")
                {
                    emriUshqimit = value;
                }
                else
                {
                    MessageBox.Show("Emri i ushqimit eshte gabim!");
                }
            }
        }

        public decimal CmimiUshqimit
        {
            get { return cmimiUshqimit; }
            set
            {
                if (value > 0)
                {
                    cmimiUshqimit = value;
                }
                else
                {
                    MessageBox.Show("Cmimi i ushqimit eshte gabim!");
                }
            }
        }


        public List<string> Perberesit { get; set; } = new List<string>();

        public Produkti() { }
        public Produkti(string emri, decimal cmimi)
        {
            EmriUshqimit = emri;
            CmimiUshqimit = cmimi;
        }

        public Produkti(string emri, string madhesia, decimal cmimi)
        {
            EmriUshqimit = emri;
            MadhesiaEUshqimit = madhesia;
            CmimiUshqimit = cmimi;
        }

        public Produkti(string emri, string madhesia, decimal cmimi, List<string> perberesit)
        {
            EmriUshqimit = emri;
            MadhesiaEUshqimit = madhesia;
            CmimiUshqimit = cmimi;
            Perberesit = perberesit;
        }
    }
}
