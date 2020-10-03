using UserTask.Library.DataProvider.Role;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
    public class Dgetrole
    {
        readonly getrole _getrole = new getrole();
        public async Task<Roles> RoleById(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _getrole.Get(sQLParams);

        }
    }
}
