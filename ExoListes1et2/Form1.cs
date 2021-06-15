using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoListes1et2
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();           
        }

        private void CMD_Add_Click(object sender, EventArgs e)
        {
            //add text to list
            listBox1.Items.Add(TXT_Saisie.Text);
            //empty text box
            TXT_Saisie.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttons activation
            
            if (listBox1.Items != null)
            {
                CMD_Switch1to2.Enabled = true;
                CMD_Del1.Enabled = true;
            }
            else
            {
                CMD_Switch1to2.Enabled = false;
                CMD_Del1.Enabled = false;
            }
        }

        private void CMD_Switch1to2_Click(object sender, EventArgs e)
        {
            try
            {            
                //switch button 1 to 2
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                //disable button
                CMD_Switch1to2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un item");
            }
        }

        private void CMD_Switch2to1_Click(object sender, EventArgs e)
        {
            try
            {
                //switch button 2 to 1
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                //disable button
                CMD_Switch2to1.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Veuillez selectionner un item.");
            }
        }

        private void CMD_Del1_Click(object sender, EventArgs e)
        {
            //del button
            listBox1.Items.Clear();
            CMD_Del1.Enabled = false;

        }

        private void CMD_Del2_Click(object sender, EventArgs e)
        {
            //del button
            listBox2.Items.Clear();
            CMD_Del2.Enabled = false;
        }

        private void TXT_Saisie_TextChanged(object sender, EventArgs e)
        {
            //add button activation
            if (TXT_Saisie.Text != "")
            {
                CMD_Add.Enabled = true;                
            }
            else
            {
                CMD_Add.Enabled = false;                
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttons activation
            if (listBox2.Items == null)
            {
                CMD_Switch2to1.Enabled = false;
                CMD_Del2.Enabled = false;
            }
            else
            {
                CMD_Switch2to1.Enabled = true;
                CMD_Del2.Enabled = true;
            }
        }
    }
}

