using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TMADll.Classes;
using TMADll.Models;

namespace TimeManagementApp.Controllers
{
    public class ReminderController : Controller
    {
        private readonly ReminderClass reminderClass = new ReminderClass();
        // GET: Reminder/Create
        public IActionResult Create()
        {
            ViewData["Code"] = new SelectList(reminderClass.getCode());
            ViewData["Days"] = new SelectList(reminderClass.getDays());
            return View();
        }



        // POST: Reminder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reminder reminder)
        {
            reminderClass.Add(reminder);
            return RedirectToAction("Index", "StudentModules");
        }

    }
}
