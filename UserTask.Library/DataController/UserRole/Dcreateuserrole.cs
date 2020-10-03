
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserRole;

namespace UserTask.Library.DataController.UserRole
{
    public class Dcreateuserrole
    {
        readonly createuserrole _createuserrole = new createuserrole();
        public async Task Create(UserRoles urole)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@userid",urole.UserId),
                new SQLParam("@roleid",urole.RoleId)
               


            };
            await _createuserrole.Create(sQLParams);
        }
    }
}
