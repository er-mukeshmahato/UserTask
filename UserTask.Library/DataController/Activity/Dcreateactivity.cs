using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataController.UserTask;
using UserTask.Library.DataProvider.Activity;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.Activity
{
   public class Dcreateactivity
    {
        readonly createactivity _createactivity = new createactivity();
        
        public async Task Create(Activities activities)
        {
            
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
            
                new SQLParam("@taskId",activities.TaskId),
                 new SQLParam("@userId",activities.UserId),
                new SQLParam("@status",activities.Status),
                new SQLParam("@name",activities.Name)



            };
            
           
                await _createactivity.Create(sQLParams);
           
           
        }
    }
}
