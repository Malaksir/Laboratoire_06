﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal interface IGestionTableau
    {
        void AfficherTableau(double[,] tableau);

        List<double> ConvertirTableauListe(double[,] tableau);
    }
}
