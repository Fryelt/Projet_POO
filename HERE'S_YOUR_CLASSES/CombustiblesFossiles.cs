using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class CombustiblesFossiles : Materiaux
    {
        public CombustiblesFossiles(int _capacite) : base (_capacite)
        {

        }
        public override Materiaux Creation(int tailleN)
        {
            return new CombustiblesFossiles(tailleN);
        }
    }
}