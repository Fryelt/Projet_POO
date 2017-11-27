using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class CentreTri
    {
        private char Categ;
        CentreTri ancre = null;
        CentreTri Queu = null;
        int cpt_noeud = 0;
        private CentreTri Suivant;
        private CentreTri Precedant;
        private Pile Pl;
        private Pile U;
        private Pile TC;
        private Pile CB;
        private Pile ML;
        private File Depart;
        private File Arrive;


        CentreTri(int numerocentre)
        {
            if (numerocentre % 2 >= 0)
            {
                Categ = 'P';
                Pl = new Pile(1003);
                U = new Pile(857);
                ML = new Pile(3456);
                CB = new Pile(639);
                TC = new Pile(457);
                Depart = new File(30);
                Arrive = new File(30);
            }
            else
            {
                Categ = 'I';
                Pl = new Pile(3067);
                U = new Pile(2456);
                ML = new Pile(561);
                CB = new Pile(8234);
                TC = new Pile(2658);
                Depart = new File(45);
                Arrive = new File(45);
            }
        }

        public void CommencerTraitement()
        {

        }
        public void AjouterVaisseauxArrive(Vaisseaux vaisseaux)
        {
            if (Arrive.VerifFileMax())
            {
                CommencerTraitement();
            }
            Arrive.AjouterFile(vaisseaux);
        }
        public void TransfrerVaisseauxArriveDepart()
        {

            if (Depart.VerifFileMax())
            {
                while (!Depart.VerifFileVide())
                {
                    if (ancre.Suivant.Arrive.VerifFileMax())
                    {
                        ancre.Suivant.TransfrerVaisseauxArriveDepart();
                        break;
                    }
                    ancre.Suivant.AjouterVaisseauxArrive(Depart.SupprimerFile());
                }
            }
            else
            {
                Depart.AjouterFile(Arrive.SupprimerFile());
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

        public void RetierFin(CentreTri retrait)
        {
            CentreTri temp;
            temp = retrait;
            Queu = temp;
            Queu.Suivant = null;

            if (cpt_noeud == 0)
            {
                ancre = null;
            }
            cpt_noeud--;
        }

        public void RetirerDebut()
        {
            ancre = ancre.Suivant;
            ancre.Precedant = null;
            if (cpt_noeud == 0)
            {
                Queu = ancre;
            }
            cpt_noeud--;
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
