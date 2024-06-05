using Microsoft.AspNetCore.Mvc;
using wTickets.Data;

namespace wTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly dbContext _context;

        public ActorsController(dbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actor.ToList();
            return View();
        }
    }
}
