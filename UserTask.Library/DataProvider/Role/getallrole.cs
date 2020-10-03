using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Role
{
  public  class getallrole
    {
        public async Task<IEnumerable<Roles>> Get() =>
         await new SQLGetListAsync().ExecuteAsEnumerableAsync<Roles>("sp_role_getall");
    }
}
