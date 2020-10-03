using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Activity
{
   public class deleteactivity
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
         await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_activity_delete", sQLParams);
    }
}
