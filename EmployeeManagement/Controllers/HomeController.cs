using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepo _empRepo;

        public HomeController(IEmployeeRepo empRepo)
        {
            _empRepo = empRepo;
        }

        public string Index ()
        {
            //return "Home controller";

            return _empRepo.GetEmployee(1).Name;
        }

        public JsonResult detail_JS(int id)
        {
            return Json(_empRepo.GetEmployee(id));
        }

        public ObjectResult detail_OR(int id)
        {
            return new ObjectResult(_empRepo.GetEmployee(id));
        }

        public ViewResult detail_vw(int id)
        {
            return View(_empRepo.GetEmployee(id));
        }
    }
}
