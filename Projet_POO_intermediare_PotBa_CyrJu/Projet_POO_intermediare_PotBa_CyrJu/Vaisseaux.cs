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
        protected Vaisseaux prochain = null;
        public Vaisseaux Prochain
        {
            get { return prochain; }
            set { prochain = value; }
        }
        public Pile PileMateriaux
        {
            get { return pileMateriaux; }
            set { pileMateriaux = value; }
        }

        public Vaisseaux(int _capacite)
        {
            capaciteTotale = _capacite;
            pileMateriaux = new Pile(capaciteTotale);
        }
        public Vaisseaux(int _capaciteTotale, int _capacite, Pile _pileMateriaux)
        {
            capaciteTotale = _capaciteTotale;
            capacite = _capacite;
            pileMateriaux = _pileMateriaux;
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
            if (pileMateriaux.AjouterPile(ajoutM))
            {
                qutRestante = ajoutM.TailleMateriaux;
            }
            capacite = PileMateriaux.CapaciteActuelle;
            return qutRestante;
        }

       
    }
}