using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MohdShdooh_.Models;
using MohdShdooh_.Models.Repository;
using Shdooh_Employees.Models;

namespace Shdooh_Employees.Controllers
{
    public class employeeController : Controller
    {

        private readonly employeeRepository _employeeRepository;
        public employeeController(employeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        // GET: employeeController
        [HttpGet]
        public ActionResult Index()
        {
            List<Employee> employees;
            employees = _employeeRepository.getEmployees();
            return View(employees);
        }

        [HttpGet]
        public JsonResult getEmployees()
        {
            return Json(_employeeRepository.getEmployees());
        }




        // GET: employeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: employeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: employeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: employeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: employeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: employeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
