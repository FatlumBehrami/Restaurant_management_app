using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Ushqimi
    {
        public int Id { get; set; }
        private string emri_i_ushqimit = "";
        private double cmimi_i_ushqimit = 0;
        public string Madhesia_e_ushqimit { get; set; }

        public string Emri_i_ushqimit {
            get
            {
                return emri_i_ushqimit;
            }
            set
            {
                if (value != "")
                {
                    emri_i_ushqimit = value;
                }
                else
                {
                    MessageBox.Show("Emri i ushqimit eshte gabim!");
                }
            }
        }

        public double Cmimi_i_ushqimit
        {
            get { return cmimi_i_ushqimit; }
            set
            {
                if (value > 0)
                {
                    cmimi_i_ushqimit = value;
                }
                else
                {
                    MessageBox.Show("Cmimi i ushqimit eshte gabim!");
                }
            }
        }


        public List<string> Perberesit { get; set; } = new List<string>();


        public Ushqimi(string emri, string madhesia, double cmimi)
        {
            Emri_i_ushqimit = emri;
            Madhesia_e_ushqimit = madhesia;
            Cmimi_i_ushqimit = cmimi;
        }

        public Ushqimi(string emri, string madhesia, double cmimi, List<string> perberesit)
        {
            Emri_i_ushqimit = emri;
            Madhesia_e_ushqimit = madhesia;
            Cmimi_i_ushqimit = cmimi;
            Perberesit = perberesit;
        }
    }
}
