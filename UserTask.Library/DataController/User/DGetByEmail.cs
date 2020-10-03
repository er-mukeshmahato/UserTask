using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
   public class DGetByEmail
    {
        readonly GetByEmail _getUserinfo = new GetByEmail();
        public async Task<UserModel> UserByEmail(string Email)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@email",Email)
            };
            return await _getUserinfo.Getbyemail(sQLParams);

        }
    }
}
