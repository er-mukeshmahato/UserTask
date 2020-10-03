using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserTask.Library.DataProvider.Activity;
using UserTask.Library.Entity.Model;

namespace UserTask.Library.DataController.Activity
{
   public class Dgetallactivity
    {
        readonly getallactivity _getallactivity = new getallactivity();
        public async Task<IEnumerable<Activities>> AllActivity()
        {
            return await _getallactivity.Get();
        }
    }
}
