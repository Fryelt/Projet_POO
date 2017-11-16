using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Cargo : Vaisseaux
    {
        public Cargo(Plutonium _pilePlutonium, Uranium _pileUranium, MetauxLourds _pileMetauxLourds, TerresContaminees _pileTerresContaminees, CombustiblesFossiles _pileCombustiblesFossiles, int _quantiteTotale = 367) : base (_quantiteTotale)
        {

        }
    }
}
