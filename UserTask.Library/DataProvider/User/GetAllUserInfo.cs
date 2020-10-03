using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.User
{
    public class GetAllUserInfo
    {
        public async Task<IEnumerable<UserModel>> Get() =>
          await new SQLGetListAsync().ExecuteAsEnumerableAsync<UserModel>("sp_user_getall");
    }
}
