using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.UserTask;

namespace UserTask.Library.DataController.UserTask
{
    public class Ddeletetask
    {
        readonly deletetask _deletetask = new deletetask();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            await _deletetask.Delete(sQLParams);
        }
    }
}
