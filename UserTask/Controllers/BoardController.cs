using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTask.Library.DataController.Activity;
using UserTask.Library.DataController.ActivityData;
using UserTask.Library.DataController.User;
using UserTask.Library.DataController.UserTask;
using UserTask.Library.Entity.Model;
using UserTask.Library.Entity.ViewModel;

namespace UserTask.Controllers
{
    [Authorize(Roles = "USER")]
    public class BoardController : Controller
    {
        readonly Dgetallactivitydata _dgetallactivitydata = new Dgetallactivitydata();
        readonly Dcreateactivitydata _dcreateactivitydata = new Dcreateactivitydata();
        readonly DgettaskbyId _dgettaskbyid = new DgettaskbyId();
        readonly DGetUserInfo _dgetuserinfo = new DGetUserInfo();
        readonly Dgettaskbyname _dgettaskbyname = new Dgettaskbyname();
        readonly Dgetactivitybyid _dgetactivitybyid = new Dgetactivitybyid();
        readonly Dgetallactivity _dgetallactivity = new Dgetallactivity();
        readonly Dcreateactivity _dcreateactivity = new Dcreateactivity();
        readonly Dgettaskbyuserid _dgettaskbyuserid = new Dgettaskbyuserid();
        readonly Dgetuserbytaskid _dgetuserbytaskid = new Dgetuserbytaskid();
        readonly Ddeleteactivity _ddeleteactivity = new Ddeleteactivity();
        readonly Dupdateactivity _dupdateactivity = new Dupdateactivity();
        readonly DGetByEmail _dGetByEmail = new DGetByEmail();
        readonly Dgetalltask _dgetalltask = new Dgetalltask();
        public IHttpContextAccessor _httpContextAccessor;
        public BoardController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }


        public async Task<IActionResult> Index()
        {
            var data = await _dgetallactivity.AllActivity();
            return View(data);
        }
        public async Task<IActionResult> ActivityData()
        {
            var data = await _dgetallactivitydata.AllActivity();
            return View(data);
        
        
        }
            public async Task<IActionResult> completed(int id)
        {
            var Email = _httpContextAccessor.HttpContext.User.Identity.Name;
            var UserId = await _dGetByEmail.UserByEmail(Email);
            var data = await _dgetactivitybyid.ActivityById(id);
            var model = new Activities();
            model.Id = id;
            model.Completed =true;
            model.CompletedTime = DateTime.Now.ToString();
            model.Status ="Completed By";
            await _dupdateactivity.Update(model);
            //////////////////////////////
            ///
            var data1 = await _dgetactivitybyid.ActivityById(id);
            var datamodel = new Activitydata();
            datamodel.AssignDate = data1.AssignedTime;
            datamodel.TaskId = data1.Id;
            datamodel.UserId = data1.UserId;
            datamodel.Status = data1.Status;
            datamodel.FullName = UserId.FullName;
            datamodel.Name = data1.Name;
            datamodel.CompleteDate = DateTime.Now.ToString();
            await _dcreateactivitydata.Create(datamodel);

            return RedirectToAction("WorkingList", "Board");
        }

        public async Task<IActionResult> WorkingList()
        {
            
            var data = await _dgetallactivity.AllActivity();           
            var Email = _httpContextAccessor.HttpContext.User.Identity.Name;
            var UserId = await _dGetByEmail.UserByEmail(Email);
            var namelist = await _dgetalltask.Alltask();
            var tasklst= data.Where(c=>c.UserId==UserId.Id).ToList();
            ViewBag.lst = await _dgetallactivitydata.AllActivity();
           
            

            return View(tasklst);
        }
        [HttpPost,DisableRequestSizeLimit]
        public async Task<IActionResult> Add(string name)
        {

            if (name != null)
            {

               
                var lst = new List<string>();


                string text = name;

                string[] word = text.Split(':');
                
                
                foreach (var item in word)
                {
                    if (item!="")
                    {
                        lst.Add(item);
                    }
                   

                }
               

                    foreach (var task in lst)
                    {
                        if (task != "")
                        {



                            var Email = _httpContextAccessor.HttpContext.User.Identity.Name;
                            var UserId = await _dGetByEmail.UserByEmail(Email);
                            var user = await _dgetuserinfo.UserById(UserId.Id);
                            var taskid = await _dgettaskbyname.TaskbyName(task);
                            var model = new Activities();
                            model.TaskId = taskid.Id;
                            model.UserId = UserId.Id;
                            model.Name = task;
                            
                            
                            model.Status = "Assigned to"; 

                            await _dcreateactivity.Create(model);

                       
                        var datamodel = new Activitydata();
                        datamodel.AssignDate =DateTime.Now.ToString();
                        datamodel.TaskId = taskid.Id;
                        datamodel.UserId = UserId.Id;
                        datamodel.CompleteDate =" ";
                        datamodel.FullName = UserId.FullName;
                        datamodel.Name = task;
                        datamodel.Status ="Assigned to"; ;
                        await _dcreateactivitydata.Create(datamodel);
                      

                         }


                    }

               
                return RedirectToAction("WorkingList", "Board");

            }
            TempData["Sucess"] = "Assigned Sucessfully";
            return RedirectToAction("WorkingList", "Board");

        }
        

    }


}