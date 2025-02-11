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

}
