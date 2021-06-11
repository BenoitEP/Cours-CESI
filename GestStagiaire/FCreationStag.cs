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
    public partial class FCreationStag : Form
    {
        public FCreationStag()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdValid_Click(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source = localhost;Initial Catalog=Stagiaire;Integrated Security=SSPI";
            //string chaineDeConnexion = "Data Source = localhost;Initial Catalog=Stagiaire;userID=xxx;Pwd=1234";
            try
            {
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                MessageBox.Show("Ma connexion Ouverte");

                //Insertion des données avec une requete préparée (ou paramétrée)
                SqlCommand maCommande = MaConnexion.CreateCommand();
                // requete paramétrée
                maCommande.CommandText = "INSERT INTO TStagiaire(id_Stagiaire,NomStag,PrenomStag,Section,DateNaissance)" +
                    " VALUES(@Id,@nom,@prenom,@section,@dateNaissance)";

                // binding parameter
                // parameter @id
                SqlParameter paramId = new SqlParameter("@Id", TxtId.Text);
                paramId.Direction = ParameterDirection.Input;
                paramId.DbType = DbType.Int32;

                // parameter @nom
                SqlParameter paramNom = new SqlParameter("@nom", TxtNom.Text);
                paramNom.Direction = ParameterDirection.Input;
                paramNom.DbType = DbType.String;
                paramNom.Size = 30;

                // parameter prenom
                SqlParameter paramPrenom = new SqlParameter("@prenom", TxtPrenom.Text);
                paramPrenom.Direction = ParameterDirection.Input;
                paramPrenom.DbType = DbType.String;
                paramPrenom.Size = 20;

                // parameter section
                SqlParameter paramSection = new SqlParameter("@section", TxtSection.Text);
                paramSection.Direction = ParameterDirection.Input;
                paramSection.DbType = DbType.String;
                paramSection.Size = 5;

                // parameter date
                DateTime maDate = Convert.ToDateTime(DTPNaissance.Value);
                SqlParameter paramDate = new SqlParameter("@dateNaissance", maDate);
                paramDate.Direction = ParameterDirection.Input;
                paramDate.DbType = DbType.DateTime;

                //envoyer les parametres dans la requete
                maCommande.Parameters.Add(paramId);
                maCommande.Parameters.Add(paramNom);
                maCommande.Parameters.Add(paramPrenom);
                maCommande.Parameters.Add(paramSection);
                maCommande.Parameters.Add(paramDate);

                //execution de la requete paramétrée
                maCommande.ExecuteNonQuery();
                //fermeture connexion sql server
                MaConnexion.Close();

                TxtId.Text = "";
                TxtNom.Text = "";
                TxtPrenom.Text = "";
                TxtSection.Text = "";
            }
            catch(Exception d)
            {
                MessageBox.Show("Erreur rencontrée : " + d.Message);
            }
        }
    }
}
