using System;

namespace ExerciceVehicule
{
    class Program
    {
        // Classe mère Vehicule
        public class Vehicule
        {
            //Propriétés
            protected string couleur;
            protected int poids;
            // Constructeur
            public Vehicule(string couleurVehicule="noir", int poidsVehicule=500)
            {
                couleur = couleurVehicule;
                poids = poidsVehicule;
            }
            //Accesseur
            public string Couleur
            {
                get { return couleur; }
                set { couleur = value; }
            }
            public int Poids
            {
                get { return poids; }
                set { poids = value; }
            }
            // Méthodes
            public void Rouler (int km)
            {
                Console.WriteLine("Le vehicule roule pendant : " + km + " km.");
            }
            public void AjouterPersonne (int poidsPersonne=0)
            {
                poids += poidsPersonne;
            }
        }

        // Classe fille 4 roues
        public class QuatreRoues : Vehicule
        {
            // propriétés
            protected int nombrePorte;
            // constructeur
            public QuatreRoues(string couleur, int poids, int NombrePorte=5) : base(couleur, poids)
            {
                nombrePorte = NombrePorte;
            }
            // accesseur
            public int NombrePorte
            {
                get { return nombrePorte; }
                set { nombrePorte = value; }
            }
            // methode
            public void Repeindre (string nouvelleCouleur="violet")
            {
                couleur = nouvelleCouleur;
            }
        }    

        // Classe fille 2 roues
        public class DeuxRoues : Vehicule
        {
            // propriétés
            protected int cylindree;
            // constructeur
            public DeuxRoues(string couleur, int poids, int Cylindree=2) : base (couleur, poids)
            {
                cylindree = Cylindree;
            }
            // accesseur
            public int Cylindree
            {
                get { return cylindree; }
                set { cylindree = value; }
            }
            // methode
            public void MettreEscence (int litre=0)
            {
                poids += litre;
            }
        }

        // Classe fille voiture (vehicule-4 roues)
        public class Voiture : QuatreRoues
        {
            // Propriétés
            private int nombrePneuNeige;
            // constructeur
            public Voiture(string couleur, int poids, int nombrePorte, int NombrePneuNeige=0) : base(couleur, poids, nombrePorte)
            {
                nombrePneuNeige = NombrePneuNeige;
            }
            // accesseur
            public int NombrePneuNeige

            {
                get { return nombrePneuNeige; }
                set { nombrePneuNeige = value; }
            }
            // methodes
            public void AjouterPneuNeige (int AjoutPneuNeige)
            {
                NombrePneuNeige += AjoutPneuNeige;
                if (nombrePneuNeige > 4)
                {
                    nombrePneuNeige = 4;
                    Console.WriteLine("On va mettre 4 pneus, ça devrait suffire !");
                }
            }
            public void EnleverPneuNeige (int RetraitPneuNeige)
            {
                NombrePneuNeige -= RetraitPneuNeige;
                if (nombrePneuNeige < 0)
                {
                    nombrePneuNeige = 0;
                    Console.WriteLine("Ben là y'a vraiment plus de pneus à enlever...");
                }
            }
        }

        // Classe fille camion (vehicule - 4 roues)
        public class Camion : QuatreRoues
        {
            // propriétés
            private int longueur;
            // constructeur
            public Camion(string couleur, int poids, int nombrePorte, int Longueur=20) : base (couleur, poids, nombrePorte)
            {
                longueur = Longueur;
            }
            // accesseur
            public int Longueur
            {
                get { return longueur; }
                set { longueur = value; }
            }
            // methodes
            public void AjouterRemorque (int longueurRemorque=2)
            {
                longueur += longueurRemorque;
            }
        }
        static void Main(string[] args)
        {
            //Créer un objet créant un véhicule noir de 1500 kg. Le faire rouler.
            Vehicule vehicule1;
            vehicule1 = new Vehicule("noir",1500);
            Console.WriteLine("La couleur du vehicule 1 est : " + vehicule1.Couleur + ".");
            Console.WriteLine("Le poids du vehicule 1 est : " + vehicule1.Poids + ".");
            //Ajouter une personne de 70 kg et afficher le nouveau poids du véhicule dans la console.
            vehicule1.AjouterPersonne(70);
            Console.WriteLine("Le poids du vehicule 1 avec une personne de 70kg est : " + vehicule1.Poids + ".");

            //Créer une voiture verte de 1400 kg. Ajouter deux personnes de 65 kg chacune.
            Voiture vehicule2;
            vehicule2 = new Voiture("vert", 1400, 5, 0);
            vehicule2.AjouterPersonne(65);
            vehicule2.AjouterPersonne(65);
            //Afficher dans la console sa couleur et son nouveau poids.
            Console.WriteLine("Le vehicule 2 est de couleur " + vehicule2.Couleur + ".");
            Console.WriteLine("Le poids du vehicule 2 avec 2 personnes de 65kg est : " + vehicule2.Poids + ".");
            //Repeindre la voiture en rouge et ajouter deux pneus neige.
            vehicule2.Repeindre("rouge");
            vehicule2.AjouterPneuNeige(2);
            //Afficher dans la console sa couleur et son nombre de pneus neige.
            Console.WriteLine("La voiture a été repeinte en : " + vehicule2.Couleur + ".");            
            Console.WriteLine("La voiture a maintenant : " + vehicule2.NombrePneuNeige + " pneus neige.");

            //Créer un objet Deux_roues noir de 120 kg. Ajouter une personne de 80 kg. Mettre 20 litres d’essence.
            DeuxRoues vehicule3;
            vehicule3 = new DeuxRoues("noir", 120, 0);
            vehicule3.AjouterPersonne(80);
            vehicule3.MettreEscence(20);
            //Afficher dans la console la couleur et le poids du deux roues.
            Console.WriteLine("La couleur du vehicule 3 est " + vehicule3.Couleur + ".");
            Console.WriteLine("Le poids du vehicule 3 est " + vehicule3.Poids + " kg.");
            
            //Créer un camion bleu de 10000 kg d’une longueur de 10 mètres avec 2 portes.Lui ajouter une remorque de 5 mètres et une personne de 80 kg.
            Camion vehicule4;
            vehicule4 = new Camion("bleu", 10000, 2, 10);
            vehicule4.AjouterRemorque(5);
            vehicule4.AjouterPersonne(80);
            //Afficher dans la console sa couleur, son poids, sa longueur et son nombre de portes.
            Console.WriteLine("La couleur du vehicule 4 est " + vehicule4.Couleur + ".");
            Console.WriteLine("Le poids du vehicule 4 est " + vehicule4.Poids + " kg.");
            Console.WriteLine("La longueur du vehicule 4 est " + vehicule4.Longueur + "m.");
            Console.WriteLine("Le nombre de porte du vehicule 4 est " + vehicule4.NombrePorte + ".");
        }
    }
}
