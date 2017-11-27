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
        private Plutonium PilePlutonium;
        private Uranium PileUranium;
        private TerresContaminees PileTerresContaminees;
        private CombustiblesFossiles PileCombustiblesFossiles;
        private MetauxLourds PileMetauxLourds;
        private File Depart;
        private File Arrive;


        public CentreTri(int numerocentre)
        {
            if (numerocentre % 2 >= 0)
            {
                Categ = 'P';
                PilePlutonium = new Plutonium(1003);
                PileUranium = new Uranium(857);
                PileMetauxLourds = new MetauxLourds(3456);
                PileCombustiblesFossiles = new CombustiblesFossiles(639);
                PileTerresContaminees = new TerresContaminees(457);
                Depart = new File(30);
                Arrive = new File(30);
            }
            else
            {
                Categ = 'I';
                PilePlutonium = new Plutonium(3067);
                PileUranium = new Uranium(2456);
                PileMetauxLourds = new MetauxLourds(561);
                PileCombustiblesFossiles = new CombustiblesFossiles(8234);
                PileTerresContaminees = new TerresContaminees(2658);
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
