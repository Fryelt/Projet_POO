using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO_intermediare_PotBa_CyrJu
{
    class Vaisseaux
    {
        protected int capaciteTotale;
        protected Plutonium pilePlutonium;
        protected Uranium pileUranium;
        protected MetauxLourds pileMetauxLourds;
        protected TerresContaminees pileTerresContaminees;
        protected CombustiblesFossiles pileCombustiblesFossiles;
        public Vaisseaux(int _capaciteTotale)
        {
            capaciteTotale = _capaciteTotale;
            pilePlutonium = new Plutonium();
            pileUranium = new Uranium();
            pileMetauxLourds = new MetauxLourds();
            pileTerresContaminees = new TerresContaminees();
            pileCombustiblesFossiles = new CombustiblesFossiles();
        }
        public int CapaciteTotale
        {
            get { return capaciteTotale; }
            set { capaciteTotale = value; }
        }
        public Plutonium PilePlutonium
        {
            get { return pilePlutonium; }
            set { pilePlutonium = value; }
        }
        public Uranium PileUranium
        {
            get { return pileUranium; }
            set { pileUranium = value; }
        }
        public MetauxLourds PileMetauxLourds
        {
            get { return pileMetauxLourds; }
            set { pileMetauxLourds = value; }
        }
        public TerresContaminees PileTerresContaminees
        {
            get { return pileTerresContaminees; }
            set { pileTerresContaminees = value; }
        }
        public CombustiblesFossiles PileCombustiblesFossiles
        {
            get { return pileCombustiblesFossiles; }
            set { pileCombustiblesFossiles = value; }
        }
    }
}
