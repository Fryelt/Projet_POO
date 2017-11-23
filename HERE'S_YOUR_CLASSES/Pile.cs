using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Pile
    {

        protected Materiaux ancre;
        protected int capaciteMax, capaciteActuelle;

        public Pile(int tailleMaxP)
        {
            capaciteMax = tailleMaxP;
            capaciteActuelle = 0;
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

        public void AjouterPile(Materiaux objet)
        {
            int qutRestante;
            Materiaux objetN;
            while (objet.TailleMateriaux != 0)
            {
                if ((capaciteActuelle + objet.TailleMateriaux) <= capaciteMax)
                {
                    objet.Suivant = ancre;
                    ancre = objet;
                    capaciteActuelle += objet.TailleMateriaux;
                    objet.TailleMateriaux = 0;
                }
                else
                {
                    qutRestante = capaciteMax - capaciteActuelle;
                    objet.TailleMateriaux -= qutRestante;
                    objetN = objet.Creation(qutRestante);

                    objetN.Suivant = ancre;
                    ancre = objetN;
                    capaciteActuelle = capaciteMax;
                    //VIDER
                }
            }
        }
        public void SupprimerPile()
        {
            if (VerifPileVide())
            {
                capaciteActuelle =- ancre.TailleMateriaux;
                ancre = ancre.Suivant;
            }
            else
            {
                //TO THINK ABOUT
            }
        }
    }
}
