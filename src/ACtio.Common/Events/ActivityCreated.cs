using System;
using System.Collections.Generic;
using System.Text;

namespace ACtio.Common.Events
{
    public class ActivityCreated:IAuthenticatedEvent
    {
        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid Id, Guid UserId, string Category, string Name, string Description, DateTime CreatedAt)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.Category = Category;
            this.Name = Name;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
