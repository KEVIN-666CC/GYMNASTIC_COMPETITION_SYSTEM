using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Team
    {
        [Key]
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Team()
        {
            Account = Guid.NewGuid().ToString();
        }
        public Team(string account, string password, string name)
        {
            Name = name;
            Account = account;
            Password = password;
        }
    }
}
