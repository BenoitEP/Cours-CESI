using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiaire
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source = localhost;Initial Catalog=Stagiaire;Integrated Security=SSPI";
            try
            {
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                //MessageBox.Show("Chargement stagiaire");
                SqlCommand MaCommande = new SqlCommand();
                string SqlQuery = "SELECT Count (NomStag) as NbStag FROM TStagiaire";

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();

                TSL_NbStag.Text = "Nombre de stagiaire dans la base : " + reader["NbStag"];
            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée : " + d.Message);
            }
        }

        private void gestionStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCreationStag creaStag = new FCreationStag();
            creaStag.ShowDialog();
        }

        private void ficheStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Choix fChoix = new F_Choix();
            fChoix.Show();
        }

        private void listeStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AfficheAuto fAffiche = new F_AfficheAuto();
            fAffiche.ShowDialog();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
