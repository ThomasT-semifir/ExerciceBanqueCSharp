using ExerciceBanque.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBanque.Interfaces.Services
{
	public interface IClientService
	{
		void AjouterClient(Client newClient);

		Client RecupererClientParNumero(int numeroClient);

		string[] AjouterCompteAuClient(int numeroClient, Compte compte);

		List<Client> GetAllClients();
	}
}
