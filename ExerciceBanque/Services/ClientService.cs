using ExerciceBanque.Concretes;
using ExerciceBanque.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBanque.Services
{

	public class ClientService : IClientService
	{
		private List<Client> listeClients = new List<Client> {new Client("Timio", "Thomas", 30), new Client ("Dupont", "Jean", 65)};

		public void AjouterClient(Client newClient)
		{
			listeClients.Add(newClient);
		}

		public Client RecupererClientParNumero(int numeroClient)
		{
			foreach (Client client in listeClients)
			{
				if (client.Numero == numeroClient)
				{
					return client;
				}
			}
			return null;
		}

		public string[] AjouterCompteAuClient(int numeroClient, Compte compte)
		{
			Client client = RecupererClientParNumero(numeroClient);
			return client.AjouterCompte(compte);
		}

		public List<Client> GetAllClients()
		{
			return listeClients;
		}
	}
}
