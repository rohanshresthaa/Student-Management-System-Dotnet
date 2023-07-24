using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class LoginsController : Controller
    {
        private readonly MyDBContext _context;

        public LoginsController(MyDBContext context)
        {
            _context = context;
        }



        // GET: Logins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password")] Login login)
        {
            try
            {
                var datExist = await _context.SignUps.FirstOrDefaultAsync(x=> x.UserName.ToLower()==login.UserName.ToLower() && x.Password.ToLower()==login.Password.ToLower()) ;
                if(datExist != null)
                {

                }
                else
                {
                    return RedirectToAction("Create", "Signups");
                }

            }
            catch (Exception ex)
            {

            }

            //if (ModelState.IsValid)
            //{
            //    _context.Add(login);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            return View(login);
        }
    }
}
