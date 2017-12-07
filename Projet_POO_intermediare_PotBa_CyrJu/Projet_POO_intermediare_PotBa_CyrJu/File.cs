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
        public int NbrVaisseaux
        {
            get { return nbr_vaisseaux; }
        }
        public Vaisseaux Ancre
        {
            get { return ancre; }
        }

        public File(int tailleMaxP) //Creation des Files avec leur taille max en Parametre
        {
            tailleMax = tailleMaxP;
            queue = ancre = null;
            nbr_vaisseaux = 0;
        }
        public bool VerifFileMax() // Fonction Verification Max de la file 
        {
            if (nbr_vaisseaux == tailleMax)
                return true;
            return false;
        }
        public bool VerifFileVide() // Fonction Verification si la vide de la file
        {
            return (nbr_vaisseaux == 0);
        }
        public void AjouterFile(Vaisseaux vaisseau) // ajout simplle dans la file 
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
        public Vaisseaux SupprimerFile() // retrait simple de la file 
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
      
    }
}