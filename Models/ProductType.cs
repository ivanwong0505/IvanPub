using System.Collections.Generic;
using System.ComponentModel;

namespace IvanCafe.Models
{
    public class ProductType
    {
        [DisplayName("Product Type ID")]
        public int Id { get; set; }
        [DisplayName("Product Type Name")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}