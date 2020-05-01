using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30project_gametracker
{
    public enum GameGenre{Action, Action_adventure,Horror,Strategy,RPG,Puzzle}
    public class  games:IComparable
    {
        public string Name { get; set; }
        public GameGenre Genre1 { get; set; }
        public string Description { get; set; }

        public string Format { get; set; }

        public games()
		{

		}
		
		public games(string Name, GameGenre Genre1, string Format)
		{

		}

		public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
