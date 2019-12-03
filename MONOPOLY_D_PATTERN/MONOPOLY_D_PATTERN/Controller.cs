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
		private  int tour; //Numero du tour
		private  int nbPlayer; //nombre de joueurs.
		private  Player[] listPlayer; //liste des joueurs.
		private  Board plateau;
		private bool victoryConditions;

		public Controller()
		{
			nbPlayer = nbPlayers();
			tour = 0;
			listPlayer = new Player[nbPlayer];
			initiatePlayers(nbPlayer);
			plateau = new Board();
			victoryConditions = false;

		}

		public int Tour		//On veut l'avoir mais pas le set
			{
			get { return tour; }
			set { tour=value; }
		}

		public int NbPlayer
		{
			get { return nbPlayer; }
		}

		public Player[] ListPlayer
		{
			get { return listPlayer; }
			set { listPlayer = value; }
		}

		public bool VictoryConditions
		{
			get { return victoryConditions; }
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

		public void VerifStatut(int id)
		{
			if(listPlayer[id].Statut==0)
			{
				play(id); // Fonction pour lancer les dés et jouer
			}
			else
			{
				jail(id);
				
			}
		}
		public void play(int id)
		{
			
			De mesDe = new De();
			int forward = 0;
			do
			{
				Console.Clear();
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Tour: "+tour);
			Console.WriteLine("It's the turn of: "+listPlayer[id].Username);
			Console.WriteLine("Position on the board: " +listPlayer[id].Position + " - " + plateau.nameCase(listPlayer[id].Position)+ " - Cash: "+ listPlayer[id].Cash);
			Console.WriteLine("----------------------------------------------------");
				//Console.ReadKey(); //A METTRE OU PAS ?
				//Crée une instance de dés
				Console.WriteLine("Press any touch to launch the dice");
				Console.ReadKey();
				Console.WriteLine("-");
				forward = mesDe.PlayDe();
				if (mesDe.NbSuccessiveLaunch == 3)
				{
					mesDe.Stop = true;
					listPlayer[id].Position = 10;
					listPlayer[id].Statut = 3;
				}
				else
				{
					listPlayer[id].Forward(forward);
				}
				if (mesDe.Doubler) { Console.WriteLine("You did a double, it's still your turn !"); }
				Console.WriteLine("You're now on position: "+ listPlayer[id].Position+" -> " + plateau.nameCase(listPlayer[id].Position));
				Console.WriteLine("----------------------------------------------------");
				if(plateau.Plateau[listPlayer[id].Position] is Property )
				{
                    Property P = (MONOPOLY_D_PATTERN.Property)plateau.Plateau[listPlayer[id].Position];
                    if (P.Owned)
					{
						if(P.IDOwner == id)
						{
							Console.WriteLine("Press SOLD(s) to sold the property | BUY(b) house | (escape) to end the turn");
							ConsoleKeyInfo saisie;
							do
							{
								saisie = Console.ReadKey();
								if(saisie.Key != ConsoleKey.S && saisie.Key != ConsoleKey.B && saisie.Key != ConsoleKey.Escape)
								{
									Console.WriteLine("Please press the good touch");
								}
							} while (saisie.Key != ConsoleKey.S && saisie.Key != ConsoleKey.B && saisie.Key != ConsoleKey.Escape);
							if(saisie.Key == ConsoleKey.S)
								{
										// S'il veut acheter maison
								}
							if(saisie.Key == ConsoleKey.B)
							{
										// si non
								}
							if(saisie.Key == ConsoleKey.Escape)
							{

							}

						}
						else
						{
							Console.WriteLine("Owned by:  "+listPlayer[P.IDOwner].Username+"\nYou need to pay: "+ P.Prix[P.NbHouse]);

						}

					}
					else
					{
						
                        if (listPlayer[id].Cash >= P.Prix[6])
                        {
                            Console.WriteLine("You can afford this property for "+ P.Prix[6] + " euros");
							Console.WriteLine("PRESS [ENTER] TO BUY | [ESCAPE] to cancel");

							ConsoleKeyInfo saisie;
							do
							{
								 saisie = Console.ReadKey();
								}while(saisie.Key != ConsoleKey.Enter && saisie.Key != ConsoleKey.Escape);
								if(saisie.Key == ConsoleKey.Enter)
								{
								P.IDOwner = id;
								P.Owned = true;
								listPlayer[id].Cash = listPlayer[id].Cash - P.Prix[6];

								Console.WriteLine("You're now owner of: " + plateau.nameCase(listPlayer[id].Position));
								}
								else
									{
								Console.WriteLine("You refused to buy " + plateau.nameCase(listPlayer[id].Position));
									}

							
								
                        }
                        else
                        {
                            Console.WriteLine("You can't afford this property. The price: "+ P.Prix[6]);
                        }
						
					}



                    
					

				}
					Console.ReadKey();
			} while (mesDe.Doubler && !mesDe.Stop);
		}

		public void jail(int id)
		{
			listPlayer[id].Statut--;
			De mesDe = new De();
			if (listPlayer[id].Statut == 0) {
				Console.Clear();
				Console.WriteLine("----------------------------------------------------");
				Console.WriteLine("Tour: " + tour);
				Console.WriteLine("It's the turn of: " + listPlayer[id].Username);
				Console.WriteLine("You are in jail since " + (3 - listPlayer[id].Statut + " turn"));
				Console.WriteLine("You're now free from jail ! ");
				Console.WriteLine("Press any touch to launch the dice");
				Console.ReadKey();
				
				int forward = mesDe.PlayDe();
				ListPlayer[id].Forward(forward);
				Console.WriteLine("----------------------------------------------------");
			}
			else { 
			Console.Clear();
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Tour: " + tour);
			Console.WriteLine("It's the turn of: " + listPlayer[id].Username);
			Console.WriteLine("You are in jail since " + (3 - listPlayer[id].Statut + " turn"));
			Console.WriteLine("----------------------------------------------------");
				Console.WriteLine("Do a double or stay until 3 turn !");
				Console.WriteLine("Press any touch to launch the dice");
				Console.ReadKey();
				int forward = mesDe.PlayDe();
				if (mesDe.Doubler) { listPlayer[id].Statut = 0;
					ListPlayer[id].Forward(forward);
					Console.WriteLine("You did a double, you're free now");
				}
				else { Console.WriteLine("You failed, you stay in jail"); }
				Console.ReadKey();
			}
			//Fonction pour lancer le dé et essayer de sortir de prison
		}

	}
 }
