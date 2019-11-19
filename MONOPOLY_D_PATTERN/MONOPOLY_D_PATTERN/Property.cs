using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Property : Case
	{
	private int etatCase; //1 maison, 2 maison, 3 maison, hotel ou autre.
	private int idPlayerOwner; //mettre en -1 à la création| -1 = pas de owner / sinon hop l'id du owner
	private int[] Prix; //tableau de prix genre Prix[0] est sans maison, Prix[1] avec une maison
	}
}
