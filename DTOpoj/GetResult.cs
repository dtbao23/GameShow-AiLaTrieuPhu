using System;
using System.Collections.Generic;
using System.Text;

namespace DTOpoj
{
    [Serializable]
    public class GetResult : IComparable<GetResult>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SoCauTraLoi { get; set; }
        public int SoCauDung { get; set; }

        public GetResult()
        {
            SoCauTraLoi = 0;
            SoCauDung = 0;
        }

        public int CompareTo(GetResult other)
        {
            return other.SoCauDung.CompareTo(this.SoCauDung);
        }
    }
}
