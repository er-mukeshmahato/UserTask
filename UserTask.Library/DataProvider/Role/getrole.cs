using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Role
{
  public  class getrole
    {
        public async Task<Roles> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<Roles>("sp_role_getbyid", sQLParams);
        }
    }
}
