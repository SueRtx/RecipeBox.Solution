using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RecipeBox.Models;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {
    private readonly RecipeBoxContext _db;
    public HomeController(RecipeBoxContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Categories = _db.Categories.ToList();
      ViewBag.Recipes = _db.Recipes.ToList();
      return View();
    }

  }
}