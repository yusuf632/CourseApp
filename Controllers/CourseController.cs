using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            //return Redirect("/course/list");
            return RedirectToAction("list","course");
        }

        var kurs = repository.GetById(id);

        return View(kurs);
    }
    public IActionResult List()
    {
        return View("CourseList", repository.Courses);
    }
}