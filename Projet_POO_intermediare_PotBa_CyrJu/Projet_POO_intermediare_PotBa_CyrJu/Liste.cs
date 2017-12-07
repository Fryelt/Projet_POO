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
        public CentreTri Ancre
        {
            get { return ancre; }
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
