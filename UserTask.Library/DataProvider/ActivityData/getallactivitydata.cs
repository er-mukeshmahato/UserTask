using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataProvider.ActivityData
{
   public class getallactivitydata
    {
        public async Task<IEnumerable<Activitydata>> Get() =>
    await new SQLGetListAsync().ExecuteAsEnumerableAsync<Activitydata>("sp_activitydata_getall");

    }
}
