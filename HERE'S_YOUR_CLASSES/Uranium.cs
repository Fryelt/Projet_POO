using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Uranium : Materiaux
    {
        public Uranium(int _capacite) : base(_capacite)
        {

        }
        public override Materiaux Creation(int tailleN)
        {
            return new Uranium(tailleN);
        }
    }
}
