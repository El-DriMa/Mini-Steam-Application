using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data
{

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Rating { get; set; }

        public Game()
        {
            Id = 0;
            Name = string.Empty;
            Publisher = string.Empty;
            Rating = 0;
        }
        public Game(int Id, string Name, string Publisher, int Rating)
        {
            this.Id = Id;
            this.Name = Name;
            this.Publisher = Publisher;
            this.Rating = Rating;
        }
    }
}
