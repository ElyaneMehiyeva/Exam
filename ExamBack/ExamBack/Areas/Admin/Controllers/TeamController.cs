using ExamBack.DAL;
using ExamBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExamBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = _context.Teams.Any(Data => Data.FullName.Trim().ToLower() == team.FullName.Trim().ToLower());
            if (!isExist)
            {
                return NotFound();
            }

            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Team category = _context.Teams.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Teams.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Team category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Team categoryDb = _context.Teams.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            categoryDb.FullName = category.FullName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        }

}
