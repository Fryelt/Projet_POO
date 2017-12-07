using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
  class Affichage : IAffichage
    {
        public void AfficherCentreTri(CentreTri centreTri)
        {
            Console.WriteLine("Centre de trie numero " + centreTri.NumCentre);
            Console.WriteLine("Le nombre de vaisseaux dans la pile d'arriver est de : " + centreTri.Arrive.NbrVaisseaux);
            Console.WriteLine("Le nombre de vaisseaux dans la pile depart est de : " + centreTri.Depart.NbrVaisseaux);
            Console.WriteLine("Le nombre de materiaux total dans la pile Plutonium est de " + centreTri.PilePlutonium.CapaciteActuelle);
            Console.WriteLine("Le nombre de materiaux total dans la pile Uranium est de " + centreTri.PileUranium.CapaciteActuelle);
            Console.WriteLine("Le nombre de materiaux total dans la pile TerreContaminees est de " + centreTri.PileTerresContaminees.CapaciteActuelle);
            Console.WriteLine("Le nombre de materiaux total dans la pile MetauxLourd est de " + centreTri.PileMetauxLourds.CapaciteActuelle);
            Console.WriteLine("Le nombre de materiaux total dans la pile CombustibleFosile est de " + centreTri.PileCombustiblesFossiles.CapaciteActuelle);
        }
        public void AfficherFin()
        {
            Console.WriteLine("Job Done ! Tout les vaisseaux ont ete traiter");
        }

        public  void AfficherMateriaux(Materiaux materiaux)
        {
            Console.WriteLine("Le materiaux de type : " + materiaux.GetType().Name + " avec une taille de : " + materiaux.TailleMateriaux + " a ete transferer");
        }

        public void AfficherTransfertVaisseaux(Materiaux materiaux,Vaisseaux Vaisseaux, int NbrCentretrie)
        {
            Console.WriteLine("Le vaisseaux du centre de tri numero : " + NbrCentretrie + " " + "a transferer du " + materiaux.GetType().Name + "avec la quantite de : " + materiaux.TailleMateriaux);
        }
    }
}
