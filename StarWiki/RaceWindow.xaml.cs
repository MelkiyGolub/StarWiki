using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace StarWiki
{
    /// <summary>
    /// Логика взаимодействия для RaceWindow.xaml
    /// </summary>
    public partial class RaceWindow : Window, INotifyPropertyChanged
    {
        public RaceWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private Race _selectedRace;
        public Race SelectedRace
        {
            get => _selectedRace;

            set
            {
                _selectedRace = value;
                Signal();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
        private void AddRace(object sender, RoutedEventArgs e)
        {
            Races.Add(new Race());
        }

        private void RemoveRaces(object sender, RoutedEventArgs e)
        {
            if (SelectedRace != null)
                Races.Remove(SelectedRace);
        }


    }
}
