using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.ActivityData
{
   public class createactivitydata
    {
        public async Task Create(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_activitydata_add", sQLParams);
    }
}
