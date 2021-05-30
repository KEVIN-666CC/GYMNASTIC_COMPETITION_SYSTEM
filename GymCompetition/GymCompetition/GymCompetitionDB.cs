using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class GymCompetitionDB : DbContext
    {
        public GymCompetitionDB()
            : base("GymCompetitionDataBase")
        {
        }
        public DbSet<Admin> Tb_admin { get; set; }
        public DbSet<Team> Team { get; set; }    
        public DbSet<Leader> Tb_leader { get; set; }
        public DbSet<Doctor> Tb_doctor { get; set; }
        public DbSet<Athlete> Tb_athlete { get; set; }
        public DbSet<Coach> Tb_coach { get; set; }
        public DbSet<Referee> Tb_referee { get; set; }
        public DbSet<GameInformation> Tb_gameInformation { get; set; }
        public DbSet<Item> Tb_item { get; set; }
        public DbSet<RefereeScore> Tb_refereeScore { get; set;}
        public DbSet<PersonalItemFinalScore> Tb_PersonalItemFinalScore { get; set; }

    }
}
