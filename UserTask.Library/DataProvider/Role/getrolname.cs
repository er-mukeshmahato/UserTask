using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Role
{
   public class getrolname
    {
        public async Task<Roles> Getbyrolename(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<Roles>("sp_role_getbyname", sQLParams);
        }
    }
}
