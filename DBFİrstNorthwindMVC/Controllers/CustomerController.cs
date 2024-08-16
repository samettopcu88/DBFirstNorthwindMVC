using DBFİrstNorthwindMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFİrstNorthwindMVC.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindDbContext context;
        private readonly ILogger<CustomerController> logger;

        public CustomerController(NorthwindDbContext _context, ILogger<CustomerController> _logger)
        {
            this.context = _context;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            var customers = context.Customers.ToList<Customer>();
            return View(customers);
        }

        public IActionResult Details(string id)
        {
            var customer = context.Customers.SingleOrDefault(x => x.CustomerId == id);
            return View(customer);
        }

        public IActionResult DeleteCustomer(string id) 
        {
            var customer = context.Customers.SingleOrDefault(x => x.CustomerId == id);
            return View(customer);

        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return View(customer);
        }
    }
}
