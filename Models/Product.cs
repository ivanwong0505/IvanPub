using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IvanCafe.Models
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName ("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(150)]
        public string Name { get; set; }

        public int ProductTypeId { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 99.99, ErrorMessage = "Price must be between 0.01 and 99.99")]
        public decimal Price { get; set; }

        [DisplayName("Photo")]
        [StringLength(256)]
        public string ImageName { get; set; }

        [DisplayName("Is For Sale")]
        public bool IsForSale { get; set; }

        public virtual ProductType ProductType { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}