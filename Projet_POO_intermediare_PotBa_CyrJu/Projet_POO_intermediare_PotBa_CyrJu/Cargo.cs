using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{

    class Cargo : IVaisseaux
    {
        protected int capaciteTotale;
        protected IMateriaux pileMateriaux;
        protected IMateriaux suivant;
        protected IMateriaux precedent;
        public Cargo()
        {
            capaciteTotale = 367;
        }

        public int CapaciteTotale
        {
            get { return capaciteTotale; }
            set { capaciteTotale = value; }
        }
        public IMateriaux PileMateriaux
        {
            get { return pileMateriaux; }
            set { pileMateriaux = value; }
        }
        public IMateriaux Suivant
        {
            get { return suivant; }
            set { suivant = value; }
        }
        public IMateriaux Precedent
        {
            get { return precedent; }
            set { precedent = value; }
        }
    }
}
