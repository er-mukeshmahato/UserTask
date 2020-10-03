using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Library.Entity.Model
{
   public class Activitydata
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string AssignDate { get; set; }
        public string CompleteDate { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

    }
}
