using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Mvc;
using ToDoListWebApplication.Models;

namespace ToDoListWebApplication.Controllers
{
    public class TaskController : Controller
    {
        // Simulated database
        private static List<ToDoTask> tasks = new List<ToDoTask>();

        // GET: Task
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(ToDoTask task)
        {
            if (ModelState.IsValid)
            {
                task.Id = tasks.Count + 1;
                tasks.Add(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // POST: Task/Complete/5
        public ActionResult Complete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
            return RedirectToAction("Index");
        }

        // POST: Task/Delete/5
        public ActionResult Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
            return RedirectToAction("Index");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
