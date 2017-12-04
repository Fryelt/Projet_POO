using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Vaisseaux
    {
        protected int capaciteTotale, capacite;
        protected Pile pileMateriaux;
        protected Vaisseaux precedent = null;

        public Vaisseaux(int _capacite)
        {
            capaciteTotale = _capacite;
            pileMateriaux = new Pile(capaciteTotale);
        }
        public void miseAJourPile(int modif)
        {
            capacite += modif;
        }
        public int CapaciteTotale
        {
            get { return capaciteTotale; }
        }
        public int Capacite
        {
            get { return capacite; }
            set { capacite = value; }
        }

        public int AjouterMateriaux(Materiaux ajoutM)
        {
            int qutRestante = 0;
            pileMateriaux.AjouterPile(ajoutM);
            if ((ajoutM.TailleMateriaux + capacite) <= capaciteTotale)
                capacite += ajoutM.TailleMateriaux;
            else
            {
                qutRestante = ajoutM.TailleMateriaux;
                capaciteTotale = capacite;
            }
            return qutRestante;
        }

        public Vaisseaux Precedent
        {
            get { return precedent; }
            set { precedent = value; }
        }
        public Pile PileMateriaux
        {
            get { return pileMateriaux; }
            set { pileMateriaux = value; }
        }
    }
}