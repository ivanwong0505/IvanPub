using System.ComponentModel.DataAnnotations;

namespace IvanCafe.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        public string SessionId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}