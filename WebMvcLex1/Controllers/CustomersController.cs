using Microsoft.AspNetCore.Mvc;
using WebMvcLex1.Data;
using WebMvcLex1.Models;

namespace WebMvcLex1.Controllers
{
    public class CustomersController : Controller
    {
        private readonly WebMvcLex1Context _context;
        public CustomersController(WebMvcLex1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,SSN")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

    }
}
