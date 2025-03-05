namespace Exercice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formules formule = new Formules();
            Console.WriteLine("Calcul mathématiques");
            formule.CalculerAireCercle(7);
            formule.CalculerFactorielle(5);

            Console.WriteLine("Calculs Physiques");

            formule.CalculerEnergieCinetique(70, 15);
            formule.CalculerForceGravitationnelle(5.972 * 10e24, 7.342 * 10e22, 384400000 );

            Console.WriteLine("Gestion des tableaux");
            double[] val = { 7, 8.9, 9 };

            double[,] tableau = { { 3.14,45.6}, { 70,105} };

            formule.AfficherTableau(tableau);
            formule.ConvertirTableauListe(tableau);
        }
    }
}
