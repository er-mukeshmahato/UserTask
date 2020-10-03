using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.UserTask
{
  public  class gettaskbyname
    {
        public async Task<UserTasks> Getbyname(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<UserTasks>("sp_task_Idbyname", sQLParams);
        }
    }
}
