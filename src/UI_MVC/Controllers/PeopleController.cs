using Microsoft.AspNetCore.Mvc;
using UI_MVC.Models.Database;
using UI_MVC.Models.Entities;

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

        //[HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Person model)
        {
            //var context = HttpContext.Request.Form;
            var dbContext = new AppDbContext();
            dbContext.People.Add(model);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var dbContext = new AppDbContext();
            var result = dbContext.People.Find(id);

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Person model)
        {
            var dbContext = new AppDbContext();
            var result = dbContext.People.Find(model.Id);

            result.FirstName = model.FirstName;
            result.LastName = model.LastName;
            result.PhoneNumber = model.PhoneNumber;
            result.CityName = model.CityName;

            //dbContext.People.Update(result);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var dbContext = new AppDbContext();
            
            var result = dbContext.People.Find(id);

            dbContext.People.Remove(result);
            
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
