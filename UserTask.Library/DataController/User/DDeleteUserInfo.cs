using UserTask.Library.DataProvider.User;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
   public class DDeleteUserInfo
    {
        readonly DeleteUserInfo _deleteUserInfo = new DeleteUserInfo();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@UserId",id)
            };
            await _deleteUserInfo.Delete(sQLParams);
        }
    }
}
