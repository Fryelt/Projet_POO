﻿using System;
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
            File fileDebut;
            Liste listeCentres = new Liste();
            int tailleListeCentres, nbrVaisseaux;

            tailleListeCentres = 10;
            nbrVaisseaux = 100;
            //Ajout centres
            for (int ind = 1; ind <= tailleListeCentres; ind++)
            {
                listeCentres.AjouterCentre(new CentreTri(ind));
            }
            //Création file de debut
            fileDebut = new File(nbrVaisseaux);
            //Ajout vaisseaux + matériaux
            for (int ind = 0; ind < nbrVaisseaux; ind++)
            {
                vaisseauT = new Cargo();
                //vaisseauT.AjouterMateriaux(new Plutonium(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 4)));
                //vaisseauT.AjouterMateriaux(new Uranium(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 3)));
                //vaisseauT.AjouterMateriaux(new CombustiblesFossiles(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 2)));
                //vaisseauT.AjouterMateriaux(new MetauxLourds(rnd.Next(1, (vaisseauT.CapaciteTotale - vaisseauT.Capacite) - 1)));
                vaisseauT.AjouterMateriaux(new TerresContaminees(vaisseauT.CapaciteTotale - vaisseauT.Capacite));
                fileDebut.AjouterFile(vaisseauT);
            }

            while (!fileDebut.VerifFileVide())
            {
                listeCentres.Ancre.AjouterVaisseauxArrive(fileDebut.SupprimerFile());
            }
        }
    }
}