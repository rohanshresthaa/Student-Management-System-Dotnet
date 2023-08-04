using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;
using Student_Management_System.ViewModel;

namespace Student_Management_System.Controllers
{
    public class AttendencesController : Controller
    {
        private readonly MyDBContext _context;

        public AttendencesController(MyDBContext context)
        {
            _context = context;
        }

        // GET: Attendences
        public async Task<IActionResult> Index()
        {
            return _context.Attendances != null ?
                        View(await _context.Attendances.ToListAsync()) :
                        Problem("Entity set 'MyDBContext.Attendances'  is null.");
        }

        // GET: Attendences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Attendances == null)
            {
                return NotFound();
            }

            var attendence = await _context.Attendances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attendence == null)
            {
                return NotFound();
            }

            return View(attendence);
        }

        // GET: Attendences/Create
        public async Task<IActionResult> Create()
        {
            var model = new AttendanceViewModel();
            try
            {
                var groupData = _context.Groups.Where(x => x.Name != null).Select(x => new Group { Id = x.Id, Name = x.Name }).ToList();
                model.GroupData = groupData;
                var levelData = await _context.Levels.ToListAsync();
                model.LevelData = levelData;
                var courseData = await _context.Courses.ToListAsync();
                model.CourseData = courseData;
                model.Date = DateTime.Now;
            }
            catch (Exception ex)
            {

            }
            ViewData["AttendanceDataList"] = model;
            return View();
        }

        // POST: Attendences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> Create([Bind("Id,Date,CourseId,LevelId,GroupId")] Attendence attendence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attendence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          
            return View(attendence);
        }

        // GET: Attendences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Attendances == null)
            {
                return NotFound();
            }

            var attendence = await _context.Attendances.FindAsync(id);
            if (attendence == null)
            {
                return NotFound();
            }
            return View(attendence);
        }

        // POST: Attendences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,CourseId,LevelId,GroupId")] Attendence attendence)
        {
            if (id != attendence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attendence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendenceExists(attendence.Id))
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
            return View(attendence);
        }

        // GET: Attendences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Attendances == null)
            {
                return NotFound();
            }

            var attendence = await _context.Attendances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attendence == null)
            {
                return NotFound();
            }

            return View(attendence);
        }

        // POST: Attendences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Attendances == null)
            {
                return Problem("Entity set 'MyDBContext.Attendances'  is null.");
            }
            var attendence = await _context.Attendances.FindAsync(id);
            if (attendence != null)
            {
                _context.Attendances.Remove(attendence);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendenceExists(int id)
        {
            return (_context.Attendances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public async Task<IActionResult> getStudentData(AttendanceFilterModel model)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            return Json(null);
        }
    }
}
