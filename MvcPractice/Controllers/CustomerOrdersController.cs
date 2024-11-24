using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;

namespace MvcPractice.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek Customer ve Order nesneleri oluşturma
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                Email = "ali.veli@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 1500.50m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 20.99m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Keyboard", Price = 45.75m, Quantity = 1 }
            };

            // ViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
