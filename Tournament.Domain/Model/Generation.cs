using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tournament.Domain.Helpers;
using Tournament.Domain.Interface;

namespace Tournament.Domain.Model
{
    public class Generation
    {
        public IParticipant GetRandomParticipant(List<IParticipant> TotalParticipants, List<IMatch> matches)
            =>
            TotalParticipants
            .Where(x =>
            !matches.SelectMany(d => new[] {d.BlueCorner?.ID, d.RedCorner?.ID }).ToList()
            .Any(y=>y==x.ID))
            .ToList()
            .Random();
        public IMatch GetRandomMatch(List<IMatch> matches, Rounds rounds)
            =>
            matches
            .Where(x =>
            !rounds.Matches.Select(y => y?.ID).ToList()
            .Any(z=>z==x.ID))
            .ToList()
            .Random();
    }
}
