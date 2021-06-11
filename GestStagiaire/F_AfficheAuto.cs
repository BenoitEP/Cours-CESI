using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiaire
{
    public partial class F_AfficheAuto : Form
    {
        public F_AfficheAuto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_AfficheAuto_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stagiaireDataSet.TStagiaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tStagiaireTableAdapter.Fill(this.stagiaireDataSet.TStagiaire);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
