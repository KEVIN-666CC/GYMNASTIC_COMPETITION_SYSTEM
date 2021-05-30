using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCompetitionTest
{
    public class GymCompetitionService
    {
        public static int MaxAthletesPerGroup = 6;
        public static int MaxAthletesPerGame = 5;
        public static int GroupGradeCount =4;
        public static string HostTeamAccount = "2019001";
        public static string CurrentGameInfoId = "1";

        //Add
        public void AddAdmin(Admin admin)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_admin.Add(admin);
                db.SaveChanges();
            }
        }
        public void AddTeam(Team team)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Team.Add(team);
                db.SaveChanges();
            }
        }
        public void AddLeader(Leader leader)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_leader.Add(leader);
                db.SaveChanges();
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_doctor.Add(doctor);
                db.SaveChanges();
            }
        }
        public void AddCoach(Coach coach)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_coach.Add(coach);
                db.SaveChanges();
            }
        }
        public void AddReferee(Referee referee)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_referee.Add(referee);
                db.SaveChanges();
            }
        }
        public void AddAthlete(Athlete athlete)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_athlete.Add(athlete);
                db.SaveChanges();
            }
        }
        public void AddItem(Item item)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_item.Add(item);
                db.SaveChanges();
            }
        }
        public void AddGameInformation(GameInformation gameInformation)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_gameInformation.Add(gameInformation);
                db.SaveChanges();
            }
        }
        public void AddRefereeScore(RefereeScore refereeScore)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_refereeScore.Add(refereeScore);
                db.SaveChanges();
            }
        }
        public void AddPersonalItemFinalScore(PersonalItemFinalScore personalItemFinalScore)
        {
            using(var db= new GymCompetitionDB())
            {
                db.Tb_PersonalItemFinalScore.Add(personalItemFinalScore);
                db.SaveChanges();
            }
        }

        //登录
        public int Login(string temp1, string temp2)
        {

            using (var db = new GymCompetitionDB())
            {
                if (db.Tb_admin.Where(m => m.Account == temp1 && m.Password == temp2).ToList().Count > 0)
                {
                    return 1;
                }
                else if (db.Team.Where(m => m.Account == temp1 && m.Password == temp2).ToList().Count > 0)
                {
                    return 2;
                }
                else if (db.Tb_referee.Where(m => m.Idcard == temp1 && m.Name == temp2).ToList().Count > 0)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        //通过 成员账号/身份证号查找特定成员
        public List<Team> SearchTeamByAccount(string account)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Team.Where(m => m.Account == account).ToList();
            }
        }
        public List<Leader> SearchLeaderByIdCard(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_leader.Where(m => m.Idcard == temp).ToList();
            }
        }
        public List<Doctor> SearchDoctorByIdCard(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_doctor.Where(m => m.Idcard == temp).ToList();
            }
        }
        public List<Athlete> SearchAthleteByIdCard(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_athlete.Where(m => m.Idcard == temp).ToList();
            }
        }
        public List<Athlete> SearchAthleteByAthleteNum(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_athlete.Where(m => m.Athnum == temp).ToList();
            }
        }
        public List<Coach> SearchCoachByIdCard(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_coach.Where(m => m.Idcard == temp).ToList();
            }
        }
        public List<Referee> SearchRefereeByIdCard(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_referee.Where(m => m.Idcard == temp).ToList();
            }
        }
        public List<GameInformation> SearchGameInfoById(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_gameInformation.Where(m => m.Id == temp).ToList();
            }
        }
        public List<RefereeScore> SearchRefereeScoreById(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_refereeScore.Where(m => m.Id == temp).ToList();
            }
        }
        public List<Item> SearchItemById(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_item.Where(m => m.Id == temp).ToList();
            }
        }
        public List<RefereeScore> SearchRefereeScoreByGameInfoId(string temp)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_refereeScore.Where(item => item.GameInfoId == temp).ToList();
            }
        }
        public List<RefereeScore> SearchRefereeScoreByRefereeIdAndGameInfo(string gameInfo, string refereeId)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_refereeScore.Where(m => m.RefereeId == refereeId && m.GameInfoId == gameInfo).ToList();
            }
        }

        public List<GameInformation> SearchGameInfosByItemIdAndGroupNum(string itemId, int groupNum)
        {
            using(var db = new GymCompetitionDB())
            {
                return db.Tb_gameInformation.Where(m => (m.ItemId == itemId) && (m.GroupNumber == groupNum)).ToList();
            }
        }

        //通过 队账号 查找相应的成员
        public List<Team> QueryAllTeams()
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Team.ToList();
            }
        }
        public List<Leader> QueryLeadersByTeamAccout(string teamAccount)
        {
            using(var db= new GymCompetitionDB())
            {
                return db.Tb_leader.Where(m => m.TeamAccount == teamAccount).ToList();
            }
        }
        public List<Doctor> QueryDoctorsByTeamAccount(string teamAccount)
        {
            using(var db = new GymCompetitionDB())
            {
                return db.Tb_doctor.Where(m => m.TeamAccount == teamAccount).ToList();
            }
        }
        public List<Athlete> QueryAthletesByTeamAccount(string teamAccount)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_athlete.Where(m => m.TeamAccount == teamAccount).ToList();
            }
        }
        public List<Coach> QueryCoachByTeamAccount(string teamAccount)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_coach.Where(m => m.TeamAccount == teamAccount).ToList();
            }
        }
        public List<Referee> QueryRefereeByTeamAccount(string teamAccount)
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_referee.Where(m => m.TeamAccount == teamAccount).ToList();
            }
        }
        public List<GameInformation> QueryGameInformationById()
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_gameInformation.ToList();
            }
        }
        public List<Item> QueryItems()
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_item.ToList();
            }
        }
        public List<RefereeScore> QueryRefereeScore()
        {
            using (var db = new GymCompetitionDB())
            {
                return db.Tb_refereeScore.ToList();
            }
        }

        //更新 表
        public void UpdateTeam(Team team)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Team.Attach(team);
                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateLeader(Leader leader)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_leader.Attach(leader);
                db.Entry(leader).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateDoctor(Doctor doctor)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_doctor.Attach(doctor);
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateAthlete(Athlete athlete)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_athlete.Attach(athlete);
                db.Entry(athlete).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateCoach(Coach coach)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_coach.Attach(coach);
                db.Entry(coach).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateReferee(Referee referee)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_referee.Attach(referee);
                db.Entry(referee).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateGameInfo(GameInformation gameInformation)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_gameInformation.Attach(gameInformation);
                db.Entry(gameInformation).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateRefereeScore(RefereeScore refereeScore)
        {
            using (var db = new GymCompetitionDB())
            {
                db.Tb_refereeScore.Attach(refereeScore);
                db.Entry(refereeScore).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        //编排 运动员号码 000到999，女运动员为双号，男运动员为单号，东道主排在最后
        public void ArrangeNumber(string HostTeamAccount)
        {
            using (var db = new GymCompetitionDB())
            {
                int mNum = 001, wNum = 000;
                foreach(Athlete athlete in db.Tb_athlete)
                {
                    if (athlete.TeamAccount != HostTeamAccount)
                    {
                        if (athlete.Sex == "m")
                        {
                            athlete.Athnum = mNum.ToString();
                            
                            mNum += 2;
                        }
                        else
                        {
                            athlete.Athnum = wNum.ToString();
                            wNum += 2;
                        }
                        UpdateAthlete(athlete);
                    }
                }
                foreach (Athlete athlete in db.Tb_athlete)
                {
                    if (athlete.TeamAccount == HostTeamAccount)
                    {
                        if (athlete.Sex == "男")
                        {
                            athlete.Athnum = mNum.ToString();
                            mNum += 2;
                        }
                        else
                        {
                            athlete.Athnum = wNum.ToString();
                            wNum += 2;
                        }
                        UpdateAthlete(athlete);
                    }
                }

            }
        }

        //填报时采用的身份证号 代表 athnum， 这里进行修改。
        public void AlterAthnumInGameInfo()
        {
            using(var db = new GymCompetitionDB())
            {
                foreach (GameInformation gameInformation in db.Tb_gameInformation)
                {
                    if (SearchAthleteByIdCard(gameInformation.AthleteNum).Count > 0)
                    {
                        gameInformation.AthleteNum = SearchAthleteByIdCard(gameInformation.AthleteNum)[0].Athnum;
                        UpdateGameInfo(gameInformation);
                    }
                }
            }
        }


        //查找 同一项目同一组号内的人数
        public int GetItemGroupCount(string itemId, int n)
        {
            using (var db = new GymCompetitionDB())
            {
                return (db.Tb_gameInformation.Where(m => m.ItemId == itemId && m.GroupNumber == n).ToList().Count);
            }
        }


        //设置 组号 出场顺序
        public void ArrangeGroups()
        {
            using (var db = new GymCompetitionDB())
            {
                int count = 0;
                int tag = 1;
                foreach (GameInformation gameInformation in db.Tb_gameInformation)
                {
                    tag = 1;
                    while (true)
                    {                        
                        count = GetItemGroupCount(gameInformation.ItemId, tag);
                        if (count < 8)
                        {
                            gameInformation.GroupNumber = tag;
                            gameInformation.PlayOrder = count + 1;
                            UpdateGameInfo(gameInformation);
                            break;
                        }
                        else
                        {
                            tag++;
                        }
                    } 
                }
            }
        }

        //获取当前比赛的信息
        public GameInformation CurrentGameInfo(int temp)
        {
            using (var db = new GymCompetitionDB())
            {
                List<GameInformation> gameInfo = db.Tb_gameInformation
                    .OrderBy(item => item.ItemId)
                    .ThenBy(item => item.GroupNumber)
                    .ThenBy(item => item.PlayOrder).ToList();
                if (gameInfo.Count >= temp)
                {
                    return gameInfo[temp - 1];
                }
                else
                {
                    return null;
                }
                
            }
        }

        //显示单项小组内个人排名
        public object[][] GetGroupTotalScore(RefereeScore chiefRefereeScore)
        {
            object[][] totalScoreView = new object[8][];
           
            int index = 0;
            string itemId = SearchGameInfoById(chiefRefereeScore.GameInfoId)[0].ItemId;
            int groupNum = SearchGameInfoById(chiefRefereeScore.GameInfoId)[0].GroupNumber;
            List<GameInformation> gameInfos = SearchGameInfosByItemIdAndGroupNum(itemId, groupNum);
            foreach(GameInformation gameInfo in gameInfos)
            {
                List<RefereeScore> ts = SearchRefereeScoreByGameInfoId(gameInfo.Id);
                object[] line = new object[5];
                for (int i = 0; i < ts.Count; i++)
                {
                    if (ts[i].ChiefReferee)
                    {
                        line[2] = ts[i].P;
                        line[3] = ts[i].D;
                        ts.RemoveAt(i);
                        break;
                    }
                }
                double[] scores = ts.Select(item => item.Score).ToArray();
                Array.Sort(scores);
                double sum = 0;
                for (int i = 1; i <= ts.Count - 2; i++)
                {
                    sum += scores[i];
                }
                double average = sum / (ts.Count - 2);

                line[0] = gameInfo.AthleteNum;
                line[1] = average * ts.Count + Convert.ToDouble(line[3]) - Convert.ToDouble(line[2]);
                line[4] = 0;
                totalScoreView[index++] = line;

                PersonalItemFinalScore personalItemFinalScore = new PersonalItemFinalScore(
                    index.ToString(), itemId, line[0].ToString(), false, Convert.ToDouble(line[1]));
                AddPersonalItemFinalScore(personalItemFinalScore);
            }
            for(int i = 0; i< index -1; i++)
            {
                for(int j = 1; j < index - i; j++)
                {
                    if (Convert.ToDouble(totalScoreView[j-1][1]) < Convert.ToDouble(totalScoreView[j][1]))
                    {
                        object[] line = new object[5];
                        line = totalScoreView[j-1];
                        totalScoreView[j-1] = totalScoreView[j];
                        totalScoreView[j] = line;
                    }
                }
            }
            for(int i = 0; i < index; i++)
            {
                totalScoreView[i][4] = i + 1;
            }
            return totalScoreView;
        } 


        //得到决赛名单
        public void GetFinalGameAthletes()
        {
            using(var db = new GymCompetitionDB())
            {
                IEnumerable<IGrouping<string, PersonalItemFinalScore>> finalScores = db.Tb_PersonalItemFinalScore
                    .OrderBy(n => n.FinalScore)
                    .GroupBy(m => m.ItemId)
                    .ToList();

                foreach (IGrouping<string, PersonalItemFinalScore> item in finalScores)
                {
                    int count = 0;
                    foreach(PersonalItemFinalScore finalScore in item)
                    {
                        if (count++ < 8)
                        {
                            db.Tb_gameInformation.Where(
                                info => info.ItemId == item.ToString() && info.AthleteNum == finalScore.AthleteNum)
                                .ToList()[0].FinalGame 
                                = true;
                        }
                    }
                }
            }
        }

        
    }
}
