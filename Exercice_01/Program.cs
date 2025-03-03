namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IvehiculePhysique> list = new List<IvehiculePhysique>();

            Voiture voiture1 = new Voiture("Toyota", 4, 1500, 20, 10000);
            Voiture voiture2 = new Voiture("Mazda", 4, 1200, 25, 15000);
            list.Add(voiture1); // Ajout à la collection
            list.Add(voiture2);

            foreach(var Auto in list)
            {
                Auto.Demarrer();
                Auto.AfficherInfo();
                Console.WriteLine($"L'énergie cinétique : {Auto.CalculerEnergieCinetique()} joules");
                Console.WriteLine($"Puissance du moteur : {Auto.CalculerPuissance()} Watts");
                Console.WriteLine($"Accélération pour une force de 1000N {Auto.CalculerAcceleration(1000)}m/s^2");
                Auto.Arreter();
                Console.WriteLine("---------------------");
            }
        }
    }
}
