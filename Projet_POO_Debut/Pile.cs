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
         private int QuantiteTransfert;

          
          Pile(int tailleMaxP, Pile ancreP, Pile queuP)
          {
               tailleMax = tailleMaxP;
               ancre = ancreP;
               queu = queuP;
          }



          ViderPile(){

          }


          AjouterPile(){

          }


          SupprimerPile(){

          }

    }
}
