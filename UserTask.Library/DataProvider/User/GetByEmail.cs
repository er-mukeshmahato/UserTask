using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.User
{
   public class GetByEmail
    {
        public async Task<UserModel> Getbyemail(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<UserModel>("sp_user_getbyemail", sQLParams);
        }
    }
}
