using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Admin
    {
        [Key]
        public string Idtb_admin { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public Admin()
        {
            Idtb_admin = Guid.NewGuid().ToString();
        }
        public Admin(string id, string account, string password)
        {
            Idtb_admin = id;
            Account = account;
            Password = password;
        }
    }
}
