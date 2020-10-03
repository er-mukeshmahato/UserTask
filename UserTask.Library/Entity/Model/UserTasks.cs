using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserTask.Library.Entity.Model
{
  public  class UserTasks
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
