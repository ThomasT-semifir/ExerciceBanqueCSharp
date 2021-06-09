using ExerciceBanque.Concretes;
using ExerciceBanque.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfaceBanque
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ClientService clientService;
		public ObservableCollection<Client> ListeClients { get; set; }
		public MainWindow()
		{
			clientService = new ClientService();
			ListeClients = this.GetAllClients();
			InitializeComponent();
			this.listview.ItemsSource = ListeClients;
		}

		public void ClicAjouterClient(string nomClient, string prenomClient, int age)
		{
			Client client = new Client(nomClient, prenomClient, age);
			clientService.AjouterClient(client);
		}

		public ObservableCollection<Client> GetAllClients()
		{
			ObservableCollection<Client> clients = new ObservableCollection<Client>();
			foreach(Client client in clientService.GetAllClients())
			{
				clients.Add(client);
			}

			return clients;
		}
	}
}
