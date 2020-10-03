using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Activity
{
   public class updateadtivity
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_activity_update", sQLParams);
        }
    }
}
