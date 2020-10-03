using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.UserTask
{
    public class Dcreatetask
    {
        readonly createtask _createtask = new createtask();
        public async Task Create(UserTasks task)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@name",task.Name)


            };
            await _createtask.Create(sQLParams);
        }
    }
}
