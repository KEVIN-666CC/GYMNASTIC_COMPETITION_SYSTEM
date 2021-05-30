using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            GymCompetitionService gymCompetitionService = new GymCompetitionService();

            Admin admin1 = new Admin("1", "admin", "123456");
            gymCompetitionService.AddAdmin(admin1);

            Team team1 = new Team("2019001", "123456", "潜江队");
            Team team2 = new Team("2019002", "123456", "武汉队");
            Team team3 = new Team("2019003", "123456", "仙桃队");
            Team team4 = new Team("2019004", "123456", "南京队");
            Team team5 = new Team("2019005", "123456", "上海队");
            Team team6 = new Team("2019006", "123456", "大连队");
            Team team7 = new Team("2019007", "123456", "厦门队");
            Team team8 = new Team("2019008", "123456", "北京队");
            Team team9 = new Team("2019009", "123456", "深圳队");
            Team team10 = new Team("2019010", "123456", "杭州队");


            gymCompetitionService.AddTeam(team1);
            gymCompetitionService.AddTeam(team2);
            gymCompetitionService.AddTeam(team3);
            gymCompetitionService.AddTeam(team4);
            gymCompetitionService.AddTeam(team5);
            gymCompetitionService.AddTeam(team6);
            gymCompetitionService.AddTeam(team7);
            gymCompetitionService.AddTeam(team8);
            gymCompetitionService.AddTeam(team9);
            gymCompetitionService.AddTeam(team10);

            Leader leader1 = new Leader("429005199908190107", "leader1", "17362447819", team1.Account);
            Leader leader2 = new Leader("429005199908190108", "leader2", "17362447819", team1.Account);

            gymCompetitionService.AddLeader(leader1);
            gymCompetitionService.AddLeader(leader2);

            Doctor doctor1 = new Doctor("429005199908190100", "doc1", "17362447819", team1.Account);
            gymCompetitionService.AddDoctor(doctor1);

            Coach coach1 = new Coach("429005199908190120", "doc1", "17362447819", "男", team1.Account);
            gymCompetitionService.AddCoach(coach1);

            Referee referee1 = new Referee("4290051999000000000", "referee1", "17362447819", team1.Account);
            gymCompetitionService.AddReferee(referee1);

            Dictionary<int, string> MItemName = new Dictionary<int, string>
            {
                { 1, "单杠" },
                { 2, "双杠" },
                { 3, "吊环" },
                { 4, "跳马" },
                { 5, "自由体操" },
                { 6, "鞍马" },
                { 7, "蹦床" }
            };

            Dictionary<int, string> WItemName = new Dictionary<int, string>
            {
                { 1, "跳马" },
                { 2, "高低杠" },
                { 3, "平衡木" },
                { 4, "自由体操" },
                { 5, "蹦床" }
            };

            Dictionary<int, string> ItemName = new Dictionary<int, string>
            {
                { 1, "单杠" },
                { 2, "双杠" },
                { 3, "吊环" },
                { 4, "跳马" },
                { 5, "自由体操" },
                { 6, "鞍马" },
                { 7, "蹦床" },
                { 8, "高低杠" },
                { 9, "平衡木" }
            };

            Dictionary<int, string> age_sexGroup = new Dictionary<int, string>
            {
                { 1, "7-8男子组" },
                { 2, "9-10男子组" },
                { 3, "11-12男子组" },
                { 4, "7-8女子组" },
                { 5, "9-10女子组" },
                { 6, "11-12女子组" }
            };

            Dictionary<int, string> sex_group = new Dictionary<int, string>
            {
                { 1, "男" },
                { 2, "女" }
            };

            int id = 1;
            for(int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Item item = new Item(id.ToString(), MItemName[i], age_sexGroup[j]);
                    gymCompetitionService.AddItem(item);
                    id++;
                }
            }
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 4; j <= 6; j++)
                {
                    Item item = new Item(id.ToString(), WItemName[i], age_sexGroup[j]);
                    gymCompetitionService.AddItem(item);
                    id++;
                }
            }

            Athlete athlete1 = new Athlete("429005199908190000", "athlete_1", 10, sex_group[1], team1.Account);
            gymCompetitionService.AddAthlete(athlete1);

        }

    }
}
