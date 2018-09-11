using System;
using System.Collections.Generic;
using System.Text;

namespace ACtio.Common.Events
{
    public interface IAuthenticatedEvent
    {
        Guid UserId { get; set; }
    }
}
