using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TMADll.Classes;
using TMADll.Models;

namespace TimeManagementApp.Controllers
{
    public class ModulesController : Controller
    {
        private readonly TimeManagementAppContext _context;
        readonly ModuleClass moduleClass = new ModuleClass();
        public ModulesController(TimeManagementAppContext context)
        {
            _context = context;
        }

        // GET: Modules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Modules.ToListAsync());
        }

        // GET: Modules/Create
        public IActionResult Create()
        {
            // Gets a list of the semestersNo that belongs to user
            ViewBag.Semester = new SelectList(moduleClass.getSemesters());
            return View();
        }

        // POST: Modules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name,Credits,HoursPerWeek")] Module module)
        {

            if (ModelState.IsValid)
            {
                // Check if module already exists
                if (moduleClass.CheckIfCodeExists(module.Code))
                {
                    moduleClass.AddOldModule(module);
                    moduleClass.AddModuleSemester(module);
                    TempData["Create"] = "Module added successfully";
                    return RedirectToAction("Index", "StudentModules");
                }

                // Check if student has this module
                if (moduleClass.CheckIfStudentHasCode(module.Code))
                {
                    ModelState.AddModelError("Code", "Module already exists");
                    return View(module);
                }
                moduleClass.AddNewModule(module);
                moduleClass.AddModuleSemester(module);
                TempData["Create"] = "Module added successfully";
                return RedirectToAction("Index", "StudentModules");
            }
            return View(module);
        }

    }
}
