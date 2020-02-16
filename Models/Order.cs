using System.Collections.Generic;
using System.Web.Mvc;

namespace IvanCafe.Models
{
    [Bind(Exclude = "Id")]
    public class Order
    {
        public int Id { get; set; }


        public System.DateTime OrderDate { get; set; }


        public string Username { get; set; }


        public decimal Total { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}