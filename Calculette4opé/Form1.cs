using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Calculette4opé
{
    public partial class Form1 : Form
    {
        // var declaration
        string saisie;
        double num1 = 0;
        double num2;
        double subRes;
        string saisieCom;
        char op;
        char opMem;

        //-----------------------------------------------------------
        //methods
        public string chiffreClic(string e) //clic on numbers
        {
            if (LB_View.Text == "0")
            {
                LB_View.Text = "";
            }
            else if (LB_ViewAll.Text == "0")
            {
                LB_ViewAll.Text = "";
            }
            saisie += e;
            saisieCom += e;
            LB_View.Text = saisie;
            LB_ViewAll.Text = saisieCom;
            CMD_Result.Focus();
            return saisie;
        }
        public void del()
        {
            LB_View.Text = "0";
            saisie = "";
            num1 = 0;
            num2 = 0;
            subRes = 0;
            saisieCom = "";
            LB_ViewAll.Text = "0";            
        }
        public char operateur(char d) // clic on operators
        {
            try
            {
                if (num1 == 0) // for the first opertation
                {
                    num1 = double.Parse(saisie);
                    op = d;
                    opMem = d;
                    saisie = "";
                    saisieCom += d;
                    LB_View.Text = Convert.ToString(num1);
                    LB_ViewAll.Text += d;

                    return op;
                }
                else // if not first operation
                {
                    op = d;
                    switch (opMem) // case on previous operator
                    {
                        case ('+'):
                            num1 += double.Parse(saisie);
                            opMem = d;
                            saisie = "";
                            saisieCom += d;
                            LB_View.Text = Convert.ToString(num1);
                            LB_ViewAll.Text += d;
                            break;
                        case ('-'):
                            num1 -= double.Parse(saisie);
                            opMem = d;
                            saisie = "";
                            saisieCom += d;
                            LB_View.Text = Convert.ToString(num1);
                            LB_ViewAll.Text += d;
                            break;
                        case ('x'):
                            num1 *= double.Parse(saisie);
                            opMem = d;
                            saisie = "";
                            saisieCom += d;
                            LB_View.Text = Convert.ToString(num1);
                            LB_ViewAll.Text += d;
                            break;
                        case ('/'):
                            num1 /= double.Parse(saisie);
                            opMem = d;
                            saisie = "";
                            saisieCom += d;
                            LB_View.Text = Convert.ToString(num1);
                            LB_ViewAll.Text += d;
                            break;
                    }
                    return op;
                }
            }
            catch
            {
                return op;
            }
        }
        public char result(char op) //clic on =
        {
            try
            {
                switch (op) // case on last operator
                {

                    case '+':
                        num2 = double.Parse(saisie);
                        subRes = num1 + num2;
                        LB_ViewAll.Text += "=" + Convert.ToString(subRes); ;
                        LB_View.Text = Convert.ToString(subRes);
                        break;

                    case '-':
                        num2 = double.Parse(saisie);
                        subRes = num1 - num2;
                        LB_ViewAll.Text += "=" + Convert.ToString(subRes); ;
                        LB_View.Text = Convert.ToString(subRes);
                        break;

                    case 'x':
                        num2 = double.Parse(saisie);
                        subRes = num1 * num2;
                        LB_ViewAll.Text += "=" + Convert.ToString(subRes); ;
                        LB_View.Text = Convert.ToString(subRes);
                        break;

                    case '/':
                        num2 = double.Parse(saisie);
                        subRes = num1 / num2;
                        LB_ViewAll.Text += "=" + Convert.ToString(subRes);
                        LB_View.Text = Convert.ToString(subRes);
                        break;
                }
                return op;
            }
            catch 
            {
                return op;
            }
        }
        //-----------------------------------------------------------------------------------
        // clic actions
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void CMD_0_Click_1(object sender, EventArgs e)
        {
            chiffreClic("0");
        }

        private void CMD_1_Click_1(object sender, EventArgs e)
        {
            chiffreClic("1");
        }

        private void CMD_2_Click_1(object sender, EventArgs e)
        {
            chiffreClic("2");
        }

        private void CMD_3_Click_1(object sender, EventArgs e)
        {
            chiffreClic("3");
        }

        private void CMD_4_Click_1(object sender, EventArgs e)
        {
            chiffreClic("4");
        }

        private void CMD_5_Click_1(object sender, EventArgs e)
        {
            chiffreClic("5");
        }

        private void CMD_6_Click_1(object sender, EventArgs e)
        {
            chiffreClic("6");
        }

        private void CMD_7_Click_1(object sender, EventArgs e)
        {
            chiffreClic("7");
        }

        private void CMD_8_Click_1(object sender, EventArgs e)
        {
            chiffreClic("8");
        }

        private void CMD_9_Click_1(object sender, EventArgs e)
        {
            chiffreClic("9");
        }
        private void CMD_Com_Click(object sender, EventArgs e)
        {
            chiffreClic(",");
        }

        private void CMD_Del_Click_1(object sender, EventArgs e)
        {
            del();
        }

        private void CMD_Add_Click_1(object sender, EventArgs e)
        {
            operateur('+');
        }

        private void CMD_Sub_Click_1(object sender, EventArgs e)
        {
            operateur('-');
        }

        private void CMD_Mul_Click_1(object sender, EventArgs e)
        {
            operateur('x');
        }

        private void CMD_Div_Click_1(object sender, EventArgs e)
        {
            operateur('/');
        }

        private void CMD_Result_Click_1(object sender, EventArgs e)
        {
            result(op);
        }

        //--------------------------------------------------------------
        //Keyboard input        
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //marche pas non plus
            //https://social.msdn.microsoft.com/Forums/fr-FR/6d6b63fb-b7a4-4f03-bf66-2308f0c4832b/valider-touche-entrer?forum=netdevelopmentfr solution focus
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("entrée");
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    CMD_0.PerformClick();
                    //chiffreClic("1");
                    break;
                case Keys.NumPad1:
                    CMD_1.PerformClick();
                    break;
                case Keys.NumPad2:
                    CMD_2.PerformClick();
                    break;
                case Keys.NumPad3:
                    CMD_3.PerformClick();
                    break;
                case Keys.NumPad4:
                    CMD_4.PerformClick();
                    break;
                case Keys.NumPad5:
                    CMD_5.PerformClick();
                    break;
                case Keys.NumPad6:
                    CMD_6.PerformClick();
                    break;
                case Keys.NumPad7:
                    CMD_7.PerformClick();
                    break;
                case Keys.NumPad8:
                    CMD_8.PerformClick();
                    break;
                case Keys.NumPad9:
                    CMD_9.PerformClick();
                    break;
                case Keys.Decimal:
                    CMD_Com.PerformClick();
                    break;
                case Keys.Add:
                    CMD_Add.PerformClick();
                    //operateur('+');
                    break;
                case Keys.Multiply:
                    CMD_Mul.PerformClick();
                    break;
                case Keys.Divide:
                    CMD_Div.PerformClick();
                    break;
                case Keys.Subtract:
                    CMD_Sub.PerformClick();
                    break;
                case Keys.Back:
                    CMD_Del.PerformClick();
                    break;
                /*case Keys.Enter:
                    MessageBox.Show("Entrée pressé");
                    CMD_Result.PerformClick();
                    //result(op);
                    break;*/
                case Keys.Return:
                    CMD_Result.PerformClick();
                    break;
                case Keys.A:
                   // MessageBox.Show("a pressé");
                    CMD_Result.PerformClick();
                    break;
            }
            e.Handled = true;
        }
    }
}