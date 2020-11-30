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
    public class ParksController : Controller
    {
        private readonly ParkContext _context;

        public ParksController(ParkContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parks.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create( Park park)
        {
            if(ModelState.IsValid)
            {
                _context.Add(park);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(park);
        }
    }
}
