using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Referee
    {

        [Key]
        public string Idcard { get; set; }
        public string Name { get; set; }
        public string Phonenum { get; set; }

        public string TeamAccount { get; set; }

        public Referee()
        {
            Idcard = Guid.NewGuid().ToString();
        }

        public Referee(string idcard, string name, string phonenum, string team)
        {
            Idcard = idcard;
            Name = name;
            Idcard = idcard;
            Phonenum = phonenum;
            TeamAccount = team;
        }
    }
}
