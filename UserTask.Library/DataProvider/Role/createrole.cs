using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.Role
{
  public  class createrole
    {
        public async Task Create(List<SQLParam> sQLParams) =>
              await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_role_add", sQLParams);
    }
}
