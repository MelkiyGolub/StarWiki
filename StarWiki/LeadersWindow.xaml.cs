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
	/// Логика взаимодействия для LeadersWindow.xaml
	/// </summary>
	public partial class LeadersWindow : Window, INotifyPropertyChanged
	{
		public LeadersWindow()
		{
			InitializeComponent();
			DataContext = this;
		}
		private Race_leader _selectedLeader;
		public Race_leader SelectedLeader
		{
			get { return _selectedLeader; }
			set
			{
				_selectedLeader = value;
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
			get { return Data.Races; }
			set { Data.Races = value; }
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
		private void AddLeader(object sender, RoutedEventArgs e)
		{
			Leaders.Add(new Race_leader());
		}

        private void RemoveLeader(object sender, RoutedEventArgs e)
        {
			if (SelectedLeader != null)
				Leaders.Remove(SelectedLeader);
		}
    }
}