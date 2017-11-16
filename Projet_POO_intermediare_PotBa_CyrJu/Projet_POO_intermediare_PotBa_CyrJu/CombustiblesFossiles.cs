using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class CombustiblesFossiles : IMateriaux
    {
        private int _tempsChargement = 0;
        private string _nomMateriaux = null;
        private IMateriaux _suivant = null;
        public CombustiblesFossiles()
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
        public IMateriaux suivant
        {
            get { return _suivant; }
            set { _suivant = value; }
        }
    }
}
