using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Board
	{
		private Case[] plateau; //Plateau de jeu avec 39 cases.
		// UTILISER LE DESIGN PATTERN SINGLETON POUR S'ASSURER QU'ON A QU'UNE INSTANCE DE CETTE CLASSE.

		public Board()
		{
			plateau = new Case[40];
			for(int i=0;i<40;i++)
			{
				plateau[i] = new Case(); // A IMPLEMENTER
			}
		}

		public void viewingBoard()
		{
			 //Fonction d'affichage
		}
	}
}
