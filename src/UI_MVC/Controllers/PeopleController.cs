using Microsoft.AspNetCore.Mvc;
using UI_MVC.Models.Database;

namespace UI_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public PeopleController()
        {
            
        }

        public IActionResult Index()
        {
            var dbContext = new AppDbContext();
            var people = dbContext.People.ToList();
            
            return View(people);
        }

        public IActionResult Add()
        {
            return View();
        }

    }
}
