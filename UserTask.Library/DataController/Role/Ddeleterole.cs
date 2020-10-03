using UserTask.Library.DataProvider.Role;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
    public class Ddeleterole
    {
        readonly deleterole _deleterole = new deleterole();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            await _deleterole.Delete(sQLParams);
        }
    }
}
