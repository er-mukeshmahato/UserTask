using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserTask
{
    public class createtask
    {
        public async Task Create(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_task_add", sQLParams);
    }
}
