using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.Activity;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.Activity
{
   public class Dupdateactivity
    {
        readonly updateadtivity _updateactivity = new updateadtivity();

        public async Task Update(Activities activities)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",activities.Id),
               
                 new SQLParam("@completed",activities.Completed),
                new SQLParam("@completeddate",activities.CompletedTime),
                 new SQLParam("@status",activities.Status)


            };
            await _updateactivity.Update(sQLParams);
        }
    }
}