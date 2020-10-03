using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.UserTask
{
    public class Dedittask
    {
        readonly edittask _edittask = new edittask();
        public async Task Update(UserTasks task)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",task.Id),
                new SQLParam("@name",task.Name)


            };
            await _edittask.Update(sQLParams);
        }
    }
}
