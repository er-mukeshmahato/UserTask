using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Library.Entity.ViewModel
{
  public  class UserViewModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public int VendorId { get; set; }
        public int AdministrationId { get; set; }
        public string CreatedDate { get; set; }

        public IFormFile Images { get; set; }
    }
}
