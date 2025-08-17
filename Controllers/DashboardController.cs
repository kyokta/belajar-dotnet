using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BelajarCRUD.Data;
using BelajarCRUD.Models;

namespace BelajarCRUD.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(new
            {
                Customers = await _context.Customers.CountAsync(),
                Products = await _context.Products.CountAsync()
            });
        }
    }
}