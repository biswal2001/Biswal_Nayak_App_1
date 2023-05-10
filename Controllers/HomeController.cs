using biswadot.Model;
using Microsoft.AspNetCore.Mvc;

namespace biswadot.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = new MockEmployeeRepository();
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Email;
        }
    }
}
