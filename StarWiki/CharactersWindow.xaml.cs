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
	/// Логика взаимодействия для CharactersWindow.xaml
	/// </summary>
	public partial class CharactersWindow : Window, INotifyPropertyChanged
	{
		public CharactersWindow()
		{
			InitializeComponent();
			DataContext = this;
		}
		private Character _selectedCharacter;
		public Character SelectedCharacter
		{
			get { return _selectedCharacter; }
			set
			{
				_selectedCharacter = value;
				Signal();
			}

		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void Signal([CallerMemberName] string name = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public ObservableCollection<Race> Races
        {
			get => Data.Races;
			set => Data.Races = value;
        }

		public ObservableCollection<Character> Characters
		{
			get { return Data.Characters; }
			set { Data.Characters = value; }
		}
		public ObservableCollection<Planet> Planets
		{
			get { return Data.Planets; }
			set { Data.Planets = value; }
		}
		public ObservableCollection<Race_leader> Leaders
		{
			get { return Data.Leaders; }
			set { Data.Leaders = value; }
		}
		private void AddCharacter(object sender, RoutedEventArgs e)
		{
			Characters.Add(new Character());
		}

		private void RemoveCharacter(object sender, RoutedEventArgs e)
		{
			if (SelectedCharacter != null)
				Characters.Remove(SelectedCharacter);
		}
	}
}
