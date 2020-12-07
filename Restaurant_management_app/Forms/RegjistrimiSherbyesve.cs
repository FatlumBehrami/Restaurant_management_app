using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    public partial class RegjistrimiSherbyesve : Form
    {
        public RegjistrimiSherbyesve()
        {
            InitializeComponent();
        }
        
        

        private void btnRegjistro_Click(object sender, EventArgs e)
        {

            Sherbyesi sherbyesi = new Sherbyesi();
            sherbyesi.Emri = txbEmri.Text;
            sherbyesi.ID++;
            ListaESherbysve.ListaSherbysve.Add(sherbyesi);
        }
    }
}
