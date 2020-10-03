using UserTask.Library.DataProvider.Role;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
   public class Dupdaterole
    {
        readonly updaterole _updaterole = new updaterole();
        public async Task Update(Roles role)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",role.Id),
                new SQLParam("@name",role.Rolename)


            };
            await _updaterole.Update(sQLParams);
        }
    }
}
