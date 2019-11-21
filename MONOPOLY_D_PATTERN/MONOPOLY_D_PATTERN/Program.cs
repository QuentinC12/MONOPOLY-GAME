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
			
			Controller jeu = new Controller();
			
			while(!jeu.VictoryConditions)
			{
				for(int id = 0;id<jeu.NbPlayer;id++)
				{
					jeu.VerifStatut(id);
					
				}
				jeu.Tour++;
			}
		}

		static void Restart()//Redemarrer une partie
		{

		}

		

		
		
	}

	
}
