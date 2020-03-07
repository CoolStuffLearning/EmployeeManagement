using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Model;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private MockEmployeeRepo _mockEmpRepo;

        public EmployeeController()
        {
            _mockEmpRepo = new MockEmployeeRepo();
        }

        public IActionResult Index()
        {
            return View();
        }

        public string detail(int id)
        {            
            return _mockEmpRepo.GetEmployee(id).Name;            
        }
    }
}