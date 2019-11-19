using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Player
	{
		private static int nbPlayer;
		private int idPlayer;
		private int position;
		private int cash;
		private int statut;
		private string username;

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

		public override string ToString()
		{
			return "Joueur "+username+", A IMPLEMENTER ";
		}
	}
}
