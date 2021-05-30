using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Item
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string AgeAndSexGroup { get; set; }

        public Item()
        {

            Id = Guid.NewGuid().ToString();
        }

        public Item(string id, string name, string ageAndSexGroup)
        {
            Id = id;
            Name = name;
            AgeAndSexGroup = ageAndSexGroup;
        }


    }
}
