using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette3chiffres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if ((TB_A.Text == "")||(TB_B.Text=="")||(TB_C.Text==""))
            {
                CMD_Calculate.Enabled = false;
            }
            else
            {
                CMD_Calculate.Enabled = true;
            }
        }

        private void CMD_Exit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void CMD_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //def number max
                // if nb a > b and c then A else if b>c B else c

                if (int.Parse(TB_A.Text) > int.Parse(TB_B.Text) && int.Parse(TB_A.Text) > int.Parse(TB_C.Text))
                {
                    LB_Max.Text = "Le nombre max est " + TB_A.Text;
                }
                else if (int.Parse(TB_B.Text) > int.Parse(TB_C.Text))
                {
                    LB_Max.Text = "Le nombre max est " + TB_B.Text;
                }
                else
                {
                    LB_Max.Text = "Le nombre max est " + TB_C.Text;
                }

                //def number min
                // if nb a<b and c then A else if b<c B else C
                if (int.Parse(TB_A.Text) < int.Parse(TB_B.Text) && int.Parse(TB_A.Text) < int.Parse(TB_C.Text))
                {
                    LB_Min.Text = "Le nombre min est " + TB_A.Text;
                }
                else if (int.Parse(TB_B.Text) < int.Parse(TB_C.Text))
                {
                    LB_Min.Text = "Le nombre min est " + TB_B.Text;
                }
                else
                {
                    LB_Min.Text = "Le nombre min est " + TB_C.Text;
                }

                //def sum
                int sum = (int.Parse(TB_A.Text) + int.Parse(TB_B.Text) + int.Parse(TB_C.Text));
                LB_Sum.Text = "La somme des trois nombre est " + Convert.ToString(sum);

                //def avg
                int avg = (int.Parse(TB_A.Text) + int.Parse(TB_B.Text) + int.Parse(TB_C.Text)) / 3;
                LB_Avg.Text = "La moyenne des trois nombres est " + Convert.ToString(avg);

                //def pdt
                int prd = (int.Parse(TB_A.Text) * int.Parse(TB_B.Text) * int.Parse(TB_C.Text));
                LB_Prd.Text = "Le produit des trois nombres est " + Convert.ToString(prd);

                TB_A.Text = "";
                TB_B.Text = "";
                TB_C.Text = "";
                TB_A.Focus();
            }
            //error message
            catch
            {
                MessageBox.Show( "Veuillez taper 3 nombres entiers.") ;
                TB_A.Text = "";
                TB_B.Text = "";
                TB_C.Text = "";
                TB_A.Focus();
            }
        }
    }
}
