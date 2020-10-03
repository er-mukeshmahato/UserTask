using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.UserTask
{
   public class DgettaskbyId
    {
        readonly gettaskbyid _gettaskbyid = new gettaskbyid();
        public async Task<UserTasks> TaskById(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _gettaskbyid.GetbyId(sQLParams);

        }
    }
}
