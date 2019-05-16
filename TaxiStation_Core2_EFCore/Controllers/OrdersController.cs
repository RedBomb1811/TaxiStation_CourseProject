using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nexmo.Api;
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


        #region Client
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
            try
            {
                long id_order = _context.MakeOrder(order.Phone_number, order.Id_order_type, order.Start_point_lat, order.Start_point_long,
                    order.End_point_lat, order.End_point_long, order.Child, order.Pets);
                if (id_order != 0)
                {
                    var real_order = _context.Orders.Find(id_order);
                    Regex regex = new Regex("^((375)+([0-9]){9})$");

                    if (regex.IsMatch(real_order.id_client))
                    {
                        var client = new Client(creds: new Nexmo.Api.Request.Credentials
                        {
                            ApiKey = "4dd35858",
                            ApiSecret = "uEKy30WoKHpgQaBa"
                        });
                        SMS.SMSRequest sms = new SMS.SMSRequest()
                        {
                            from = "TaxiStation_Course",
                            //to = "375292953436",
                            to = real_order.id_client,
                            text = "Security Code for order " + real_order.id + ": " + real_order.security_code
                        };

                        ////////var results = client.SMS.Send(sms);
                        ViewData["Id_order"] = id_order;
                        return View("ConfirmOrder");
                    }
                    else
                        throw new Exception(message: "Order didnt create!");
                }
                else
                    throw new Exception(message: "Order didnt create!");
            }
            catch (Exception sqlException)
            {
                ModelState.AddModelError("", sqlException.Message);
                return View("MakeOrder");
            }
        }

        [HttpGet]
        [Route("Confirm")]
        public IActionResult ConfirmOrder(int id_order)
        {
            ViewData["Id_order"] = id_order;
            return View("ConfirmOrder");
        }

        [HttpPost]
        [Route("Confirm")]
        public IActionResult ConfirmOrder(long Id_order, int Code)
        {
            if (Code > 0 && Id_order > 0)
                if (_context.ConfirmOrder(Id_order, Code) == 1)
                {
                    ViewData["id_order"] = Id_order;
                    ViewData["sec_code"] = Code;
                    return View("WaitDriver");
                }
            //return AcceptedOrderInfoForClient(Id_order, Code);
            //return RedirectToAction("AcceptedOrderInfoForClient", "Order", _context.Orders.First(u => u.id == Id_order));
            ModelState.AddModelError("", "Not correct code, try again");
            ViewData["Id_order"] = Id_order;
            return View("ConfirmOrder");
        }

        //Call from Ajax (check Driver accept order)
        [HttpGet]
        [Route("InfoJson/{id_order}/{sec_code}")]
        public JsonResult AcceptedOrderInfoForClientJson(long id_order, int sec_code)
        {
            try
            {
                var a = _context.AcceptedOrderInfoForClientProc(id_order, sec_code);
                return Json(a);
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                return Json(null);
            }
        }

        [HttpGet]
        [Route("OrderInfo/{id_order}/{sec_code}")]
        public JsonResult ClientOrderInfo(long id_order, int sec_code)
        {
            var a = _context.AcceptedOrderInfoForClientProc(id_order, sec_code);
            if (a == null)
                return Json(null);
            else return Json(a.end_confirm_driver);
            //return a == null ? Json(null) : Json(a.end_confirm_driver);
            //return Json(a.end_confirm_driver);
        }

        [HttpGet]
        [Route("Info/{id_order:long}/{sec_code:int}")]
        public IActionResult AcceptedOrderInfoForClient(long id_order, int sec_code)
        {
            try
            {
                if (_context.Orders.First(u => u.id == id_order && u.security_code == sec_code) != null)
                {
                    var a = _context.AcceptedOrderInfoForClientProc(Convert.ToInt64(id_order), Convert.ToInt32(sec_code));
                    ViewData["sec_code"] = sec_code;
                    return View("StartOrderClient", a);
                }
                else
                {
                    ModelState.AddModelError("", "Not correct code, try again");
                    ViewData["Id_order"] = id_order;
                    return View("ConfirmOrder");
                }
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", "Not correct code, try again");
                ViewData["Id_order"] = id_order;
                return View("ConfirmOrder");
            }
        }

        [HttpGet]
        [Route("EndOrder/{id_order}/{sec_code}")]
        public IActionResult EndOrderFromClient(long id_order, int sec_code)
        {
            try
            {
                _context.ClientConfirmEnd(id_order, sec_code);
                return RedirectToAction("Stars");
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                var a = _context.Orders.Find(id_order);
                return View("StartOrderClient", a);
            }
        }

        #endregion
       //---------------------------------------//
        #region Driver
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
        [Route("OrderInfo/{id_order}")]
        [Authorize]
        public JsonResult DriverOrderInfo(long id_order)
        {
            List<bool> list = _context.Orders.Where(u => u.id == id_order).Select(u => u.client_confirm_end).ToList<bool>();
            if (list == null) return Json(null);
            else return Json(list[0]);
        }

        [HttpGet]
        [Route("Info/{id_order}")]
        [Authorize]
        public IActionResult GetActiveOrderInfo(long id_order)
        {
            try
            {
                var a = _context.Orders.Find(id_order);
                return View("StartOrder", a);
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                return RedirectToAction("MonitorOrders", "Order");
            }
        }

        [HttpGet]
        [Route("Accept/{id_order}")]
        [Authorize]
        public IActionResult AcceptOrderFromDriver(long id_order)
        {
            try
            {
                _context.AcceptOrder(User.Identity.Name, id_order);
                return Redirect($"/Order/Info/{id_order}");
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                return RedirectToAction("MonitorOrders", "Order");
            }
        }

        [HttpGet]
        [Route("EndOrder/{id_order}")]
        public IActionResult EndOrderFromDriver(long id_order)
        {
            try
            {
                _context.DriverConfirmEnd(User.Identity.Name, id_order);
                return RedirectToAction("Stars");
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", err.Message);
                var a = _context.Orders.Find(id_order);
                return View("StartOrder", a);
            }
        }
        #endregion
    }
}