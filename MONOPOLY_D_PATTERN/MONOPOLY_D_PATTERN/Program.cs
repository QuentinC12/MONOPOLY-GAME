using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Program
	{
		static void Main(string[] args)
		{
			Controller Control = new Controller();
			
			
		}

		static Board InitialisationBoard()
		{
			Board plateau = new Board();
							// A Implementer!
			return plateau;
		}
	}

	
}
