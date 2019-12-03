using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
    class Property : Case
    {
        private int etatCase; //O rien 1 maison, 2 maison, 3 maison, hotel ou autre.
        private int[] prix; //tableau de prix genre Prix[0] est sans maison, Prix[1] avec une maison
        private bool owned;
        private int idOwner;
        private int nbHouse;

        public Property(int id, string stateCase, string name, int[] prix) : base(id, stateCase, name)
        {
            this.etatCase = 0;
            this.prix = prix;
            this.owned = false;
            this.idOwner = -1;
            this.nbHouse = 0;

        }
        public override int Id
        {
            get
            {
                return this.id;
            }
        }
        public override string StateCase
        {
            get { return this.stateCase; }
        }
        public override string NameCase
        {
            get { return this.nameCase; }
        }
        public int EtatCase
        {
            get { return this.etatCase; }
            set { this.etatCase = value; }
        }
        public int[] Prix
        {
            get { return this.prix; }
        }
        public bool Owned
        {
            get { return owned; }
            set { owned = value; }
        }
        public int IDOwner
        {
            get { return idOwner; }
            set { idOwner = value; }
        }

        public int NbHouse
        {
            get { return nbHouse; }
            set { nbHouse = value; }
        }





    }
}

