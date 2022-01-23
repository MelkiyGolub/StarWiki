using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StarWiki
{
	public class Data
	{
		public static ObservableCollection<Race>
			Races { get; set; } = new ObservableCollection<Race>();

		public static ObservableCollection<Planet>
			Planets { get; set; } = new ObservableCollection<Planet>();

		public static ObservableCollection<Race_leader>
			Leaders { get; set; } = new ObservableCollection<Race_leader>();

		public static ObservableCollection<Character>
			Characters { get; set; } = new ObservableCollection<Character>();

	}
}
