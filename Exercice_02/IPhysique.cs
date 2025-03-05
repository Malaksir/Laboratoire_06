using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal interface IPhysique
    {
        double CalculerEnergieCinetique(double masse, double vitesse);

        double CalculerForceGravitationnelle(double masse, double masse2, double distance);
    }
}
