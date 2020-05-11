using System;
using System.Collections.Generic;
using System.Text;
using Tournament.Domain.Interface;

namespace Tournament.Domain.Model
{
    public delegate void MatchEndedDelegate(object sender, object sendObject);
    public class Match:Interface.IMatch
    {
        public IParticipant RedCorner { get; private set; }
        public IParticipant BlueCorner { get; private set; }
        public event MatchEndedDelegate EndMatch;
        private IParticipant PairWinner;
        public int ID { get; private set; }
    }
}
