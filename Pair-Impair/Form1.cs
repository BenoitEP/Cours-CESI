using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pair_Impair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void LB_Result_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nbSaisie = int.Parse(TB_Saisie.Text);
                if (nbSaisie % 2 == 0)
                {
                    LB_Result.Text = "Le nombre saisis est pair";
                    TB_Saisie.Text = "";
                    TB_Saisie.Focus();
                }
                else
                {
                    LB_Result.Text = "Le nombre saisis est impair";
                    TB_Saisie.Text = "";
                    TB_Saisie.Focus();
                }                
            }
            catch
            {
                MessageBox.Show("Veuillez taper un nombre entier.");
                TB_Saisie.Text = "";
                TB_Saisie.Focus();
            }            
        }
    }
}
