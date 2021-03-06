﻿using System;
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
    [Route("Venichle")]
    [Authorize]
    public class VenichlesController : Controller
    {
        private readonly TaxiStationContext _context;

        public VenichlesController(TaxiStationContext context)
        {
            _context = context;
        }

        [HttpGet]
        //[Route("Index")]
        public IActionResult Index()
        {
            ViewData["id_venicle_type"] = _context.Order_types.ToList();
            List<AddVenichle> list = new List<AddVenichle>();
            foreach(var ven in _context.Venichles.Where(a => a.id_driver.Equals(User.Identity.Name)).ToList())
            {
                list.Add(new AddVenichle()
                {
                    number = ven.number,
                    model = ven.model,
                    id_venichle_type = ven.venicle_type,
                    child = ven.child,
                    pets = ven.pets
                });
            }
            return View("Index", list);
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            ViewData["id_venichle_type"] = new SelectList(_context.Order_types, "id", "name");
            return View("AddVenichle");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Add")]
        public async Task<IActionResult> Add([Bind("number,child,pets,model,id_venichle_type")] AddVenichle addVenichle)
        {
            if (ModelState.IsValid)
            {
                _context.Venichles.Add(new Venichles() {
                    id_driver = User.Identity.Name,
                    number = addVenichle.number,
                    child = addVenichle.child,
                    pets = addVenichle.pets,
                    model = addVenichle.model,
                    venicle_type = addVenichle.id_venichle_type
                });
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View("AddVenichle");
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Venichles ven =  _context.Venichles.First(u => u.number == id);

            var addVenichle = new AddVenichle()
            {
                number = ven.number,
                model = ven.model,
                id_venichle_type = ven.venicle_type,
                child = ven.child,
                pets = ven.pets
            };
            ViewData["id_venichle_type"] = new SelectList(_context.Order_types, "id", "name");
            return View("Edit", addVenichle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(string id, [Bind("number,child,pets,model,id_venichle_type")] AddVenichle addVenichle)
        {
            if (id != addVenichle.number)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Venichles ven = _context.Venichles.First(u => u.number == id);
                    ven.id_driver = User.Identity.Name;
                    ven.number = addVenichle.number;
                    ven.child = addVenichle.child;
                    ven.pets = addVenichle.pets;
                    ven.model = addVenichle.model;
                    ven.venicle_type = addVenichle.id_venichle_type;

                    _context.Update(ven);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", "Error");
                }
                return RedirectToAction("Index");
            }
            return View("Edit", addVenichle);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var venichle = _context.Venichles.First(u => u.number == id);
            _context.Venichles.Remove(venichle);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
