using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IvanCafe.Models;

namespace IvanCafe.Controllers
{
    public class OrderDetailController : Controller
    {
        private PubDbContext db = new PubDbContext();

        // GET: OrderDetail
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.UsernameSortParm = String.IsNullOrEmpty(sortOrder) ? "by_user" : "";
            ViewBag.ProductSortParm = sortOrder == "Product" ? "by_product" : "Product";
            var orderDetails = from o in db.OrderDetails select o;
            var orders = from d in db.Orders select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                orderDetails = orderDetails.Where(o => o.Order.Username.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "by_user":
                    orderDetails = orderDetails.OrderByDescending(o => o.Id);
                    break;
                case "Product":
                    orderDetails = orderDetails.OrderBy(o => o.ProductId);
                    break;
                case "by_product":
                    orderDetails = orderDetails.OrderByDescending(o => o.ProductId);
                    break;
                default:
                    orderDetails = orderDetails.OrderBy(o => o.Id);
                    break;
            }
            return View(orderDetails.ToList());
        }

       
        // GET: OrderDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetails.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }
    }
}
