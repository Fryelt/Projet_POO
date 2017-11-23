using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Vaisseaux
    {
        protected int capaciteTotale;
        protected Vaisseaux precedent = null;

        public Vaisseaux(int _capacite)
        {
            capaciteTotale = _capacite;
        }
        public int CapaciteTotale
        {
            get { return capaciteTotale; }
        }
        public Vaisseaux Precedent
        {
            get { return precedent; }
            set { precedent = value; }
        }
    }
}
