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
		private bool Double;
		public De()
		{
			nbLSuccessiveLaunch = 0;
			De1 = 0;
		    De2 = 0;
			Double = false;

		}
		//DE 1 et D2;
		//Nombre de lancés successifs

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

		public void PlayDe()
		{
			Double = false;
			De1 = FunctionRandom();
			De2 = FunctionRandom();
			if (comparateurDouble(De1, De2))
			{
				Double = true;
				nbLSuccessiveLaunch++;
			}
		}

		public int FunctionRandom()
		{
			Random random = new Random();
			return random.Next(1, 7); // donc de 1 à 6
		}

	}
}
