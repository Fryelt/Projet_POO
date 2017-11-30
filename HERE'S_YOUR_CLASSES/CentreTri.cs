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
        private CentreTri suivant;
        private CentreTri precedant;
        private Pile pilePlutonium;
        private Pile pileUranium;
        private Pile pileTerresContaminees;
        private Pile pileCombustiblesFossiles;
        private Pile pileMetauxLourds;
        private File depart;
        private File arrive;
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
                else if (VerifPremier(numerocentre))
                    CreationCentre('I', 0, 2456, 561, 0, 0, 45, 45);
                else
                    CreationCentre('I', 3067, 2456, 561, 8234, 2658, 45, 45);
            }
        }
        public bool VerifPremier(int n)
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
            pilePlutonium = new Pile(_PilePlutonium);
            pileUranium = new Pile(_PileUranium);
            pileMetauxLourds = new Pile(_PileMetauxLourds);
            pileCombustiblesFossiles = new Pile(_PileCombustiblesFossiles);
            pileTerresContaminees = new Pile(_PileTerresContaminees);
            depart = new File(_Depart);
            arrive = new File(_Arrivee);
        }
        public CentreTri Suivant
        {
            get { return suivant; }
            set { suivant = value; }
        }
        public CentreTri Precedant
        {
            get { return precedant; }
            set { precedant = value; }
        }
        public File Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        public File Arrive
        {
            get { return arrive; }
            set { arrive = value; }
        }
        public Pile PilePlutonium
        {
            get { return pilePlutonium; }
            set { pilePlutonium = value; }
        }
        public Pile PileUranium
        {
            get { return pileUranium; }
            set { pileUranium = value; }
        }
        public Pile PileTerresContaminees
        {
            get { return pileTerresContaminees; }
            set { pileTerresContaminees = value; }
        }
        public Pile PileCombustiblesFossiles
        {
            get { return pileCombustiblesFossiles; }
            set { pileCombustiblesFossiles = value; }
        }
        public Pile PileMetauxLourds
        {
            get { return pileMetauxLourds; }
            set { pileMetauxLourds = value; }
        }
    }
}