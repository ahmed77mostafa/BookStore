using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wTickets.Data;

namespace wTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly dbContext _context;
        public ProducersController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producer.ToListAsync();
            return View();
        }
    }
}
