using System;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;

namespace RectangleChecker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("RectangleForm");
    }

    [HttpGet("/rectangle_result")]
    public ActionResult Result()
    {
      Rectangle myRectangle = new Rectangle(Int32.Parse(Request.Query["side-length"]), Int32.Parse(Request.Query["side-width"]));
      return View("RectangleResult", myRectangle);
    }
  }
}
