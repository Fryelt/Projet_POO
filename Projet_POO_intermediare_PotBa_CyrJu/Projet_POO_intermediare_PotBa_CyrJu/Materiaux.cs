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
        protected Materiaux suivant = null;

        public Materiaux(int tailleM)
        {
            tailleMateriaux = tailleM;
        }
        public int TempsChargement
        {
            get { return tempsChargement; }
        }
        public int TailleMateriaux
        {
            get { return tailleMateriaux; }
            set { tailleMateriaux = value; }
        }
        public Materiaux Suivant
        {
            get { return suivant; }
            set { suivant = value; }
        }
        public virtual Materiaux Creation(int tailleN)
        {
            return new Materiaux(tailleN);
        }
    }
}
