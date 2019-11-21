using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class De
	{
		private int nbLSuccessiveLaunch;
		private int De1;
		private int De2;
		private bool doubler;
		private bool stop;
		public De()
		{
			nbLSuccessiveLaunch = 0;
			De1 = 0;
		    De2 = 0;
			doubler = false;
			stop = false;

		}
		//DE 1 et D2;
		//Nombre de lancés successifs
		public bool Doubler
		{
			get { return doubler; }
		}
		public bool Stop
		{
			get { return stop; }
			set { stop = value; }
		}
		public void initiateLaunch()
		{
			//nb de lancés successifs = 0;
		}

		public bool comparateurDouble(int val1, int val2)
		{
			bool Double = false;
			if(val1==val2)
			{
				Double = true;
			}
			return Double;
		}

		public int NbSuccessiveLaunch
		{
			get { return nbLSuccessiveLaunch; }
			set { nbLSuccessiveLaunch = value; }
		}

		public int PlayDe()
		{
			doubler = false;
			// We can't do this because the random is initialize on the clock, if we do that, the values will be the same.
			//De1 = FunctionRandom();
			//De2 = FunctionRandom();
			Random random = new Random();
			De1 = random.Next(1, 7);
			De2 = random.Next(1, 7);
			if (comparateurDouble(De1, De2))
			{
				doubler = true;
				nbLSuccessiveLaunch++;
			}
			if(nbLSuccessiveLaunch<3)
			{

			}
			Console.WriteLine("De 1: " + De1 + "\nDe 2: " + De2 + " ");
			return De1 + De2;
		}

		public int FunctionRandom()
		{
			Random random = new Random();
			return random.Next(1, 7); // donc de 1 à 6
		}

		

	}
}
