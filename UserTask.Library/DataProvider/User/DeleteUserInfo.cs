using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.User
{
    public class DeleteUserInfo
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
           await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_user_delete", sQLParams);
    }
}
