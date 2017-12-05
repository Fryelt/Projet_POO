using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Pile
    {

        private Materiaux ancre;
        private int capaciteMax, capaciteActuelle, nbrMateriaux;

        public Pile(int tailleMaxP)
        {
            capaciteMax = tailleMaxP;
            capaciteActuelle = 0;
            nbrMateriaux = 0;
            ancre = null;
        }
        public bool VerifPileMax()
        {
            if (capaciteMax == capaciteActuelle)
                return true;
            return false;
        }
        public bool VerifPileVide()
        {
            if (ancre != null)
                return false;
            return true;
        }

        public bool AjouterPile(Materiaux objet)
        {
            int qutRestante;
            Materiaux objetN;
            if (objet.TailleMateriaux == 0)
            {
                return false;
            }
            else if ((capaciteActuelle + objet.TailleMateriaux) <= capaciteMax)
            {
                objetN = objet;
                objetN.Suivant = ancre;
                ancre = objetN;
                capaciteActuelle += objetN.TailleMateriaux;
                nbrMateriaux++;
                return false;
            }
            else
            {
                qutRestante = capaciteMax - capaciteActuelle;
                objet.TailleMateriaux -= qutRestante;
                objetN = objet.Creation(qutRestante);

                objetN.Suivant = ancre;
                ancre = objetN;
                capaciteActuelle = capaciteMax;
                nbrMateriaux++;
                return true;
            }
        }
        public Materiaux SupprimerPile()
        {
            Materiaux materiel = null;
            if (!VerifPileVide())
            {
                materiel = ancre.Creation(ancre.TailleMateriaux);
                capaciteActuelle -= ancre.TailleMateriaux;
                ancre = ancre.Suivant;
                nbrMateriaux--;
            }
            return materiel; 
        }
        public int NbrMateriaux
        {
            get { return nbrMateriaux; }
        }
        public int CapaciteActuelle
        {
            get { return capaciteActuelle; }
        }
        public int CapaciteMax
        {
            get { return capaciteMax; }
        }
    }
}
