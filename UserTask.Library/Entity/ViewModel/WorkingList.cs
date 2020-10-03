using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.Entity.ViewModel
{
   public class WorkingList
    {
        public List<List<UserTasks>> Task { get; set; }
    }
}
