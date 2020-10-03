using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.User
{
   public class CreateUserInfo
    {
        public async Task Create(List<SQLParam> sQLParams) =>
           await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_user_add", sQLParams);
    }
}
