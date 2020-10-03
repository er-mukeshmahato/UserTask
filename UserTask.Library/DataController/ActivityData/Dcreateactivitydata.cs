using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.ActivityData;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.ActivityData
{
   public class Dcreateactivitydata
    {
        readonly createactivitydata _createactivity = new createactivitydata();
        public async Task Create(Activitydata data)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@taskid",data.TaskId),
                new SQLParam("@userId",data.UserId),
                new SQLParam("@assignTime",data.AssignDate),
                new SQLParam("@completedTime",data.CompleteDate),
                new SQLParam("@status",data.Status),
                new SQLParam("@name",data.Name),
                new SQLParam("@fullname",data.FullName)
               


            };
            await _createactivity.Create(sQLParams);
        }
    }
}
