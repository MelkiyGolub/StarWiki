using System;
using System.Collections.Generic;
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

namespace StarWiki
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OpenPlanets(object sender, RoutedEventArgs e)
		{
			PlanetsWindow planetsWindow = new PlanetsWindow();
			planetsWindow.ShowDialog();
		}

		private void OpenCharacters(object sender, RoutedEventArgs e)
		{
			CharactersWindow charactersWindow = new CharactersWindow();
			charactersWindow.ShowDialog();
		}

		private void OpenRaces(object sender, RoutedEventArgs e)
		{
			RaceWindow raceWindow = new RaceWindow();
			raceWindow.ShowDialog();
		}

		private void OpenRace_leaders(object sender, RoutedEventArgs e)
		{
			LeadersWindow leadersWindow = new LeadersWindow();
			leadersWindow.ShowDialog();
		}
	}
}
