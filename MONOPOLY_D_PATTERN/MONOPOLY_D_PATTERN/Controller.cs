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
			initiatePlayers(nbPlayer);


		}

		private int nbPlayers()
		{
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("WELCOME on MONOPOLY");
			Console.WriteLine("----------------------------------------------------\n");
			Console.Write("SELECT the number of players\n	>");
			int nbPlayer = Convert.ToInt32(Console.ReadLine());


			return nbPlayer;
		}

		private void initiatePlayers(int nbPlayers)
		{
			string username;
			Console.WriteLine("\n\n----------------------------------------------------");
			Console.WriteLine("You chose to play with "+nbPlayers + " players");
			Console.WriteLine("----------------------------------------------------\n");
			Console.WriteLine("Press a key to begin\n");
			Console.ReadKey();
			for (int i = 0; i<nbPlayers;i++)
			{
				Console.Clear();
				Console.WriteLine("Choose the name of player" + i);
				username = Console.ReadLine();
				listPlayer[i] = new Player(username);
			}
			Console.Clear();
			Console.Write("----------------------------------------------------\n");
			Console.WriteLine("The " + nbPlayers + " players are well defined\n----Press any key to start playing----");
			Console.WriteLine("----------------------------------------------------\n");
			Console.ReadKey();
			Console.Clear();



		}

	}
 }
