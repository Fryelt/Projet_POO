using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Vaisseaux
    {
        protected int capaciteTotale;
        protected Vaisseaux precedent = null;
        protected Pile materiere;

        public Vaisseaux(int _capacite, int Ur, int Ml, int Cf, int Pl, int Tc)
        {
            capaciteTotale = _capacite;
            materiere = new Pile(8);
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
