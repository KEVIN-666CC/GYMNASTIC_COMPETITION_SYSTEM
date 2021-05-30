using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class RefereeScore
    {
        [Key]
        public string Id { get; set; }
        public string GameInfoId { get; set; }
      
        public string RefereeId { get; set; }
        public bool ChiefReferee { get; set; }
        public double Score { get; set; }
        public double P { get; set; }
        public double D { get; set; }

        public RefereeScore()
        {
            Id = Guid.NewGuid().ToString();
        }

        public RefereeScore(string id, string gameSmallGroupId, string refereeId, bool chiefReferee, double score, double p ,double d)
        {
            Id = id;
            RefereeId = refereeId;
            ChiefReferee = chiefReferee;
            Score = score;
            P = p;
            D = d;
        }
    }
}
