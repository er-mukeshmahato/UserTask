using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserTask.Library.Entity.Model
{
    public  class UserModel
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string CreatedOn { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string  PhoneNo { get; set; }


    }
}
