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
        private string _emri_i_ushqimit = "";
        private double _cmimi_i_ushqimit = 0;
        public string Madhesia_e_ushqimit { get; set; }

        public string Emri_i_ushqimit {
            get
            {
                return _emri_i_ushqimit;
            }
            set
            {
                if (value != "" || value is string)
                {
                    _emri_i_ushqimit = value;
                }
                else
                {
                    MessageBox.Show("Emri i ushqimit eshte gabim!..");
                }
            }
        }

        public double Cmimi_i_ushqimit
        {
            get { return _cmimi_i_ushqimit; }
            set
            {
                if (value > 0)
                {
                    _cmimi_i_ushqimit = value;
                }
                else
                {
                    MessageBox.Show("Cmimi i ushqimit eshte gabim!..");
                }
            }
        }


        public List<string> Perberesit { get; set; } = new List<string>();

        public Ushqimi(string emri, double cmimi)
        {
            Emri_i_ushqimit = emri;
            Cmimi_i_ushqimit = cmimi;
        }

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
