using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class TerresContaminees : Materiaux
    {
        private int _tempsChargement = 0;
        private string _nomMateriaux = null;
        private Materiaux _suivant = null;
        public TerresContaminees()
        {

        }

        public int tempsChargement
        {
            get { return _tempsChargement; }
            set { _tempsChargement = value; }
        }
        public string nomMateriaux
        {
            get { return _nomMateriaux; }
            set { _nomMateriaux = value; }
        }
        public Materiaux suivant
        {
            get { return _suivant; }
            set { _suivant = value; }
        }
    }
}
