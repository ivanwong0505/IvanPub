using System;
using System.Linq;
using System.Web.Mvc;
using IvanCafe.Models;

namespace IvanCafe.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        PubDbContext db = new PubDbContext();

        // GET: /Order/Confirm
        public ActionResult Confirm()
        {
            return View();
        }

        //
        // POST: /Order/ConfirmOrder
        [HttpPost]
        public ActionResult Confirm(FormCollection values)
        {
            var order = new Order();
            UpdateModel(order);

            order.Username = User.Identity.Name;
            order.OrderDate = DateTime.Now;

            //Save Order
            db.Orders.Add(order);
            db.SaveChanges();

            //Process the order
            var cart = Cart.GetCart(this.HttpContext);
            cart.CreateOrder(order);

            return RedirectToAction("Complete", new { id = order.Id });

        }

        //
        // GET: /Order/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = db.Orders.Any(
                o => o.Id == id &&
                     o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}