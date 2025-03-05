using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal class Formules : IMathematique, IPhysique, IGestionTableau
    {
        public double CalculerAireCercle(double rayon)
        {
            double aire = Math.PI * rayon * rayon;
            Console.WriteLine($"Aire du cercle : {aire}");
            return aire;
        }

        // Definition de la methode pour calculer le factorielle
        public double CalculerFactorielle(int nombre)
        {
            int valeur = 1;
            for (int i = 0; i < nombre; i++)
            {
                valeur *= nombre;
            }
            Console.WriteLine($"Factorielle de {nombre} : {valeur}");
            return valeur;
        }

        // Definition de méthodes de Iphysique

        public double CalculerEnergieCinetique(double masse, double vitesse)
        {
            // const double G = -6.67430e-11; //Constance gravitationnelle
            double energie = 0.5 * masse * Math.Pow(vitesse, 2);
            Console.WriteLine($"Energie cinetique : {energie}");
            return energie;
        }

        public double CalculerForceGravitationnelle(double masse1, double masse2, double distance)
        {
            const double G = -6.67430e-11; //Constance gravitationnelle

            double force = G * (masse1 * masse2) / Math.Pow(distance, 2);
            Console.WriteLine($"Force gravitationnelle : {force}N");
            return force;
        }

        // Definitions des méthodes de IGestionTableau

        public void AfficherTableau(double[,] tableau)
        {
            Console.WriteLine($"Voici le tableau : ");
            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    Console.Write(tableau[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public List<double> ConvertirTableauListe(double[,] tableau)
        {
            List<double> result = new List<double>();
            for (int i = 0;i < tableau.GetLength(0);i++)
            {
                for (int j = 0;j < tableau.GetLength(1);j++)
                    result.Add(tableau[i,j]);
            }
            Console.WriteLine("Le tableau est converti en liste");

            foreach (var element in result)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            return result;
        }
        
    }
}
