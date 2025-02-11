using ContosoUniverstity.Data;
using ContosoUniverstity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class CoursesController : Controller
{
    private readonly SchoolContext _context;

    public CoursesController(SchoolContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var courses = await _context.Courses.ToListAsync();
        return View(courses);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var course = await _context.Courses
            .Include(c => c.Enrollments)
            .FirstOrDefaultAsync(m => m.CourseID == id);

        if (course == null) return NotFound();

        ViewData["IsDeleteView"] = false;
        return View("DetailsDelete", course);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();

        var course = await _context.Courses
            .Include(c => c.Enrollments)
            .FirstOrDefaultAsync(m => m.CourseID == id);

        if (course == null) return NotFound();

        ViewData["IsDeleteView"] = true;
        return View("DetailsDelete", course);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var course = await _context.Courses.FindAsync(id);

        if (course != null)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Clone(int id)
    {
        var course = _context.Courses
            .FirstOrDefault(m => m.CourseID == id);

        if (course == null)
        {
            return NotFound();
        }

        var clonedCourse = new Course
        {
            Title = course.Title,
            Credits = course.Credits,
        };

        _context.Add(clonedCourse);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

}
