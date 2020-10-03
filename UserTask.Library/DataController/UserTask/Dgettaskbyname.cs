using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.UserTask
{
  public  class Dgettaskbyname
    {
        readonly gettaskbyname _gettaskbyname = new gettaskbyname();
        public async Task<UserTasks> TaskbyName(string name)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@name",name)
            };
            return await _gettaskbyname.Getbyname(sQLParams);

        }
    }
}
