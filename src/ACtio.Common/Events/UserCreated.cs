using System;
using System.Collections.Generic;
using System.Text;

namespace ACtio.Common.Events
{
    public class UserCreated:IEvent
    {
        public string Email { get; }
        public string Name { get; set; }

        protected UserCreated()
        {

        }
        public UserCreated(string Email, string Name)
        {
            this.Email = Email;
            this.Name = Name;
        }
    }
}
