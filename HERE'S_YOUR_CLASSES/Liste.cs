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
            Vaisseaux vaisseauT, vaisseauT2;
            Materiaux materielT, materielN;
            int nbrVaisseaux, nbrMateriaux;

            nbrVaisseaux = ancre.Arrive.NbrVaisseaux;
            for (int ind = 0; ind < nbrVaisseaux; ind++)
            {
                vaisseauT = ancre.Arrive.SupprimerFile();
                nbrMateriaux = vaisseauT.PileMateriaux.NbrMateriaux;
                for (int ind2 = 0; ind2 < nbrMateriaux; ind2++)
                {
                    materielT = vaisseauT.PileMateriaux.SupprimerPile();
                    vaisseauT.miseAJourPile(-materielT.TailleMateriaux);
                    switch (materielT.GetType().Name)
                    {
                        case "Plutonium":
                            if (ancre.PilePlutonium.AjouterPile(materielT))
                            {
                                TransfertVaisseauxDepart(ancre.PilePlutonium, new Plutonium(0));
                                ancre.Depart.Queue.AjouterMateriaux(ancre.PilePlutonium.SupprimerPile());
                            }
                            break;
                        case "Uranium":
                            if (ancre.PileUranium.AjouterPile(materielT))
                            {
                                ancre.Depart.Queue.AjouterMateriaux(ancre.PileUranium.SupprimerPile());
                            }
                            break;
                        case "CombustiblesFossiles":
                            if (ancre.PileCombustiblesFossiles.AjouterPile(materielT))
                            {
                                ancre.Depart.Queue.AjouterMateriaux(ancre.PileCombustiblesFossiles.SupprimerPile());
                            }
                            break;
                        case "MetauxLourds":
                            if (ancre.PileMetauxLourds.AjouterPile(materielT))
                            {
                                ancre.Depart.Queue.AjouterMateriaux(ancre.PileMetauxLourds.SupprimerPile());
                            }
                            break;
                        case "TerresContaminees":
                            if (ancre.PileTerresContaminees.AjouterPile(materielT))
                            {
                                ancre.Depart.Queue.AjouterMateriaux(ancre.PileTerresContaminees.SupprimerPile());
                            }
                            break;
                        default:
                            break;
                    }
                    if (ancre.Depart.VerifFileMax())
                    {
                        for (int ind3 = 0; ind3 < ancre.Depart.NbrVaisseaux; ind3++)
                        {
                            vaisseauT2 = ancre.Depart.SupprimerFile();
                            TransfererVaisseauxArriveDepart(vaisseauT2, ancre.Suivant);
                        }
                    }
                }
                    ancre.Depart.AjouterFile(vaisseauT);
            }
        }
        public void TransfertVaisseauxDepart(Pile transfert, Materiaux objetRestant)
        {
            for(int ind = 0; ind < transfert.NbrMateriaux; ind++)
            {
                objetRestant = objetRestant.Creation(ancre.Depart.Queue.AjouterMateriaux(transfert.SupprimerPile()));
                if (ancre.Depart.Queue.CapaciteTotale == ancre.Depart.Queue.Capacite)
                {

                }
            }
        }
        public void AjouterVaisseauxArrive(Vaisseaux vaisseauxN)
        {
            if (ancre.Arrive.VerifFileMax())
            {
                CommencerTraitement();
            }
            ancre.Arrive.AjouterFile(vaisseauxN);
        }
        public void TransfererVaisseauxArriveDepart(Vaisseaux vaisseauxN, CentreTri centreSuivant)
        {

            if (centreSuivant.Arrive.VerifFileMax())
            {
                
                //while (!centreSuivant.Arrive.VerifFileVide())
                //{
                //    if (ancre.Suivant.Arrive.VerifFileMax())
                //    {
                //        TransfererVaisseauxArriveDepart(vaisseauxN, centreSuivant);
                //        break;
                //    }
                //    AjouterVaisseauxArrive(centreSuivant.Depart.SupprimerFile());
                //}
            }
            else
            {
                centreSuivant.Depart.AjouterFile(centreSuivant.Arrive.SupprimerFile());
            }
        }
        public void AjouterCentre(CentreTri nouveau)
        {
            CentreTri actuel;
            actuel = ancre;

            if (actuel == null)
                AjouterDebut(nouveau);
            else
                AjouterFin(nouveau);
        }
        public void AjouterFin(CentreTri nouveau)
        {
            Queu.Suivant = nouveau;
            nouveau.Precedant = Queu;
            Queu = nouveau;
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
