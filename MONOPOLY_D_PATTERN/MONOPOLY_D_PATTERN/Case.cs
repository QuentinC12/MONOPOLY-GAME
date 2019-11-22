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
		
        public Case(int id,string stateCase, string name)
        {
            this.id = id;
            this.stateCase=stateCase;
            this.nameCase = name;
        }
		//SOIT ON L'INITIALISE AVEC UN CSV NOUS DONNANT CHAQUE CASE SOIT ON REMPLIT EN DUR CHAQUE CASE.

		public abstract int Id { get; }
        public abstract string StateCase { get; }
        public abstract string NameCase { get; }

       
	}
}
