using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Doctor
    {

        [Key]
        public string Idcard { get; set; }
        public string Name { get; set; }
        
        public string Phonenum { get; set; }
        public string TeamAccount{ get; set; }

        public Doctor()
        {
            Idcard = Guid.NewGuid().ToString();
        }
        public Doctor(string idcard, string name, string phonenum, string teamAccount)
        {
            TeamAccount = teamAccount;
            Name = name;
            Idcard = idcard;
            Phonenum = phonenum;
        }
    }
}
