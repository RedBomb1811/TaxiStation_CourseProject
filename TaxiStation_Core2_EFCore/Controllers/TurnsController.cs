using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestExample.DB;

namespace TaxiStation_Core2_EFCore.Controllers
{
    [Route("Turn")]
    [Authorize]
    public class TurnsController : Controller
    {
        private readonly TaxiStationContext _context;

        public TurnsController(TaxiStationContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Start")]
        public IActionResult StartTurn()
        {
            ViewData["id_venichle"] = new SelectList(_context.Venichles.Where(u=>u.id_driver.Equals(User.Identity.Name)), "id", "model");
            return View("Start");
        }

        [HttpPost]
        [Route("Start")]
        public IActionResult StartTurn(Turns turn)
        {
            try
            {
                _context.StartTurn(User.Identity.Name, turn.id_venichle);
                return RedirectToAction("Monitor", "Order");
            }
            catch (Exception exc)
            {
                ModelState.AddModelError("", exc.Message);
                ViewData["ErrorMessage"] = exc.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Route("End")]
        public IActionResult EndTurn()
        {
            try
            {
                _context.EndTurn(User.Identity.Name);
                ///TODO: комната водителя
                return RedirectToAction("Index", "Home");
            }
            catch (Exception exc)
            {
                ModelState.AddModelError("", exc.Message);
                return RedirectToAction("Monitor", "Order");
            }
        }


        //// GET: Turns
        //public async Task<IActionResult> Index()
        //{
        //    var taxiStationContext = _context.Turns.Include(t => t.Drivers).Include(t => t.Venichles);
        //    return View(await taxiStationContext.ToListAsync());
        //}

        //// GET: Turns/Details/5
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var turns = await _context.Turns
        //        .Include(t => t.Drivers)
        //        .Include(t => t.Venichles)
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (turns == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(turns);
        //}

        //// GET: Turns/Create
        //public IActionResult Create()
        //{
        //    ViewData["id_driver"] = new SelectList(_context.Drivers, "id", "id");
        //    ViewData["id_venichle"] = new SelectList(_context.Venichles, "id", "id");
        //    return View();
        //}

        //// POST: Turns/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("id,id_venichle,id_driver,date_start,date_end")] Turns turns)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(turns);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["id_driver"] = new SelectList(_context.Drivers, "id", "id", turns.id_driver);
        //    ViewData["id_venichle"] = new SelectList(_context.Venichles, "id", "id", turns.id_venichle);
        //    return View(turns);
        //}

        //// GET: Turns/Edit/5
        //public async Task<IActionResult> Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var turns = await _context.Turns.FindAsync(id);
        //    if (turns == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["id_driver"] = new SelectList(_context.Drivers, "id", "id", turns.id_driver);
        //    ViewData["id_venichle"] = new SelectList(_context.Venichles, "id", "id", turns.id_venichle);
        //    return View(turns);
        //}

        //// POST: Turns/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(long id, [Bind("id,id_venichle,id_driver,date_start,date_end")] Turns turns)
        //{
        //    if (id != turns.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(turns);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TurnsExists(turns.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["id_driver"] = new SelectList(_context.Drivers, "id", "id", turns.id_driver);
        //    ViewData["id_venichle"] = new SelectList(_context.Venichles, "id", "id", turns.id_venichle);
        //    return View(turns);
        //}

        //// GET: Turns/Delete/5
        //public async Task<IActionResult> Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var turns = await _context.Turns
        //        .Include(t => t.Drivers)
        //        .Include(t => t.Venichles)
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (turns == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(turns);
        //}

        //// POST: Turns/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(long id)
        //{
        //    var turns = await _context.Turns.FindAsync(id);
        //    _context.Turns.Remove(turns);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool TurnsExists(long id)
        //{
        //    return _context.Turns.Any(e => e.id == id);
        //}
    }
}
