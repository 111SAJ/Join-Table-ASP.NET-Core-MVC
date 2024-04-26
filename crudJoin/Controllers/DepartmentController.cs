using crudJoin.Data;
using crudJoin.Models;
using Microsoft.AspNetCore.Mvc;

namespace crudJoin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        //List
        public IActionResult Index()
        {
            var departmentList = _context.Department.ToList();
            return View(departmentList);
        }

    }
}
