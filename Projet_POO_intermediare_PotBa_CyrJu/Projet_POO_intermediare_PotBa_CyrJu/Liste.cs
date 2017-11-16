using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Liste
    {

        Vaisseaux ancre = null;
        Vaisseaux Queu = null;
        int cpt_noeud = 0;


        public Vaisseaux Ancre { get { return ancre; } }
        public void RetirerVaisseau(Vaisseaux vaisseau)
        {

            Vaisseaux actuel;
            Vaisseaux temp = null;
            actuel = ancre;
            while (actuel != null)
            {
                if (actuel != vaisseau)
                {
                    temp = actuel;
                    actuel = actuel.Suivant;
                    if (actuel == null)
                    {
                        RetierFin(temp.Precedant);
                        break;
                    }
                }
                else
                {
                    if (actuel == ancre)
                    { 
                        RetirerDebut();
                        break;
                    }
                    else
                    {
                        temp = actuel.Precedant;
                        actuel = actuel.Suivant;
                        actuel.Precedant = temp;
                        temp.Suivant = actuel;
                        cpt_noeud--;
                        break;
                    }
                }
            }
        }
        public void AjouterVaisseau(Vaisseaux nouveau)
        {
            Vaisseaux actuel;
            Vaisseaux temp = null;
            actuel = ancre;

            if (actuel == null)
            {
                AjouterDebut(nouveau);
            }
            else
            {
                while (actuel != null)
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

        public void RetierFin(Vaisseaux retrait)
        {
            Vaisseaux temp;
            temp = retrait;
            Queu = temp;
            Queu.Suivant = null;

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
                Queu = ancre;
            }
            cpt_noeud--;
        }


        public void AjouterFin(Vaisseaux nouveau)
        {
            Queu.Suivant = nouveau;
            nouveau.Precedant = Queu;
            Queu = nouveau;
            if (cpt_noeud == 0)
            {
                ancre = nouveau;
            }
            cpt_noeud++;
        }
        public void AjouterDebut(Vaisseaux nouveau)
        {
            nouveau.Suivant = ancre;
            ancre = nouveau;
            if (cpt_noeud == 0)
            {
                Queu = ancre;
            }
            cpt_noeud++;
        }
    }
}
