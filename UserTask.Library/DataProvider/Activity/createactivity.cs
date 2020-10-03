using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Activity
{
   public class createactivity
    {

        public async Task Create(List<SQLParam> sQLParams) =>
              await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_activity_add", sQLParams);
    }
}
