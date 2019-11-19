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

		public int Tour		//On veut l'avoir mais pas le set
			{
			get { return tour; }
			}

		static int NbPlayer
		{
			get { return nbPlayer; }
		}
		static int NbSuccessiveLaunch
		{
			get { return nbLSuccessiveLaunch; }
			set { nbLSuccessiveLaunch = value; }
		}

		static Player[] ListPlayer
		{
			get { return listPlayer; }
			set { listPlayer = value; }
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
			Console.WriteLine("------[Press a key to begin]------\n");
			Console.ReadKey();
			for (int i = 0; i<nbPlayers;i++)
			{
				Console.Clear();
				Console.Write("Choose the name of the player: " + (i+1)+"\n>");
				username = Console.ReadLine();
				listPlayer[i] = new Player(username);
			}
			Console.Clear();
			Console.Write("----------------------------------------------------\n");
			Console.WriteLine("----The " + nbPlayers + " players are well defined----\n----Press any key to start playing----");
			Console.WriteLine("----------------------------------------------------\n");
			Console.ReadKey();
			Console.Clear();



		}

	}
 }
