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
            if (numerocentre % 2 == 0)
            {
                if (numerocentre % 5 == 0)
                    CreationCentre('P', 1003, 0, 0, 0, 457, 30, 30);
                else
                    CreationCentre('P', 1003, 857, 3456, 639, 457, 30, 30);
            }
            else
            {
                if (numerocentre % 5 == 0)
                    CreationCentre('I', 3067, 0, 0, 0, 2658, 45, 45);
                else if (verifPremier(numerocentre))
                    CreationCentre('I', 0, 2456, 561, 0, 0, 45, 45);
                else
                    CreationCentre('I', 3067, 2456, 561, 8234, 2658, 45, 45);
            }
        }
        public bool verifPremier(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }
        public void CreationCentre(char _Categ, int _PilePlutonium, int _PileUranium, int _PileMetauxLourds, int _PileCombustiblesFossiles, int _PileTerresContaminees, int _Depart, int _Arrivee)
        {
            Categ = _Categ;
            PilePlutonium = new Plutonium(_PilePlutonium);
            PileUranium = new Uranium(_PileUranium);
            PileMetauxLourds = new MetauxLourds(_PileMetauxLourds);
            PileCombustiblesFossiles = new CombustiblesFossiles(_PileCombustiblesFossiles);
            PileTerresContaminees = new TerresContaminees(_PileTerresContaminees);
            Depart = new File(_Depart);
            Arrive = new File(_Arrivee);
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