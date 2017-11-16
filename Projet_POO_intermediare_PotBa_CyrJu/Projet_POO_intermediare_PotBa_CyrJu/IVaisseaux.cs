using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    interface IVaisseaux
    {
        int capaciteTotale { get; set; }
        IMateriaux pileMateriaux { get; set; }
        IMateriaux suivant { get; set; }
        IMateriaux precedent { get; set; }
    }
}
