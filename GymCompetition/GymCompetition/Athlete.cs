using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Athlete
    {
        [Key]
        public string Idcard { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Athnum { get; set; }
        public string CulturalAchivement { get; set; }

        public string TeamAccount { get; set; }

        public Athlete()
        {
            Athnum = Guid.NewGuid().ToString();
        }
        public Athlete(string idcard, string name, int age, string sex, string teamAccount)
        {
            Idcard = idcard;
            Name = name;
            Age = age;
            Sex = sex;
            TeamAccount = teamAccount;
        }

        public Athlete(string idcard, string name, int age, string sex, string athnum,
            string culturalAchivement, string teamAccount)
        {
            Idcard = idcard;
            Name = name;
            Age = age;
            Sex = sex;
            Athnum = athnum;
            CulturalAchivement = culturalAchivement;
            TeamAccount = teamAccount;
        }

       
    }
}
