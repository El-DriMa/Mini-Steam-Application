using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data
{
    public static class InMemoryDB
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Game> AllGames { get; set; } = new List<Game>();

    }
}
