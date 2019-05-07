using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaxiStation_Core2_EFCore.Models.Registrarion;
using TestExample.DB;

namespace TaxiStation_Core2_EFCore.Controllers
{
    [Route("Driver")]
    public class DriversController : Controller
    {
        private readonly TaxiStationContext _context;

        public DriversController(TaxiStationContext context)
        {
            _context = context;
        }

#region Register
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View("LoginDriver");
        }

        [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDriver model)
        {
            if (ModelState.IsValid)
            {
                string model_password_hash = Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(model.Password)));
                Drivers user = await _context.Drivers.FirstOrDefaultAsync(u => u.phone_number == model.Phone_number && u.pass_hash == model_password_hash);
                if (user != null)
                {
                    await Authenticate(model.Phone_number); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ViewBag.Message = "Некорректные номер и(или) пароль";
                    ModelState.AddModelError("", "Некорректные номер телефона и(или) пароль");
                }
            }
            return View("LoginDriver", model);
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            return View("RegisterDriver");
        }

        [HttpPost]
        [Route("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDriver model)
        {
            if (ModelState.IsValid)
            {
                Drivers user = await _context.Drivers.FirstOrDefaultAsync(u => u.phone_number == model.Phone_number);
                if (user == null)
                {
                    int ret = _context.RegisterDriverFromNumber(
                        model.Phone_number,
                        Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(model.Password))),
                        model.First_name,
                        model.Second_name,
                        model.Birth_date,
                        model.Sex,
                        model.Pass_number,
                        model.Email
                        );
                    ViewBag.Code = ret;

                    await Authenticate(model.Phone_number); // аутентификация

                    ViewData["Phone_number"] = model.Phone_number;
                    return View("ConfirmDriver");
                }
                else
                {
                    //ViewBag.Message = "Некорректные номер и(или) пароль";
                    ModelState.AddModelError("", "Некорректные номер и(или) пароль");
                }
            }
            return View("RegisterDriver", model);
        }

        [HttpGet]
        [Route("Confirm")]
        public IActionResult ConfirmDriver()
        {
            return View("ConfirmDriver");
        }

        [HttpPost]
        [Route("Confirm")]
        public IActionResult ConfirmDriver(int Code)
        {
            // Make this shiiiiiiit
            if (Code <= 0)
                ModelState.AddModelError("", "Not correct code, try again");
            return View("ConfirmDriver");
        }

        private async Task Authenticate(string phoneNum)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, phoneNum)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Driver");
        }
#endregion

        public async Task<IActionResult> Index()
        {
            return View(await _context.Drivers.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivers = await _context.Drivers
                .FirstOrDefaultAsync(m => m.id == id);
            if (drivers == null)
            {
                return NotFound();
            }

            return View(drivers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,first_name,second_name,birth_date,sex,phone_number,pass_number,rating_sum,rating_count,email,pass_hash")] Drivers drivers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drivers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drivers);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivers = await _context.Drivers.FindAsync(id);
            if (drivers == null)
            {
                return NotFound();
            }
            return View(drivers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,first_name,second_name,birth_date,sex,phone_number,pass_number,rating_sum,rating_count,email,pass_hash")] Drivers drivers)
        {
            if (id != drivers.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drivers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriversExists(drivers.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drivers);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivers = await _context.Drivers
                .FirstOrDefaultAsync(m => m.id == id);
            if (drivers == null)
            {
                return NotFound();
            }

            return View(drivers);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drivers = await _context.Drivers.FindAsync(id);
            _context.Drivers.Remove(drivers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DriversExists(int id)
        {
            return _context.Drivers.Any(e => e.id == id);
        }
    }
}
