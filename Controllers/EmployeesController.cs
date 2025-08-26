//Here i want o show content of the database table


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeDirectoryMVcDemo.Models;

namespace EmployeeDirectoryMVcDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDirectoryDbContext _context;

        public EmployeeController(EmployeeDirectoryDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }
    }
}
