using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.ActivityData;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.ActivityData
{
   public class Dgetallactivitydata
    {
        readonly getallactivitydata _getallactivitydata = new getallactivitydata();
        public async Task<IEnumerable<Activitydata>> AllActivity()
        {
            return await _getallactivitydata.Get();
        }
    }
}
