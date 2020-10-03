using UserTask.Library.DataProvider.UserRole;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.UserRole
{
    public class Ddeleteuserrole
    {
        readonly deleteuserrole _deleteuserrole = new deleteuserrole();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            await _deleteuserrole.Delete(sQLParams);
        }
    }
}
