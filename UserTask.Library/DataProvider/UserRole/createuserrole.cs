using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserRole
{
   public class createuserrole
    {
        public async Task Create(List<SQLParam> sQLParams) =>
           await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_userrole_add", sQLParams);
    }
}
