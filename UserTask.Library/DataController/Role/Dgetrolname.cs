using UserTask.Library.DataProvider.Role;
using UserTask.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
  public  class Dgetrolname
    {
        readonly getrolname _getrolname = new getrolname();
        public async Task<Roles> GetByRoleName(string RoleName)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Name",RoleName)
            };
            return await _getrolname.Getbyrolename(sQLParams);

        }
    }
}
