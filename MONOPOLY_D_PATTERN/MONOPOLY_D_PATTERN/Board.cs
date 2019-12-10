using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MONOPOLY_D_PATTERN
{
    //Singleton pattern : only one instance of the board must be created
    //We chose to implement the thread safety singleton pattern
    sealed class Board
    {
        private Case[] plateau; //Plateau de jeu avec 39 cases.
                                // UTILISER LE DESIGN PATTERN SINGLETON POUR S'ASSURER QU'ON A QU'UNE INSTANCE DE CETTE CLASSE.
        private static Board instance=null;
        private static readonly object padlock = new object();

        //Private constructor
        private Board()
        {
            initiateBoard();

        }

        public void viewingBoard()
        {
            //Fonction d'affichage
        }

        public void initiateBoard()
        {
            List<string[]> data = ReadFile();
            plateau = new Case[40];
            for (int i = 0; i < 40; i++)
            {
                string[] row = data[i];
                if (row[1] == "J") //1 corresponding to column in csv where we can find the type of case
                {
                    plateau[i] = new Jail(Convert.ToInt32(row[0]), row[1], row[2]);
                    
                }
                else if(row[1] == "P")
                {
                    int[] price_tab = { Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]), Convert.ToInt32(row[7]), Convert.ToInt32(row[8]), Convert.ToInt32(row[9]), Convert.ToInt32(row[10]) };
                    plateau[i] = new Property(Convert.ToInt32(row[0]), row[1], row[2], price_tab);
                }
                else
                {
                    plateau[i] = new OtherCases(Convert.ToInt32(row[0]), row[1], row[2]);
                }
                

            }
        }
        public List<string[]> ReadFile()
        {
			if (!File.Exists("Monop.csv")) {
				Console.WriteLine("We download the files");
				System.Net.WebClient client = new System.Net.WebClient();
				client.DownloadFile("https://raw.githubusercontent.com/QuentinC12/MONOPOLY-GAME/master/MONOPOLY_D_PATTERN/MONOPOLY_D_PATTERN/Monop.csv", "Monop.csv");
				
			}
				StreamReader sr = new StreamReader("Monop.csv");
            string line;
            string[] row = new string[11];
            List<string[]> data = new List<string[]>();
            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',');
                data.Add(row);

            }
            return data;
        }
		public string nameCase(int numCase)
		{
			 return plateau[numCase].NameCase;
		}

		public string typeCase(int numCase)
		{
			return plateau[numCase].StateCase;
		}

	
		
        public Case[] Plateau
        {
            get { return this.plateau; }
            set { plateau = value; }
        }

        //Instance property to make the Singleton pattern work
        public static Board Instance
        {
            get {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new Board();
                    }
                    return instance;
                }
                
            }
        }
		
    }
}
