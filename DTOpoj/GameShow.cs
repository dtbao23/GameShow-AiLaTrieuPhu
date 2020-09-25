using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOpoj;

namespace DoAnCuoiKi
{
    [Serializable]
    public class GameShow
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Dictionary<int, Player> ListPlayers = new Dictionary<int, Player>();

        public Dictionary<int, List<PlayerScore>> ListUserScores = new Dictionary<int, List<PlayerScore>>();
        Dictionary<int, Question> ListQuestions { get; set; }

        public List<GetResult> lstThongKeKetQua = new List<GetResult>();

        public List<int> listIdDiemCaoNhat = new List<int>();

        public void LoadListQuestions(List<Question> lstCauHoi)
        {
            ListQuestions = new Dictionary<int, Question>();
            foreach (Question item in lstCauHoi)
            {
                ListQuestions.Add(item.ID, item);
            }
        }

        public void CheckAnswer(int playerId, int questionId, string answer)
        {
            List<PlayerScore> lstPlayerScores = null;
            var playerScore = new PlayerScore()
            {
                PlayerId = playerId,
                QuestionId = questionId,
                Answer = answer,
                Result = (answer == ListQuestions[questionId].Answer)
            };

            if (ListUserScores.ContainsKey(playerId))
            {
                lstPlayerScores = ListUserScores[playerId];
                lstPlayerScores.Add(playerScore);
            }

            else
            {
                ListUserScores.Add(playerId, new List<PlayerScore>() { playerScore });
            }
        }
        public void ThongKeKetQua()
        {            
            foreach (int id in ListUserScores.Keys)
            {
                GetResult tk = new GetResult();
                tk.ID = id;
                tk.SoCauTraLoi = ListUserScores[id].Count;
                foreach (PlayerScore playerScore in ListUserScores[id])
                {
                    if (playerScore.Result)
                    {
                        tk.SoCauDung++;
                    }
                }
                lstThongKeKetQua.Add(tk);
            }
            lstThongKeKetQua.Sort();

            //int max = lstThongKeKetQua[0].SoCauDung;
            //foreach (GetResult tk in lstThongKeKetQua)
            //{
            //    if (tk.SoCauDung == max)
            //    {
            //        listIdDiemCaoNhat.Add(tk.ID);
            //    }
            //}
        }
    }
}
