using System;
using System.Collections.Generic;
using System.Text;

namespace ACtio.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; }
        protected UserAuthenticated()
        {

        }

        public UserAuthenticated(string Email)
        {
            this.Email = Email;
        }
    }
}
