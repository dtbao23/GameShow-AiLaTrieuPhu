using System;
using System.Collections.Generic;
using System.Text;

namespace DTOpoj
{
    [Serializable]
    public class QuestionForClient
    {
        public string Content { get; set; }
        public List<string> DSCauTraLoi { get; set; }

        public QuestionForClient()
        {
            DSCauTraLoi = new List<string>();
        }
    }
}
