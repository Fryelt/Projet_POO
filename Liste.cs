using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Liste
    {
		class CListe
    {

        CentreTrie ancre = null;
        CentreTrie Queu = null;
        int cpt_noeud = 0;
       

       
        public CentreTrie Ancre { get { return ancre; } }
       
        
        public void AjouterCentre(CentreTrie nouveau)
        {
            CentreTrie actuel;
            CentreTrie temp = null;
            actuel = ancre;
            
            if (actuel == null)
            {
               
                AjouterDebut(nouveau);
            }
            else
            {
                while(actuel != null)
                {
                    
                    if (nouveau.Cote >= actuel.Cote)
                    {
                        temp = actuel;
                        actuel = actuel.Suivant;
                        if(actuel == null)
                        {
                            AjouterFin(nouveau);
                            break;
                        }
                       
                    }
                    else
                    {
                        if(ancre == actuel)
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

       public void RetierFin(CentreTrie retrait)
       {
            CentreTrie temp;
            temp = retrait;
            Queu = temp;
            Queu.Suivant = null;

            if(cpt_noeud == 0)
            {
                ancre = null;
            }
            cpt_noeud--;
       }

       public void RetirerDebut()
        {
            ancre = ancre.Suivant;
            ancre.Precedant = null;
            if(cpt_noeud == 0)
            {
                Queu = ancre;
            }
            cpt_noeud--;
        } 


        public void AjouterFin(CentreTrie nouveau)
        {
            Queu.Suivant = nouveau;
            nouveau.Precedant = Queu;
            Queu = nouveau;
            if(cpt_noeud == 0)
            {
                ancre = nouveau;
            }
            cpt_noeud++;
        }
        public void AjouterDebut(CentreTrie nouveau)
        {
            nouveau.Suivant = ancre;
            ancre = nouveau;
            if(cpt_noeud == 0)
            {
                Queu = ancre;
            }
            cpt_noeud++;
        }
    }
    }
}
