using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI_MVC.Models.Database;
using UI_MVC.Models.Entities;
using UI_MVC.Services;

namespace UI_MVC.Controllers
{
    public class PeopleController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IPeopleRepository _peopleRepository;
        
        public PeopleController(
            AppDbContext context,
            IPeopleRepository peopleRepository)
        {
            dbContext = context;
            _peopleRepository = peopleRepository;
        }

        public IActionResult Index()
        {
            var people = _peopleRepository.GetAll();
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
            dbContext.People.Add(model);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var result = dbContext.People.Find(id);

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Person model)
        {
            var result = _peopleRepository.FindById(model.Id);

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
            var result = _peopleRepository.FindById(id);

            dbContext.People.Remove(result);
            
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
