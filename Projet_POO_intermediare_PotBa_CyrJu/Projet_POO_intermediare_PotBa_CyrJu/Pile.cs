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
        public Materiaux Ancre
        {
            get { return ancre; }
        }

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

        public bool AjouterPile(Materiaux objet)  // ajout de materiaux
        {
            int qutRestante;
            Materiaux objetN;
            if (objet.TailleMateriaux == 0) // verifi si la taille du materiaux est de zero 
            {
                return false;
            }
            else if ((capaciteActuelle + objet.TailleMateriaux) <= capaciteMax) // verifi si la quantite actuel de matiere + la nouvelle a ajouter n'escede pas la capaciter maximum
            {
                objetN = objet;
                objetN.Suivant = ancre;
                ancre = objetN;
                capaciteActuelle += objetN.TailleMateriaux;
                nbrMateriaux++;
                return false;
            }
            else  // exes de la capacite donc il calcule le maximum qu'il peu mettre comme matiere
            {
                qutRestante = capaciteMax - capaciteActuelle;
                if (qutRestante != 0)
                {
                    objet.TailleMateriaux -= qutRestante;
                    objetN = objet.Creation(qutRestante);   // cree un nouvelle objet de type materiaux avec la taille demander

                    objetN.Suivant = ancre;    
                    ancre = objetN;
                    capaciteActuelle = capaciteMax;
                    nbrMateriaux++;
                }
                else
                    return false;
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
     
    }
}
