using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.Activity;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.Activity
{
   public class Dgettaskbyuserid
    {
        readonly gettaskbyuserid _taskbyuserid = new gettaskbyuserid();
        public async Task<Activities> TaskbyUserId(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            return await _taskbyuserid.Get(sQLParams);

        }
    }
}
