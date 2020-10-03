using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.Model;
using UserTask.Library.Entity.ViewModel;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
    public class DCreateuserInfo
    {
        readonly CreateUserInfo _createUserinfo = new CreateUserInfo();
        public async Task Create(UserModel user)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@email",user.Email),
                new SQLParam("@password",user.Password),
              
                new SQLParam("@fullname",user.FullName),
                new SQLParam("@address",user.Address),
                new SQLParam("@phone",user.PhoneNo)

               


            };
            await _createUserinfo.Create(sQLParams);
        }
    }
}
