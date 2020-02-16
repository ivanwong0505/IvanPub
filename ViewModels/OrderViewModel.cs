using System.Collections.Generic;
using IvanCafe.Models;

namespace IvanCafe.ViewModels
{
    public class OrderViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}