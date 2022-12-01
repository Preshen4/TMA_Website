using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMADll.Models;

namespace TimeManagementApp.Controllers
{
    public class StudentModulesController : Controller
    {
        private readonly TimeManagementAppContext _context;

        public StudentModulesController(TimeManagementAppContext context)
        {
            _context = context;
        }

        // GET: StudentModules
        public async Task<IActionResult> Index()
        {
            Reminders();
            var studentModules = _context.StudentModules.Where(s => s.StudentNumber == User.Identity.Name).Include(s => s.CodeNavigation).Include(s => s.StudentNumberNavigation);
            return View(await studentModules.ToListAsync());
        }
        private void Reminders()
        {
            TimeManagementAppContext context = new();
            // Find all dayOfWeek that matches user 
            var reminders = context.Reminders.Where(x => x.StudentModule.StudentNumber == User.Identity.Name).Include(c => c.StudentModule).ToList();
            foreach (var item in reminders)
            {
                if (item.DayOfWeek == DateTime.Now.DayOfWeek.ToString())
                {
                    TempData["Remind"] = $"You set today for: {item.StudentModule.Code}";
                    return;
                };
            }
        }
    }
}
