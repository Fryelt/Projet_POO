using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Liste
    {
        private CentreTri ancre = null;
        private CentreTri Queu = null;
        private int cpt_noeud = 0;

        public void CommencerTraitement()
        {

        }
        public void AjouterVaisseauxArrive(Vaisseaux vaisseauxN, CentreTri centreActuel, CentreTri centreNouveau)
        {
            if (centreNouveau.Arrive.VerifFileMax())
            {
                CommencerTraitement();
            }
            centreNouveau.Arrive.AjouterFile(vaisseauxN);
        }
        public void TransfererVaisseauxArriveDepart(Vaisseaux vaisseauxN, CentreTri centreActuel, CentreTri centreSuivant)
        {

            if (centreActuel.Depart.VerifFileMax())
            {
                while (!centreActuel.Depart.VerifFileVide())
                {
                    if (ancre.Suivant.Arrive.VerifFileMax())
                    {
                        TransfererVaisseauxArriveDepart(vaisseauxN, centreActuel, centreSuivant);
                        break;
                    }
                    AjouterVaisseauxArrive(centreSuivant.Depart.SupprimerFile(), centreActuel, centreSuivant);
                }
            }
            else
            {
                centreActuel.Depart.AjouterFile(centreSuivant.Arrive.SupprimerFile());
            }
        }
        public void AjouterCentre(CentreTri nouveau)
        {
            CentreTri actuel;
            CentreTri temp = null;
            actuel = ancre;

            if (actuel == null)
            {

                AjouterDebut(nouveau);
            }
            else
            {
                while (actuel != null)
                {

                    if (ancre == actuel)
                    {

                        AjouterDebut(nouveau);
                        break;
                    }
                    else
                    {
                        nouveau.Suivant = actuel;
                        nouveau.Precedant = actuel.Precedant;
                        actuel.Precedant = nouveau;
                        temp.Suivant = nouveau;
                        cpt_noeud++;
                        break;
                    }
                }
            }
        }
        public void AjouterFin(CentreTri nouveau)
        {
            Queu.Suivant = nouveau;
            nouveau.Precedant = Queu;
            Queu = nouveau;
            if (cpt_noeud == 0)
            {
                ancre = nouveau;
            }
            cpt_noeud++;
        }
        public void AjouterDebut(CentreTri nouveau)
        {
            nouveau.Suivant = ancre;
            ancre = nouveau;
            if (cpt_noeud == 0)
            {
                Queu = ancre;
            }
            cpt_noeud++;
        }
    }
}
