using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Domain.Interface
{
    public interface IMatch
    {
        public int ID { get;}
        IParticipant RedCorner { get;}
        IParticipant BlueCorner { get;}

    }
}
