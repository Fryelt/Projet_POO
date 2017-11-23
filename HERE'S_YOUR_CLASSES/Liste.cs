using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Liste
    {
        CentreTri ancre = null;
        CentreTri queud = null;
        int cpt_noeud = 0;



        public CentreTri Ancre { get { return ancre; } }


        public void AjouterCentre(CentreTri nouveau)
        {
            CentreTri actuel;
            CentreTri temp = null;
            actuel = ancre;

            if (actuel == null)
            {

                AjouterDebut(nouveau);
            }
            else
            {
                while (actuel != null)
                {

                    if (nouveau.Cote >= actuel.Cote)
                    {
                        temp = actuel;
                        actuel = actuel.Suivant;
                        if (actuel == null)
                        {
                            AjouterFin(nouveau);
                            break;
                        }

                    }
                    else
                    {
                        if (ancre == actuel)
                        {

                            AjouterDebut(nouveau);
                            break;
                        }
                        else
                        {
                            nouveau.Suivant = actuel;
                            nouveau.Precedant = actuel.Precedant;
                            actuel.Precedant = nouveau;
                            temp.Suivant = nouveau;
                            cpt_noeud++;
                            break;
                        }
                    }
                }
            }
        }

        public void RetierFin(CentreTri retrait)
        {
            CentreTri temp;
            temp = retrait;
            queud = temp;
            queud.Suivant = null;

            if (cpt_noeud == 0)
            {
                ancre = null;
            }
            cpt_noeud--;
        }

        public void RetirerDebut()
        {
            ancre = ancre.Suivant;
            ancre.Precedant = null;
            if (cpt_noeud == 0)
            {
                queud = ancre;
            }
            cpt_noeud--;
        }


        public void AjouterFin(CentreTri nouveau)
        {
            queud.Suivant = nouveau;
            nouveau.Precedant = queud;
            queud = nouveau;
            if (cpt_noeud == 0)
            {
                ancre = nouveau;
            }
            cpt_noeud++;
        }
        public void AjouterDebut(CentreTri nouveau)
        {
            nouveau.Suivant = ancre;
            ancre = nouveau;
            if (cpt_noeud == 0)
            {
                queud = ancre;
            }
            cpt_noeud++;
        }
    }
}
