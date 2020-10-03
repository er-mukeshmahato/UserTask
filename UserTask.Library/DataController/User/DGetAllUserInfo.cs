using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
   public class DGetAllUserInfo
    {
        readonly GetAllUserInfo _getalluserinfo = new GetAllUserInfo();
        public async Task<IEnumerable<UserModel>> AllUser()
        {
            return await _getalluserinfo.Get();
        }
    }
}
