using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	abstract class Case
	{
		protected int id;
		protected string stateCase; //Chance, communauté, prison, (achetable ou déjà acheté ça non ça sera ailleurs) 
		protected string nameCase; // Nom exemple rue de la paix
		private bool owned;
		public Case(int id,string stateCase, string name)
        {
            this.id = id;
            this.stateCase=stateCase;
            this.nameCase = name;
			this.owned = false;
		}
		

		public abstract int Id { get; }
        public abstract string StateCase { get; }
        public abstract string NameCase { get; }

		public bool Owned
		{
			get { return owned; }
			set { owned = value; }
		}

	}
}
