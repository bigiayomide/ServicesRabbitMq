using System;
using System.Collections.Generic;
using System.Text;

namespace ACtio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Reason { get; }

        public string Code { get; }
        public string Email { get; }

        public CreateUserRejected(string Reason, string Code,string Email)
        {
            this.Reason = Reason;
            this.Code = Code;
            this.Email = Email;
        }
        protected CreateUserRejected()
        {

        }
    }
}
