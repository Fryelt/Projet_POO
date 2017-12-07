using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Materiaux
    {
        protected int tempsChargement, tailleMateriaux;
        protected Materiaux suivant = null;  // pointe vers le curseur suivant 

        public int TempsChargement
        {
            get { return tempsChargement; }
        }
        public int TailleMateriaux
        {
            get { return tailleMateriaux; }
            set { tailleMateriaux = value; }
        }
        public Materiaux Suivant // pointe vers le curseur suivant 
        {
            get { return suivant; }
            set { suivant = value; }
        }

        public Materiaux(int tailleM)  // Constructeur 
        {
            tailleMateriaux = tailleM;
        }
      
        public virtual Materiaux Creation(int tailleN) // methode de surcharge pour creer un nouveau !
        {
            return new Materiaux(tailleN);
        }
    }
}
