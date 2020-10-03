using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.Activity;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.Activity
{
   public class Dgetactivitybyid
    {
        readonly activitybyid _activitybyid = new activitybyid();
        public async Task<Activities> ActivityById(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _activitybyid.Get(sQLParams);

        }
    }
}
