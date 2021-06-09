using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBanque.Concretes
{
	public class Client
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public int Age { get; set; }
		public int Numero { get; private set; }
		private Compte[] Comptes { get; set; } = new Compte[5];

		protected static int newNumero = 0;

		public Client()
		{

		}

		public Client(string nom, string prenom, int age)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.Age = age;
			newNumero++;
			this.Numero = newNumero;
		}

		public override string ToString()
		{
			return $"{this.Numero}: {this.Nom} {this.Prenom}, âgé de {this.Age}";
		}

		public String[] AjouterCompte(Compte unCompte)
		{
			for (int i = 0; i < Comptes.Length; i++)
			{
				if (Comptes[i] == null)
				{
					Comptes[i] = unCompte;
					return new string[2] { "Effectué", $"compte {unCompte.Numero} ajouté" };
				}
				else if (Comptes[i] != null && i == Comptes.Length - 1)
				{
					return new string[2] { "Erreur", "Nombre Maximum de comptes atteint" };
				}
			}
			return null;
		}

		public Compte GetCompte(int numeroCompte)
		{
			foreach (Compte compte in Comptes)
			{
				if (compte.Numero == numeroCompte)
				{
					return compte;
				}
			}
			return null;
		}

		public Compte[] GetListeComptes()
		{
			return this.Comptes;
		}
	}
}
