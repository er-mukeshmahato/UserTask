using UserTask.Library.DataProvider.Role;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
  public  class Dcreaterole
    {
        readonly createrole _createrole = new createrole();
        public async Task Create(Roles role)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@name",role.Rolename)


            };
            await _createrole.Create(sQLParams);
        }
    }
}
