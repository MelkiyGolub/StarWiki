using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StarWiki
{
	/// <summary>
	/// Логика взаимодействия для PlanetsWindow.xaml
	/// </summary>
	public partial class PlanetsWindow : Window, INotifyPropertyChanged
	{
		public PlanetsWindow()
		{
			InitializeComponent();
			DataContext = this;
		}
		private Planet _selectedPlanet;
		public Planet SelectedPlanet
		{
			get { return _selectedPlanet; }
			set
			{
				_selectedPlanet = value;
				Signal();
			}

		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void Signal([CallerMemberName] string name = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public ObservableCollection<Planet> Planets
		{
			get { return Data.Planets; }
			set { Data.Planets = value; }
		}
		private void AddPlanet(object sender, RoutedEventArgs e)
		{
			Planets.Add(new Planet());
		}

		private void RemovePlanet(object sender, RoutedEventArgs e)
		{
			if (SelectedPlanet != null)
				Planets.Remove(SelectedPlanet);
		}
	}
}
