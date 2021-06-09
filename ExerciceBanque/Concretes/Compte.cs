using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBanque.Concretes
{
	public class Compte
	{
		public int Numero { get; private set; }
		public double Solde { get; private set; }
		private static int newNumero = 0;

		public Compte() : this(0)
		{

		}

		public Compte(double MontantInitial)
		{
			this.Solde = MontantInitial;
			newNumero++;
			this.Numero = newNumero;
		}

		public void Ajouter(double unMontant)
		{
			this.Solde += unMontant;
		}

		public void Retirer(double unMontant)
		{
			this.Solde -= unMontant;
		}

		public override string ToString()
		{
			return "Compte n°" + this.Numero + (this.Solde >= 0 ? ": Crédit = " : ": Débit = -") + this.Solde + " Eur";
		}


	}
}
