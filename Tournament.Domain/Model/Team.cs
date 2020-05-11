using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Domain.Model
{
    public class Team : Interface.IParticipant
    {
        private Guid Guid = Guid.NewGuid();
        public Guid ID { get => Guid; }
        public string TeamName { get; set; }
        public List<Interface.IParticipant> MemberOfTeams { get; set; }
        public int CountMembers { get; set; }
        public string DisplayName() => $"{TeamName}";
    }
}
