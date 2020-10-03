using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserRole
{
   public class getuserrole
    {
        public async Task<UserRoles> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<UserRoles>("sp_userrole_byuserid", sQLParams);
        }
    }
}
