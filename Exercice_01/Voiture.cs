using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Voiture:IvehiculePhysique
    {
        public string Marques {get; set;}

        public int NombrePorte {get; set;}
        public double Masse { get; set;}
        public double Vitesse { get; set;}
        public double PuissanceMoteur { get; set;}

        public Voiture(string marques, int nombrePorte, double masse, double vitesse, double puissanceMoteur)
        {
            Marques = marques;
            NombrePorte = nombrePorte;
            Masse = masse;
            Vitesse = vitesse;
            PuissanceMoteur = puissanceMoteur;
        }

        public void Demarrer()
        {
            Console.WriteLine($"La voiture {Marques} démarre");
        }

        public void Arreter() => Console.WriteLine($"La voiture {Marques} s'arrête");

        public void AfficherInfo() => Console.WriteLine($"Voiture : {Marques}, Portes : {NombrePorte}, Masse : {Masse} kg, vitesse : {Vitesse} m/s, puissance : {PuissanceMoteur}");

        public double CalculerEnergieCinetique()=>0.4*Masse*Math.Pow(Vitesse,2);

        public double CalculerPuissance() => PuissanceMoteur;
        public double CalculerAcceleration(double force) => force / Masse;
    }
}
