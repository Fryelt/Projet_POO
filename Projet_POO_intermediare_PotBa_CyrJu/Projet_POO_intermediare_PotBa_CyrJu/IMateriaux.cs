using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    interface IMateriaux
    {
        int tempsChargement { get; set; }
        string nomMateriaux { get; set; }
        IMateriaux suivant { get; set; }
    }
}
