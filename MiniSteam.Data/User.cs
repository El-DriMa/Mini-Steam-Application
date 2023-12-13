using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Game> Games { get; set; }

        public User()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Games = new List<Game>();
        }
        public User(int Id, string Name, string Email, string Password, List<Game> Games)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Games = Games;
        }
    }
}
