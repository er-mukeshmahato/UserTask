using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
    public  class DGetUserInfo
    {
        readonly GetUserInfo _getUserinfo = new GetUserInfo();
        public async Task<UserModel> UserById(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _getUserinfo.GetbyId(sQLParams);

        }
    }
}
