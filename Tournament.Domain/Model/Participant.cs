using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Domain.Model
{
    public class Participant : Interface.IParticipant
    {
        private Guid Guid = Guid.NewGuid();
        public Guid ID { get => Guid; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int WinnerStatic { get; private set; }
        public int MatchStatic { get; private set; }
        public string DisplayName() => $"{Surname} {Name}";
        public Participant(string name, string surname, int winnerstatic, int matchstatic)
        {
            Name = name;
            Surname = surname;
            WinnerStatic = winnerstatic;
            MatchStatic = matchstatic;
        }
    }
}
