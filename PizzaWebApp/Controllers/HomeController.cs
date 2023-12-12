using Microsoft.AspNetCore.Mvc;
using PizzaWebApp.Models;
using System.Diagnostics;

namespace PizzaWebApp.Controllers
{
	public class HomeController : Controller
	{

		public HomeController()
		{

		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpGet]
		public ViewResult OrderForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult OrderForm(CustomerOrder customerOrder)
		{
			// stores response from order form
			Cart.AddOrder(customerOrder);
			//return View("Thanks", customerOrder);
			//return View(Cart.CustomerOrders.Where(r => r.WillDeliver == true));
			return View(Cart.CustomerOrders);

		}
		public ViewResult Checkout()
		{
			return View();
		}

		//public ViewResult Confirmation()
		//{
		//	return View();
		//}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public ActionResult Confirmation(CustomerOrder customerOrder)
		{
			// Create an instance of the ViewModel
			ViewModel OrderViewModel = new ViewModel();
			{  //Set values as appropriate
			   //List < CustomerOrder > = retrieve orders;
			   //Customer = assign customer;
			   // Set other properties as needed

				//OrderList = Cart.AddOrder(customerOrder),
				//OrderViewModel.OrderList = Cart.CustomerOrders();
				//OrderViewModel.CustomerName = customerOrder;
				
				
				//OrderViewModel.OrderList = Cart.AddOrder(customerOrder);
			};

			// Pass the ViewModel to the view
			return View(OrderViewModel);
		}
	}
}
