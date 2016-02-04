﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Data.Entities
{
    public class Task
    {
        private readonly IList<User> _users;
        public virtual long TaskId { get; set; }
        public virtual string Subject { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? DueDate { get; set; }
        public virtual DateTime? CompletedDate { get; set; }
        public virtual Status Status { get; set; }
        public virtual DateTime CreateDate { get; set; }

        public virtual IList<User> Users
        {
            get { return _users; }
        }

        public virtual User CreatedBy { get; set; }
    }
}
