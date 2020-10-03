using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Library.Entity.Model
{
   public class Activities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public bool Assign { get; set; }

        public string AssignedTime { get; set; }
        public bool Completed { get; set; }

        public string CompletedTime { get; set; }
        public String  Status { get; set; }
    }
}
