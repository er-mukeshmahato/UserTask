using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserTask.Library.DataController.Role;
using UserTask.Library.DataController.User;
using UserTask.Library.DataController.UserRole;
using UserTask.Library.Entity.Model;
using UserTask.Library.Entity.ViewModel;
using UserTask.Library.Helper;

namespace UserTask.Controllers
{
    
    public class UserController : Controller
    {
        readonly DGetUserInfo _getUserinfo = new DGetUserInfo();
        readonly DGetAllUserInfo _getAllUser = new DGetAllUserInfo();
        readonly DCreateuserInfo _createUser = new DCreateuserInfo();
        readonly DUpdateUserInfo _updateUser = new DUpdateUserInfo();
        readonly DDeleteUserInfo _deleteUser = new DDeleteUserInfo();
        readonly Dcreaterole _dcreaterole = new Dcreaterole();
        readonly Ddeleterole _ddeleterole = new Ddeleterole();
        readonly Dupdaterole _dupdaterole = new Dupdaterole();
        readonly Dgetallrole _dgetallrole = new Dgetallrole();
        readonly Dgetrole _dgetrole = new Dgetrole();
        readonly Dgetuserrole _dgetuserrole = new Dgetuserrole();
        readonly Dcreateuserrole _dcreateuserrole = new Dcreateuserrole();
        readonly Ddeleteuserrole _ddeleteuserrole = new Ddeleteuserrole();
        readonly DGetByEmail _dgetbyemail = new DGetByEmail();
        readonly Dgetrolname _dgetrolname = new Dgetrolname();

        [Authorize(Roles = "USER")]
        public async Task<IActionResult> Index()
        {
            var data = await _getAllUser.AllUser();
            return View(data);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserModel user)
        {
            PasswordHasher pass = new PasswordHasher();
            var model = new UserModel();
            model.Email = user.Email;
            var valid = pass.ValidatePassword(user.Password);
            if (valid)
            {
                model.Password = pass.Hash(user.Password);
                model.FullName = user.FullName;
                model.Address = user.Address;
                model.PhoneNo = user.PhoneNo;
                model.CreatedOn = DateTime.Now.ToString();
                await _createUser.Create(model);
                ///Assign Role////
                var role = await _dgetrolname.GetByRoleName("USER");
                if (role==null)
                {
                    Roles rol = new Roles();
                    rol.Rolename = "USER";
                    await _dcreaterole.Create(rol);
                    var data1 = await _dgetbyemail.UserByEmail(user.Email);
                    var UserRole1 = new UserRoles();
                    var rolename = await _dgetrolname.GetByRoleName("USER");
                    UserRole1.RoleId = rolename.Id;
                    UserRole1.UserId = data1.Id;
                    await _dcreateuserrole.Create(UserRole1);
                    return RedirectToAction("Index", "Home");
                }
                var data = await _dgetbyemail.UserByEmail(user.Email);
                var UserRole = new UserRoles();
                UserRole.RoleId = role.Id;
                UserRole.UserId = data.Id;
               await _dcreateuserrole.Create(UserRole);
               return RedirectToAction("Index", "Home");




            }
            ModelState.AddModelError(string.Empty,
            "At least one lower case letter " +
                       " At least one upper case letter, " +
                       "At least special character," +
                       "At least one number " +
                       "At least 8 characters length");
            return View(user);



        }
        [Authorize(Roles = "USER")]
        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {

            var user = await _getUserinfo.UserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [Authorize(Roles = "USER")]
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserModel user)
        {
            if (user == null)
            {
                return View(user);
            }
            await _updateUser.Update(user);
            return RedirectToAction("Index", "User");
        }


    }
}
