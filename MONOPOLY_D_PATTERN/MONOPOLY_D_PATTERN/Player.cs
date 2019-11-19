using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Player
	{
		private static int nbPlayer; //Nombre de player total -> Pour ça que static.
		private int idPlayer; //Id du player
		private int position; //position sur le plateau 0-39
		private int cash; //Cash qu'à le joueur
		private int statut; //Statut comme dit auparavant 4 -> 1er tour de prison ... 0 libre.
		private string username; //Nom du joueur !

		public Player()
		{
			nbPlayer++;  
			idPlayer = nbPlayer;
			position = 0;
			cash = 0;
			statut = 0;
			username = "unknow";

		}
		public Player(int cash, int statut, string username)
		{
			nbPlayer++;
			idPlayer = nbPlayer;
			position = 0;
			this.cash = cash;
			this.statut = statut;
			this.username = username;

		}

		public Player(string username)
		{
			nbPlayer++;
			idPlayer = nbPlayer;
			position = 0;
			this.cash = 0;
			this.statut = 0;
			this.username = username;

		}

		public override string ToString()
		{
			return "Joueur "+username+", A IMPLEMENTER ";
		}
		//FAIRE LES GETTER AND SETTER
	}
}
