/* CustomerOrder.cs
 * Author: Krista Smith
 * Date: 12/2/23
 * Description: This file will define a CustomerOrder object. 
 * The CustomerOrder will be added to the cart (repository).
 */


using System.ComponentModel.DataAnnotations;

namespace PizzaWebApp.Models
{
    public class CustomerOrder
    {
        // properties
        public string? PizzaName { get; set; } // type of pizza
        public string? Size { get; set; } // pizza size
        public string? Topping { get; set; } // pizza topping

        public decimal? ToppingPrice { get; set; } // price of all toppings
        public decimal? TotalPrice {  get; set; } // total order price

		[Required(ErrorMessage = "Please enter your name")] // used for form validation
		public string? CustomerName { get; set; } // customer name

		[Required(ErrorMessage = "Please chooose pickup or delivery")] // used for form validation
		public bool? WillDeliver { get; set; } // bool set to "true" if customer wants delivery

		[Required(ErrorMessage = "Please enter an address")] // used for form validation
		public string? DeliveryAddress { get; set; } // customer address
    }
}
