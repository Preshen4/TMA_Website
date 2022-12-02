using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TMADll.Classes;
using TMADll.Models;


namespace TimeManagementApp.Controllers
{
    public class StudySessionsController : Controller
    {
        private readonly TimeManagementAppContext _context;
        private readonly StudyClass studyClass = new StudyClass();

        public StudySessionsController(TimeManagementAppContext context)
        {
            _context = context;
        }

        // GET: StudySessions
        public async Task<IActionResult> Index()
        {
            var timeManagementAppContext = _context.StudySessions.Include(s => s.StudentModule);
            return View(await timeManagementAppContext.ToListAsync());
        }

        // GET: StudySessions/Create
        public IActionResult Create()
        {
            ViewData["StudentModuleCode"] = new SelectList(studyClass.getCode());
            return View();
        }

        // POST: StudySessions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudySession studySession)
        {
            studyClass.AddStudy(studySession);
            TempData["Create"] = "Study Session added successfully";
            return RedirectToAction("Index", "StudentModules");
        }
    }
}
