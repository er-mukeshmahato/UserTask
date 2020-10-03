using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
  public  class DUpdateUserInfo
    {
        readonly UpdateUserInfo _updateUserinfo = new UpdateUserInfo();
        public async Task Update(UserModel user)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {    
                new SQLParam("@id",user.Id),
                new SQLParam("@email",user.Email),
                new SQLParam("@password",user.Password),
               
                new SQLParam("@fullname",user.FullName),
                new SQLParam("@address",user.Address),
                new SQLParam("@phone",user.PhoneNo)

            };
            await _updateUserinfo.Update(sQLParams);
        }
    }
}
