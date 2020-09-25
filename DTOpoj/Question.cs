using System;
using System.Collections.Generic;

namespace DTOpoj
{
    [Serializable]
    public class Question
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public List<string> ListAnswer { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Answer { get; set; }
        public Question()
        {
            ListAnswer = new List<string>();
        }
    }
}
