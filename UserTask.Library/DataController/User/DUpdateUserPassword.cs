using UserTask.Library.DataProvider.User;
using UserTask.Library.Entity.ViewModel;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataController.User
{
   public class DUpdateUserPassword
    {
        readonly UpdateUserPassword updateUserPassword = new UpdateUserPassword();
        public async Task UpdatePassword(ResetPasswordViewModel reset)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Id",reset.UserId),
               
                new SQLParam("@password",reset.ConfirmPassword),

               

            };
            await updateUserPassword.UpdatePassword(sQLParams);

        }
       
    }
}
