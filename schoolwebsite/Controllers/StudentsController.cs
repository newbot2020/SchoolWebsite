﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using schoolwebsite.Data;
using schoolwebsite.Models;

namespace schoolwebsite.Controllers
{
    public class StudentsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;


        public StudentsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var result = await _context.Students.ToListAsync();                
                return View(result);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students
                .FirstOrDefaultAsync(m => m.id == id);
            if (students == null)
            {
                return NotFound();
            }

            return View(students);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,classinfo,roll,section,address,parentscontact,username,password,Image")] Students students)
        {
            
            if (ModelState.IsValid)
            {
                if (students.Image != null)
                {

                    TempData["save"] = "Submitted Successfully";
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(students.Image.FileName);
                    string extension = Path.GetExtension(students.Image.FileName);
                    students.Imagefilename = filename = students.Name + DateTime.Now.ToString("yymmss") + extension;
                    string foldername = students.classinfo.ToString();


                    string path2 = wwwRootPath + "\\Images\\" + "\\2020\\" + foldername;

                    if (!Directory.Exists(path2))
                        Directory.CreateDirectory(path2);
                    //Directory.CreateDirectory("wwwRootPath\\Images\\2020\\"+foldername);
                    string path = Path.Combine(wwwRootPath + "/Images/2020", foldername, filename);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await students.Image.CopyToAsync(fileStream);
                    }
                }
                _context.Add(students);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            return View(students);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FindAsync(id);
            if (students == null)
            {
                return NotFound();
            }
            return View(students);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,classinfo,roll,section,address,parentscontact,username,password")] Students students)
        {
            if (id != students.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(students);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsExists(students.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["edit"] = "Edited Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(students);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students
                .FirstOrDefaultAsync(m => m.id == id);
            if (students == null)
            {
                return NotFound();
            }

            return View(students);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var students = await _context.Students.FindAsync(id);
            _context.Students.Remove(students);
            await _context.SaveChangesAsync();
            TempData["delete"] = "Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }



        public JsonResult Namecheck(string userdata)
        {
            var search = _context.Students.Any(e => e.username == userdata);
            if (search)
            {
                return Json(1);
            }
            else { return Json(0); }
        }
        public IActionResult Jsonshow(int id)
        {
            return Json(_context.Students.Find(id));
        } 
        private bool StudentsExists(int id)
        {
            return _context.Students.Any(e => e.id == id);
        }
    }
    

           
}
