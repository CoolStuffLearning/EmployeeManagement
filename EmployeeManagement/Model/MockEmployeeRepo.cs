using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        private List<Employee> _emplist;

        public MockEmployeeRepo()
        {
            _emplist = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Anshu", Department = "OGS" },
                new Employee(){Id = 2, Name = "Kishu", Department = "UHG" },
            };
        }

        public Employee GetEmployee(int Id)
        {
            //throw new NotImplementedException();

            //Employee emp = new Employee() { Id = 1, Name = "Anshu", Department = "OGS" };
            //return emp;

            return _emplist.FirstOrDefault(e => e.Id == Id);

           
        }
        
    }
}
