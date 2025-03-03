using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal interface IvehiculePhysique
    {
        void Demarrer();
        void Arreter();
        void AfficherInfo();
        double CalculerEnergieCinetique();
        double CalculerPuissance();
        double CalculerAcceleration(double force);
    }
}
