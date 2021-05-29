using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class GameInformation
    {
        [Key]
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string AthleteNum { get; set; }
        public int GroupNumber { get; set; }  //组号

        public int PlayOrder { get; set; }  //出场顺序
        public bool FinalGame { get; set; }
        public GameInformation()
        {
            Id = Guid.NewGuid().ToString();
        }

        public GameInformation(string id, string itemId, string athletenum, int groupNumber, int playOrder, bool finalGame)
        {
            Id = id;
            ItemId = itemId;
            AthleteNum = athletenum;
            GroupNumber = groupNumber;
            PlayOrder = playOrder;
            FinalGame = finalGame;
        }
    }
}
