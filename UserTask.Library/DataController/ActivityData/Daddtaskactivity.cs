using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.ActivityData;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.ActivityData
{
   public class Daddtaskactivity
    {
        readonly addtaskactivity _addtaskactivity = new addtaskactivity();
        public async Task Create(Activitydata data)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                
                new SQLParam("@name",data.Name),
                new SQLParam("@fullname",data.FullName),
                new SQLParam("@status",data.Status),
                new SQLParam("@id",data.UserId)



            };
            await _addtaskactivity.Create(sQLParams);
        }
    }
}
