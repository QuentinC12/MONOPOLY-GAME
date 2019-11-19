using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Case
	{
		private int statutCase; //Chance, prison, achetable ou déjà acheté
		private int etatCase; //1 maison, 2 maison, 3 maison, hotel ou autre.
		private string nomCase; // Nom exemple rue de la paix
		private int[] Prix; //tableau de prix genre Prix[0] est sans maison, Prix[1] avec une maison
	}
}
