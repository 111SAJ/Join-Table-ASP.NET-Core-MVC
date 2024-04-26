using crudJoin.Data;
using crudJoin.Models;
using crudJoin.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crudJoin.Controllers
{
    public class EmployeeRegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        //List
        public IActionResult Index()
        {
            var employeeList = from employee in _context.EmployeeRegister
                               join department in _context.Department
                               on employee.DepartmentId equals department.DepartmentId
                               select new EmployeeDepartmentViewModel
                               {
                                   EmployeeId = employee.EmployeeId,
                                   EmployeeName = employee.EmployeeName,
                                   EmployeeEmail = employee.EmployeeEmail,
                                   Address = employee.Address,
                                   LastUpdate = employee.LastUpdate,
                                   DepartmentName = department.DepartmentName
                               };
            return View(employeeList.ToList());
        }

        
    }
}
