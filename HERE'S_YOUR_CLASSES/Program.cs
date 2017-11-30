using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Vaisseaux vaisseauT;
            File test;
            CentreTri test1;
            int tailleC, tailleV;
            tailleC = 6;
            tailleV = 3;
            test = new File(tailleV);
            test1 = new CentreTri(1);
            //for (int ind = 2; ind <= tailleC; ind++)
            //{
            //    test1.AjouterCentre(new CentreTri(ind));
            //}
            for (int ind = 0; ind < tailleV; ind++)
            {
                vaisseauT = new Cargo();
                vaisseauT.AjouterMateriaux(new Plutonium(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 4)));
                vaisseauT.AjouterMateriaux(new Uranium(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 3)));
                vaisseauT.AjouterMateriaux(new CombustiblesFossiles(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 2)));
                vaisseauT.AjouterMateriaux(new MetauxLourds(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 1)));
                vaisseauT.AjouterMateriaux(new TerresContaminees(vaisseauT.CapaciteTotale - vaisseauT.Capacite));
                test.AjouterFile(vaisseauT);
            }

            
        }
    }
}