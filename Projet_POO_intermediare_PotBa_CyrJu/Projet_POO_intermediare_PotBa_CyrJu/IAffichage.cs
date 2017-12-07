using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
     interface IAffichage
    {
        void AfficherCentreTri(CentreTri centreTri);

        void AfficherTransfertVaisseaux(Materiaux materieux, Vaisseaux Vaisseaux, int NbrCentretrie);
        
        void AfficherFin();

        void AfficherMateriaux(Materiaux materiaux);
    }
}
