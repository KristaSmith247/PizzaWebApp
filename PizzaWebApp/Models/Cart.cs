//  Cart.cs
//	Author: Krista Smith
//	Date: 12/11/23
//	Description: The file will store information about the CustomerOrder object.


namespace PizzaWebApp.Models
{
	public static class Cart
	{
		private static List<CustomerOrder> customerOrders = new List<CustomerOrder>(); // create a list of orders

		public static IEnumerable<CustomerOrder> CustomerOrders
		{
			get { return customerOrders; }
		}

		//public static void AddOrder(CustomerOrder customerOrder)
		//{ // add order to list
		//	// customerOrders.Add(customerOrder); // original function from video
		//	customerOrders.Add(customerOrder);
		//}

		public static void AddOrder(CustomerOrder customerOrder)
		{ // add order to list
		  // customerOrders.Add(customerOrder); // original function from video
			customerOrders.Add(customerOrder);
		}
	}
}
