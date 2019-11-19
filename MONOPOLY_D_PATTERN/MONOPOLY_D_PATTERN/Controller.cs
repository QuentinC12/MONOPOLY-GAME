using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Controller
	{
		// CETTE CLASSE SERA UN SINGLETON, ELLE PERMET DE CONTROLLER TOUT LE PROGRAMME.
		static int tour; //Numero du tour
		static int nbPlayer; //nombre de joueurs.
		static int nbLSuccessiveLaunch; //nombre du lancé;
		static Player[] listPlayer; //liste des joueurs.
		
		public Controller()
		{
			nbPlayer = nbPlayers();
			tour = 0;
			nbLSuccessiveLaunch = 0;
			listPlayer = new Player[nbPlayer];


		}

		private int nbPlayers()
		{
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("WELCOME on MONOPOLY");
			Console.WriteLine("----------------------------------------------------\n");
			Console.WriteLine("SELECT the number of players\n>");
			int nbPlayer = Convert.ToInt32(Console.ReadLine());


			return nbPlayer;
		}

		private void initiatePlayers(int nbPlayers)
		{
			int numeroPlayer;
			Console.WriteLine("\n\n----------------------------------------------------");
			Console.WriteLine("You chose to play with "+nbPlayers);
			Console.WriteLine("----------------------------------------------------\n");
			


			return nbPlayer;
		}

	}
 }
