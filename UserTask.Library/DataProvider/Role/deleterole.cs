using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Role
{
  public  class deleterole
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
          await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_role_delete", sQLParams);
    }
}
