using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    interface IVaisseaux
    {
        int CapaciteTotale { get; set; }
        IMateriaux PileMateriaux { get; set; }
        IMateriaux Suivant { get; set; }
        IMateriaux Precedent { get; set; }
    }
}
