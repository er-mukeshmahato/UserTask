using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.User
{
   public class GetUserInfo
    {
        public async Task<UserModel> GetbyId(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<UserModel>("sp_user_getbyId", sQLParams);
        }
    }
}
