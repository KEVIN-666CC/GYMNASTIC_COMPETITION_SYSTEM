using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class PersonalItemFinalScore
    {
        [Key]
        public string Id { get; set; }
        public string ItemId { get; set; }

        public string AthleteNum { get; set; }
        public bool FinalGame { get; set; }
        public double FinalScore { get; set; }

        public PersonalItemFinalScore()
        {
            Id = Guid.NewGuid().ToString();
        }

        public PersonalItemFinalScore(string id, string itemId, string athleteNum, bool finalGame, double finalScore)
        {
            Id = id;
            ItemId = itemId;
            AthleteNum = athleteNum;
            FinalGame = finalGame;
            FinalScore = finalScore;
        }
    }
}
