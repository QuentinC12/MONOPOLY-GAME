﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONOPOLY_D_PATTERN
{
	class Player
	{
		private static int nbPlayer;
		private int idPlayer; //Id du player
		private int position; //position sur le plateau 0-39
		private int cash; //Cash qu'à le joueur
		private int statut; //Statut comme dit auparavant 4 -> 1er tour de prison ... 0 libre.
		private string username; //Nom du joueur !
		private int nbGare;
		private int cashDepart = 1500;
		
		//private Case[] tabProperty; //Liste des propriétés possédées

		public Player()
		{
			nbPlayer++;
			idPlayer = nbPlayer;
			position = 0;
			cash = cashDepart;
			statut = 0;
			username = "unknow";
			nbGare = 0;

		}

		
		public Player(int cash, int statut, string username)
		{
			nbPlayer++;
			idPlayer = nbPlayer;
			position = 0;
			this.cash = cash;
			this.statut = statut;
			this.username = username;
			nbGare = 0;

		}

		public Player(string username)
		{
			nbPlayer++;
			idPlayer = nbPlayer;
			position = 0;
			this.cash = cashDepart;
			this.statut = 0;
			this.username = username;
			nbGare = 0;

		}

		public string Username
		{
			get { return username; }
		}

		public int Cash
		{
			get { return cash; }
			set {  cash = value; }
		}


		public int Statut
		{
			get { return statut; }
			set { statut = value; }
		}
		public int Position
		{
			get { return position; }
			set { position = value; }
		}

		public int NbGare
			{
			get{return nbGare;}
			set{nbGare=value;}
			}
		public void Forward(int nb)
		{
			position += nb;
			if(position>39)
			{
				cash = cash + 200;
				position = position - 40;
			}
			if(position == 30)
			{
				position = 10;
				statut = 3;
				
			}
		}

		public override string ToString()
		{
			return "Joueur "+username+", A IMPLEMENTER ";
		}
		//FAIRE LES GETTER AND SETTER
		//FAIRE GET SET Du tab Property 
		public void AddProperty(int idProperty) //Achat d'une propriete
			{

			}
	}
}
