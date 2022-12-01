using Microsoft.AspNetCore.Mvc;
using TMADll.Classes;
using TMADll.Models;


namespace TimeManagementApp.Controllers
{
    public class SemestersController : Controller
    {
        private readonly TimeManagementAppContext _context;
        readonly SemesterClass semesterClass = new SemesterClass();

        public SemestersController(TimeManagementAppContext context)
        {
            _context = context;
        }

        // GET: Semesters/AddSemester
        public IActionResult AddSemester()
        {
            return View();
        }

        // POST: Semesters/AddSemester
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSemester(Semester semester)
        {
            semesterClass.AddSemester(semester);
            TempData["Create"] = "Semester Created";
            return RedirectToAction("Index", "StudentModules");
        }

    }
}
