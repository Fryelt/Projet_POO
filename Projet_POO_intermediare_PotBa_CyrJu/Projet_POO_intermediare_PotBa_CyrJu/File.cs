using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class File
    {
        protected Vaisseaux queue, ancre;
        protected int tailleMax, nbr_vaisseaux;

        public File(int tailleMaxP)
        {
            tailleMax = tailleMaxP;
            queue = ancre = null;
            nbr_vaisseaux = 0;
        }
        public bool VerifFileMax()
        {
            if (nbr_vaisseaux == tailleMax)
                return true;
            return false;
        }
        public bool VerifFileVide()
        {
            return (nbr_vaisseaux == 0);
        }
        public void AjouterFile(Vaisseaux vaisseau)
        {
            if (VerifFileVide())
            {
                queue = ancre = vaisseau;
                nbr_vaisseaux++;
            }
            else if (!VerifFileMax())
            {
                queue.Prochain = vaisseau;
                queue = vaisseau;
                nbr_vaisseaux++;
            }
        }
        public Vaisseaux SupprimerFile()
        {
            Vaisseaux vaisseauT = null;
            if (!VerifFileVide())
            {
                vaisseauT = new Vaisseaux(ancre.CapaciteTotale, ancre.Capacite, ancre.PileMateriaux);
                ancre = ancre.Prochain;
                nbr_vaisseaux--;
            }
            return vaisseauT;
        }
        public int NbrVaisseaux
        {
            get { return nbr_vaisseaux; }
        }
        public Vaisseaux Ancre
        {
            get { return ancre; }
        }
    }
}