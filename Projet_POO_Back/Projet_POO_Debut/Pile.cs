using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Pile
    {
         private int tailleMax;
         private int cpt_Noeu = 0;
         protected Pile ancre;
         protected Pile queu;
         
          

          public Pile Ancre { get { return ancre; } }
          public int TailleMax { get { return tailleMax; } }
           
          Pile(int tailleMaxP, Pile ancreP, Pile queuP)
          {
               tailleMax = tailleMaxP;
               ancre = ancreP;
               queu = queuP;
          }



        public void Empiler(Pile materiaux)
        {
            if (tailleMax == cpt_noeud)
            {
                return;
            }
            else
            {
                ancre = ;
                materiaux.Suivant = ancre;
                cpt_noeud++;
            }
        }

        public bool VerifVide()
        {
            if (ancre == null)
            {
                return true;
            }
            else
                return false;
        }

        public  Depiler()
        {
             Pile Materiaux = null;

            if (!VerifVide())
            {
                
                ancre = ancre.Suivant;
                materiaux = ancre;
                cpt_noeud--;
                return nbr;
            }
            else
            {
                return null;
            }
        }
    }
}
