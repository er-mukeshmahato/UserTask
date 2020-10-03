using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTask.Library.DataController.ActivityData;
using UserTask.Library.DataController.User;
using UserTask.Library.DataController.UserTask;
using UserTask.Library.Entity.Model;

namespace UserTask.Controllers
{
    [Authorize(Roles = "USER")]
    public class TaskController : Controller
    {
        readonly Daddtaskactivity _daddtaskactivity = new Daddtaskactivity();
        readonly DGetByEmail _dGetByEmail = new DGetByEmail();
        readonly Dgetallactivitydata _dgetallactivitydata = new Dgetallactivitydata();
        readonly Dcreatetask _dcreatetask = new Dcreatetask();
        readonly Ddeletetask _ddeletetask = new Ddeletetask();
        readonly Dedittask _dedittask = new Dedittask();
        readonly Dgetalltask _dgetalltask = new Dgetalltask();
        readonly DgettaskbyId _dgettaskbyid = new DgettaskbyId();
        public IHttpContextAccessor _httpContextAccessor;
        public TaskController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task<IActionResult> Index()
        {
            ViewBag.data = "mukesh";
            var data = await _dgetalltask.Alltask();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.data = await _dgetalltask.Alltask();
            ViewBag.lst = await _dgetallactivitydata.AllActivity();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserTasks taskModel)
        {
            if (taskModel == null)
            {
                return View(taskModel);
            }
            var task = new UserTasks();
            task.Name = taskModel.Name;
            await _dcreatetask.Create(task);



            var Email = _httpContextAccessor.HttpContext.User.Identity.Name;
            var UserId = await _dGetByEmail.UserByEmail(Email);

            var modal = new Activitydata();
            modal.FullName = UserId.FullName;
            modal.Name = taskModel.Name;
            modal.UserId = UserId.Id;
            modal.Status = "Created by";
            await _daddtaskactivity.Create(modal);

            TempData["Sucess"] = "Task has been added";
            return RedirectToAction("Create", "Task");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var data = await _dgettaskbyid.TaskById(id);
            if (data == null)
            {
                return View();
            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserTasks model)
        {
            var task = new UserTasks();
            task.Id = model.Id;
            task.Name = model.Name;
            await _dedittask.Update(task);
            TempData["Sucess"] = "Task has been Updated";
            return RedirectToAction("Create", "Task");
        }
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _dgettaskbyid.TaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteTaskConfirm(int id)
        {
            await _ddeletetask.Delete(id);
            TempData["Error"] = "deleted sucessfully";
            return RedirectToAction("Create", "Task");
        }
    }
}