// ViewModel.cs
// Author: Krista Smith
// Date: 12/11/23
// Description: The file will create a ViewModel to pass information to bind to the View.

using System.ComponentModel.DataAnnotations;

namespace PizzaWebApp.Models
{
	public class ViewModel
	{
		public List<CustomerOrder> OrderList { get; set; }
		public CustomerOrder Order { get; set; }


		public string? PizzaName { get; set; } // type of pizza
		public string? Size { get; set; } // pizza size
		public string? Topping { get; set; } // pizza topping

		public decimal? ToppingPrice { get; set; } // price of all toppings
		public decimal? TotalPrice { get; set; } // total order price

		public string? CustomerName { get; set; } // customer name

		public bool? WillDeliver { get; set; } // bool set to "true" if customer wants delivery
		public string? DeliveryAddress { get; set; } // cust

		public static IEnumerable<CustomerOrder> CustomerOrders
		{
			get { return CustomerOrders; }
		}
		public static void AddOrder(CustomerOrder customerOrder)
		{ // add order to list
			Cart.AddOrder(customerOrder);
			//CustomerOrders.GetOrder(customerOrder);
		}
	}
}
//public class MyViewModel
//{
//	public List<Order> {get; set;}

//public Customer
//{ get; set; }


//    // Add other properties (from whatever source) as needed - since you're essentially just "packaging" your models and properties in a ViewModel to bind to the View.
//}