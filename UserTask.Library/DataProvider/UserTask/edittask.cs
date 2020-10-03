using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserTask
{
    public class edittask
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_task_edit", sQLParams);
        }
    }
}
