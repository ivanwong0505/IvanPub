using System.Linq;
using System.Web.Mvc;
using IvanCafe.Models;
using IvanCafe.ViewModels;

namespace IvanCafe.Controllers
{
    public class CartController : Controller
    {
        PubDbContext db = new PubDbContext();
        
        // GET: /Cart/
        public ActionResult Index()
        {
            var cart = Cart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new OrderViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }
        //
        // GET: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the product from the database
            var addedProduct = db.Products
                .Single(product => product.Id == id);

            // Add it to the shopping cart
            var cart = Cart.GetCart(this.HttpContext);

            cart.AddToCart(addedProduct);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }
        //
        // AJAX: /Cart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = Cart.GetCart(this.HttpContext);

            // Get the name of the product to display confirmation
            string productName = db.CartItems
                .Single(item => item.CartItemId == id).Product.Name;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new RemoveFromOrderViewModel
            {
                Message = Server.HtmlEncode(productName) +
                    " has been removed from your order.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }
        //
        // GET: /Cart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = Cart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("_CartCount");
        }
    }
}