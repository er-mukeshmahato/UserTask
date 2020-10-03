using UserTask.Library.DataProvider.UserRole;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.UserRole
{
    public class Dgetuserrole
    {
        readonly getuserrole _getuserrole = new getuserrole();
        public async Task<UserRoles> UserroleByuserId(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _getuserrole.Get(sQLParams);

        }
    }
}
