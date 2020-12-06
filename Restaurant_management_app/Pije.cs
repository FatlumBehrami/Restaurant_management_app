﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_management_app
{
    class Pije
    {
        public int Id { get; set; }
        private string emri_i_pijes = "";
        private double cmimi_i_pijes = 0.0;


        public string Emri_i_pijes
        {
            get
            {
                return emri_i_pijes;
            }
            set
            {
                if (value != "")
                {
                    emri_i_pijes = value;
                }
                else
                {
                    MessageBox.Show("Emri i pijes eshte gabim!");
                }
            }
        }

        public double Cmimi_i_pijes
        {
            get { return cmimi_i_pijes; }
            set
            {
                if (value > 0)
                {
                    cmimi_i_pijes = value;
                }
                else
                {
                    MessageBox.Show("Cmimi i pijes eshte gabim!..");
                }
            }
        }

        public Pije(string emri, double cmimi)
        {
            Emri_i_pijes = emri;
            Cmimi_i_pijes = cmimi;
        }
    }
}
