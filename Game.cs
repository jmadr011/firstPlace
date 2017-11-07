using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLib
{
    public class Game
    {
        public string Team1 { get; set; }
        public int Score1 {get; set;}
        public string Team2 { get; set; }
        public int Score2 { get; set; }

        public Game() { }

        public Game( string Team1, int Score1, string Team2, int Score2)
        {
            this.Team1 = Team1;
            this.Score1 = Score1;
            this.Team2 = Team1;
            this.Score2 = Score1;
        }

        public override string ToString()
        { 
            return string.Format(Team1 + " (" + Score1 + ") - " + Team2 + " (" + Score2 + ")");
            // return string.Format("{0}, {1}, {2}, {3}", Team1, Score1, Team2, Score2);
        }
    } // Game class
}
