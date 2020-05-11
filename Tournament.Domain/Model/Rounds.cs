using System;
using System.Collections.Generic;
using System.Text;
using Tournament.Domain.Interface;

namespace Tournament.Domain.Model
{
    public delegate void EndRoundsDelegate(object sender, object sendObject);
    public class Rounds
    {
        public int ID { get; set;}
        public List<IMatch> Matches { get; set; }
        public event EndRoundsDelegate EndRounds;
    }
}
