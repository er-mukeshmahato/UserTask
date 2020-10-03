using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserRole
{
  public  class deleteuserrole
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
             await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_userrole_delete", sQLParams);
    }
}
