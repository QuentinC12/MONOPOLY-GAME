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
        private int idPlayerOwner; //mettre en -1 à la création| -1 = pas de owner / sinon hop l'id du owner
        private int[] prix; //tableau de prix genre Prix[0] est sans maison, Prix[1] avec une maison

        public Property(int id, string stateCase, string name, int[] prix) : base(id, stateCase, name)
        {
            this.etatCase = 0;
            this.idPlayerOwner = -1;
            this.prix = prix;
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
        public int IdPlayerOwner
        {
            get { return this.idPlayerOwner; }
            set { this.idPlayerOwner = value; }
        }
        public int[] Prix
        {
            get { return this.prix; }
        }

        
            
    }
}

