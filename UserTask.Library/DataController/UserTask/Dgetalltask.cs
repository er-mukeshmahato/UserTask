using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.UserTask
{
    public class Dgetalltask
    {
        readonly getalltask _getalltask = new getalltask();
        public async Task<IEnumerable<UserTasks>> Alltask()
        {
            return await _getalltask.Get();
        }
    }
}
