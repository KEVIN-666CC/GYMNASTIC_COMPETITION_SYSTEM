using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Coach
    {
        [Key]
        public string Idcard { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Sex { get; set; }
        
        public string TeamAccount { get; set; }
        
        public Coach()
        {
            Idcard = Guid.NewGuid().ToString();
        }

        public Coach(string idcard, string name, string phone, string sex, string teamaccount)
        {
            Idcard = idcard;
            Name = name;
            PhoneNum = phone;
            Sex = sex;
            TeamAccount = teamaccount;
        }
    }
}
