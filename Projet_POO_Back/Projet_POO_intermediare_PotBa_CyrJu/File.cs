using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class File
    {
        protected Vaisseaux queue;
        protected int tailleMax, nbr_vaisseaux;


        public Vaisseaux Queu {  get { return queue; } }

        public File(int tailleMaxP)
        {
            tailleMax = tailleMaxP;
            queue = null;
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
            if (queue != null)
                return false;
            return true;
        }

        public void AjouterFile(Vaisseaux vaisseau)
        {
            if (!VerifFileMax())
            {
                vaisseau.Precedent = queue;
                queue = vaisseau;
                nbr_vaisseaux++;
            }
            else
            {
                //LA FILE A ATTEINT LE MAX
            }
        }

        public Vaisseaux SupprimerFile()
        {
            Vaisseaux vaisseauT = null;

            if (!VerifFileVide())
            {
                vaisseauT = new Vaisseaux(queue.CapaciteTotale);
                queue = queue.Precedent;
                nbr_vaisseaux--;
            }
            return vaisseauT;
        }
    }
}
