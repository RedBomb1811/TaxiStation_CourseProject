using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaxiStation_Core2_EFCore.Models.ViewModels;
using TestExample.DB;

namespace TaxiStation_Core2_EFCore.Controllers
{
    [Route("Order")]
    public class OrdersController : Controller
    {
        private readonly TaxiStationContext _context;

        public OrdersController(TaxiStationContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {

            return View("Index", _context.Orders.ToList());
        }

        [HttpGet]
        [Route("MakeOrder")]
        public IActionResult MakeOrder()
        {
            ViewBag.Id_order_type = new SelectList(_context.Order_types, "id", "name");
            return View("MakeOrder");
        }

        [HttpPost]
        [Route("MakeOrder")]
        public IActionResult MakeOrder(MakeOrder order)
        {
            ///TODO: MakeOrder
            try
            {
                int id_order = _context.MakeOrder(order.Phone_number, order.Id_order_type, order.Start_point_lat, order.Start_point_long,
                    order.End_point_lat, order.End_point_long, order.Child, order.Pets);
                ViewData["Id_order"] = id_order;
                return View("ConfirmOrder");
            }
            catch(Exception sqlException)
            {
                ///TODO: обработка ошибки и вызврат существующего номера заказа
                ModelState.AddModelError("", sqlException.Message);
                return View("MakeOrder");
            }
        }

        [HttpGet]
        [Route("Confirm")]
        public IActionResult ConfirmOrder()
        {
            return View("ConfirmOrder");
        }

        [HttpPost]
        [Route("Confirm")]
        public IActionResult ConfirmOrder(long Id_order, int Code)
        {
            if (Code > 0 && Id_order > 0)
                if (_context.ConfirmOrder(Id_order, Code) == 1)
                    return RedirectToAction("Start", "Order", _context.Orders.First(u=>u.id == Id_order));

            ModelState.AddModelError("", "Not correct code, try again");
            ViewData["Id_order"] = Id_order;
            return View("ConfirmOrder");
        }

        [HttpGet]
        [Route("Monitor")]
        [Authorize]
        public IActionResult MonitorOrders()
        {
            return View("MonitorOrders");
        }

        [HttpGet]
        [Route("GetListOfOrders")]
        [Authorize]
        public JsonResult ListOfOrders()
        {
            IEnumerable<NotAcceptedOrdersForDriver_Result> list = _context.NotAcceptedOrdersForDriver(User.Identity.Name);
            return Json(list.OrderByDescending(u => u.date_start_order));
        }

        [HttpGet]
        [Route("Accept/{id_order}")]
        [Authorize]
        public IActionResult AcceptOrder(long id_order)
        {
            //try
            //{
            //_context.AcceptOrder(User.Identity.Name, id_order);
            var a = _context.Orders.Find(id_order);
            return View("StartOrder", a);//.First(u=>u.id == id_order));
            //}
            //catch (Exception err)
            //{
            //    ModelState.AddModelError("", err.Message);
            //    return RedirectToAction("MonitorOrders", "Order");
            //}
        }

        [HttpGet]
        [Route("EndOrder/{id_order}")]
        public IActionResult EndOrder(long id_order)
        {
            if (User.Identity.IsAuthenticated)
            {

            }
            else
            {

            }
            try
            {
                //_context.AcceptOrder(User.Identity.Name, id_order);
                return View("StartOrder");
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                return RedirectToAction("MonitorOrders", "Order");
            }
        }

    }
}