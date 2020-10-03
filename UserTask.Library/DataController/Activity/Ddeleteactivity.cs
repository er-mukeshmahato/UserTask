using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.Activity;

namespace UserTask.Library.DataController.Activity
{
   public class Ddeleteactivity
    {
        readonly deleteactivity _deleteactivity = new deleteactivity();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@id",id)
            };
            await _deleteactivity.Delete(sQLParams);
        }
    }
}
