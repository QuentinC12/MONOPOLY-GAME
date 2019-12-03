using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MONOPOLY_D_PATTERN
{
    class Board
    {
        private Case[] plateau; //Plateau de jeu avec 39 cases.
                                // UTILISER LE DESIGN PATTERN SINGLETON POUR S'ASSURER QU'ON A QU'UNE INSTANCE DE CETTE CLASSE.

        public Board()
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
            StreamReader sr = new StreamReader("C:/Users/qcall/Documents/GitHub/MONOPOLY-GAME/MONOPOLY_D_PATTERN/MONOPOLY_D_PATTERN/bin/Debug/Monop.csv");
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
		
    }
}
