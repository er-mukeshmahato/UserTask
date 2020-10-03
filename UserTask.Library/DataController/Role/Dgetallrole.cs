using UserTask.Library.DataProvider.Role;
using UserTask.Library.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.Role
{
    public class Dgetallrole
    {
        readonly getallrole _getallrole = new getallrole();
        public async Task<IEnumerable<Roles>> AllRole()
        {
            return await _getallrole.Get();
        }
    }
}
