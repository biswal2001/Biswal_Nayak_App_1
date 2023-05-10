using System.Collections.Generic;
using System.Linq;

namespace biswadot.Model
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        
        List<Employee> _employeeList= new List<Employee>();
        public MockEmployeeRepository()
        {
            this._employeeList = new List<Employee>();
            {
                new Employee() { Id = 1, Name = "biswal", Email = "biswalnayak2@gmail.com", Department = "MCA" };
                new Employee() { Id = 2, Name = "bK", Email = "bk2@gmail.com", Department = "BTECH" };
                new Employee() { Id = 4, Name = "dK", Email = "Dk2@gmail.com", Department = "BCA" };
                new Employee() { Id = 3, Name = "ck", Email = "ck2@gmail.com", Department = "MCA" };
            };
        }
        public Employee GetEmployee(int id) 
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
