using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.Activity
{
  public  class gettaskbyuserid
    {
        public async Task<Activities> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<Activities>("sp_activity_taskidbyuserid", sQLParams);
        }
    }
}
