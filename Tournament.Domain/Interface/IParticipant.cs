using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.Domain.Interface
{
    public interface IParticipant
    {
        Guid ID { get; }
        string DisplayName();
    }
}
