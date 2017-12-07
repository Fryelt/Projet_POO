using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class CentreTri
    {
        private char Categ;
        private int numCentre;
        private CentreTri suivant;
        private CentreTri precedant;
        private Pile pilePlutonium;
        private Pile pileUranium;
        private Pile pileTerresContaminees;
        private Pile pileCombustiblesFossiles;
        private Pile pileMetauxLourds;
        private File depart;
        private File arrive;


        public int NumCentre
        {
            get { return numCentre; }
        }
        public CentreTri Suivant
        {
            get { return suivant; }
            set { suivant = value; }
        }
        public CentreTri Precedant
        {
            get { return precedant; }
            set { precedant = value; }
        }
        public File Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        public File Arrive
        {
            get { return arrive; }
            set { arrive = value; }
        }
        public Pile PilePlutonium
        {
            get { return pilePlutonium; }
            set { pilePlutonium = value; }
        }
        public Pile PileUranium
        {
            get { return pileUranium; }
            set { pileUranium = value; }
        }
        public Pile PileTerresContaminees
        {
            get { return pileTerresContaminees; }
            set { pileTerresContaminees = value; }
        }
        public Pile PileCombustiblesFossiles
        {
            get { return pileCombustiblesFossiles; }
            set { pileCombustiblesFossiles = value; }
        }
        public Pile PileMetauxLourds
        {
            get { return pileMetauxLourds; }
            set { pileMetauxLourds = value; }
        }

        public CentreTri(int numerocentre) // Creation du nouvelle centre tri
        {
            numCentre = numerocentre;
            if (numerocentre % 2 == 0)
            {
                if (numerocentre % 5 == 0)
                    CreationCentre('P', 1003, 0, 0, 0, 457, 30, 30);
                else
                    CreationCentre('P', 1003, 857, 3456, 639, 457, 30, 30);
            }
            else
            {
                if (numerocentre % 5 == 0)
                    CreationCentre('I', 3067, 0, 0, 0, 2658, 45, 45);
                else if (VerifPremier(numerocentre))
                    CreationCentre('I', 0, 2456, 561, 0, 0, 45, 45);
                else
                    CreationCentre('I', 3067, 2456, 561, 8234, 2658, 45, 45);
            }
        }
        public bool VerifPremier(int n) // Verification du nombre premier
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }
        public void CreationCentre(char _Categ, int _PilePlutonium, int _PileUranium, int _PileMetauxLourds, int _PileCombustiblesFossiles, int _PileTerresContaminees, int _Depart, int _Arrivee)
        {
            Categ = _Categ;
            pilePlutonium = new Pile(_PilePlutonium);
            pileUranium = new Pile(_PileUranium);
            pileMetauxLourds = new Pile(_PileMetauxLourds);
            pileCombustiblesFossiles = new Pile(_PileCombustiblesFossiles);
            pileTerresContaminees = new Pile(_PileTerresContaminees);
            depart = new File(_Depart);
            arrive = new File(_Arrivee);
        }
        public void AjouterVaisseauxArrive(Vaisseaux vaisseauxN)
        {
            //À PENSER SI LA FILE DÉPART PRÉCÉDENTE EST VIDE
            if (Arrive.VerifFileMax())  // Verifi si la file d'arriver a attein sont maximum
            {
                CommencerTraitement(Arrive.SupprimerFile()); // vide la file d'arriver au complet 
            }
            Arrive.AjouterFile(vaisseauxN); // ajoute le vaisseaux a la file d'arrive de la liste une fois 
        }
        public bool VaisseauxRestants() // Verifi si il reste des vaisseaux restant dans la file d'arriver du centre de trie
        {
            while(Arrive.NbrVaisseaux != 0) // fait l'operation jusqu'a ce qu'il ne reste plus de vaisseaux
            {
                CommencerTraitement(Arrive.SupprimerFile());
            }
            while(Depart.NbrVaisseaux != 0) // verifi si il reste des vaisseaux dans la file de depart
            {
                if (Suivant != null)  // verifi si l'on n'est pas au dernier centre de tri 
                {
                    if (!Suivant.Depart.VerifFileMax()) // verifi si la file de depart du centre suivant n'est pas pleine
                    {
                        Suivant.AjouterVaisseauxArrive(Depart.SupprimerFile()); // ajoute le vaissaux au a la file arrive du centre de tri suivant 
                    }
                    else
                    {
                        return false; // la file depart du centre de tri suivant est pleine 
                    }
                }
                else
                {
                    Depart.SupprimerFile(); // Supprime le vaissaux dans le vide du dernier centre de tri
                }
            }
            return true;
        }
        public void TransfertVaisseauxDepart(Pile transfert, Materiaux objetRestant)  // Transfert la pile qui deborde au vaissaux de la file de depart du centre 
        {
            while(transfert.Ancre != null) // Tant que la pile est pleine il vide
            {
                if (Depart.VerifFileVide()) // arrete si la file est vide 
                    break;
                else
                {
                    objetRestant = objetRestant.Creation(Depart.Ancre.AjouterMateriaux(transfert.SupprimerPile()));  // prend l'objet restant et cree un nouveaux materiaux pour le suppprimer le materiaux de la pile de transfert
                    if (Depart.Ancre.CapaciteTotale == Depart.Ancre.Capacite)
                    {
                        if (Suivant != null) // verifi si le suivant est pas null
                        {
                            Suivant.AjouterVaisseauxArrive(Depart.SupprimerFile());
                            transfert.AjouterPile(objetRestant);
                        }
                        else // sinon fin
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void CommencerTraitement(Vaisseaux vaisseauTransfert) // traitement des vaisseaux dechargement des matieres 
        {
            Materiaux materielT;
            int nbrMateriaux;
            bool VerifCorrect;
            
            if (!Depart.VerifFileMax()) // tant que la file de depart n'est pas pleine
            {
                VerifCorrect = true;
                nbrMateriaux = vaisseauTransfert.PileMateriaux.NbrMateriaux;
                while (vaisseauTransfert.PileMateriaux.Ancre != null) // regarde si tout ces materiaux au vaisseau ne sont pas vide
                {
                    materielT = vaisseauTransfert.PileMateriaux.SupprimerPile();  // stock le materiaux du vaisseau actuel 
                    vaisseauTransfert.Capacite -= materielT.TailleMateriaux; // enleve la quantite de matiere de la pile 
                    switch (materielT.GetType().Name)  // Effectue le traitement selon le type de matiere 
                    {
                        case "Plutonium":
                            if (PilePlutonium.CapaciteMax == 0)  // si la quantite de matiere est vide puis l'ajoute a la file de depart
                            {
                                vaisseauTransfert.AjouterMateriaux(materielT);
                                depart.AjouterFile(vaisseauTransfert);
                                VerifCorrect = false;
                            }
                            else
                            {
                                while (PilePlutonium.AjouterPile(materielT))  // transfer jusqu'a ce que la quantite de la pile sois pleine 
                                {
                                    TransfertVaisseauxDepart(PilePlutonium, new Plutonium(0));
                                }
                            }
                            break;
                        case "Uranium":
                            if (PileUranium.CapaciteMax == 0)
                            {
                                vaisseauTransfert.AjouterMateriaux(materielT);
                                depart.AjouterFile(vaisseauTransfert);
                                VerifCorrect = false;
                            }
                            else
                            {
                                while (PileUranium.AjouterPile(materielT))
                                {
                                    TransfertVaisseauxDepart(PileUranium, new Uranium(0));
                                }
                            }
                            break;
                        case "CombustiblesFossiles":
                            if (PileCombustiblesFossiles.CapaciteMax == 0)
                            {
                                vaisseauTransfert.AjouterMateriaux(materielT);
                                depart.AjouterFile(vaisseauTransfert);
                                VerifCorrect = false;
                            }
                            else
                            {
                                while (PileCombustiblesFossiles.AjouterPile(materielT))
                                {
                                    TransfertVaisseauxDepart(PileCombustiblesFossiles, new CombustiblesFossiles(0));
                                }
                            }
                            break;
                        case "MetauxLourds":
                            if (PileMetauxLourds.CapaciteMax == 0)
                            {
                                vaisseauTransfert.AjouterMateriaux(materielT);
                                depart.AjouterFile(vaisseauTransfert);
                                VerifCorrect = false;
                            }
                            else
                            {
                                while (PileMetauxLourds.AjouterPile(materielT))
                                {
                                    TransfertVaisseauxDepart(PileMetauxLourds, new MetauxLourds(0));
                                }
                            }
                            break;
                        case "TerresContaminees":
                            if (PileTerresContaminees.CapaciteMax == 0)
                            {
                                vaisseauTransfert.AjouterMateriaux(materielT);
                                depart.AjouterFile(vaisseauTransfert);
                                VerifCorrect = false;
                            }
                            else
                            {
                                while (PileTerresContaminees.AjouterPile(materielT))
                                {
                                    TransfertVaisseauxDepart(PileTerresContaminees, new TerresContaminees(0));
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    if (VerifCorrect == false)
                        break;
                }
                if (VerifCorrect)
                    Depart.AjouterFile(vaisseauTransfert);
            }
            else
            {
                if (Suivant == null)
                    Depart.SupprimerFile();
                else
                    Suivant.AjouterVaisseauxArrive(Depart.SupprimerFile());
            }
        }
     
    }
}