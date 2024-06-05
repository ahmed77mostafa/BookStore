using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wTickets.Data;

namespace wTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly dbContext _context;
        public MoviesController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movie.ToListAsync();
            return View();
        }
    }
}
