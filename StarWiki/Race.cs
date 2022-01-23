using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWiki
{
	public class Race
	{
		public string Name { get; set; }
		public Planet Planet { get; set; }
		public Race_leader Race_Leader { get; set; }
	}
}
