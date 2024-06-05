using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wTickets.Data;

namespace wTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly dbContext _context;
        public CinemasController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinema.ToListAsync();
            return View();
        }
    }
}
