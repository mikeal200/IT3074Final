using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT3047Final.Data;
using IT3047Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IT3047Final.Controllers
{
    public class TrailsController : Controller
    {
        private readonly TrailContext _context;

        public TrailsController(TrailContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trails.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Trail trail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trail);
        }
    }
}
