using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.Activity
{
   public class getallactivity
    {
        public async Task<IEnumerable<Activities>> Get() =>
       await new SQLGetListAsync().ExecuteAsEnumerableAsync<Activities>("sp_activity_getall");

    }
}
