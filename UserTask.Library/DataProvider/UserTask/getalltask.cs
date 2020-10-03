using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.UserTask
{
   public class getalltask
    {
        public async Task<IEnumerable<UserTasks>> Get() =>
        await new SQLGetListAsync().ExecuteAsEnumerableAsync<UserTasks>("sp_task_getall");
    }
}
