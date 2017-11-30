using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class TerresContaminees
    {  	
        protected int QuantiteM;
        protected int TempDechargement;
        protected int TailleMax;
        protected CPile ancre;

             TerresContaminees(int TailleMaxP, int QuantiteMP =0, CPile ancreP = null) base : (TailleMaxP , QuantiteMP, ancreP){

       	
        }
    }
}
