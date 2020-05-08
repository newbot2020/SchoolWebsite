using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using schoolwebsite.Data;
using schoolwebsite.Models;

namespace schoolwebsite.Controllers
{
    public class StudentdetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentdetailsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Results.Include(m => m.Subjects).Include(m => m.Students).ToList();
            return View(result);
        }
        public IActionResult Indextest()
        {
            var result = _context.Results.Include(m => m.Subjects).Include(m => m.Students).ToList();
            return Json(result);
        }
    }
}