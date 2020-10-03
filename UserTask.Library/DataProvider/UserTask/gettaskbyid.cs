using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.UserTask
{
  public  class gettaskbyid
    {
        public async Task<UserTasks> GetbyId(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<UserTasks>("sp_task_getbyid", sQLParams);
        }
    }
}
