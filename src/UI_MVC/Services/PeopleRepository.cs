using UI_MVC.Models.Database;
using UI_MVC.Models.Entities;

namespace UI_MVC.Services;

public class PeopleRepository : IPeopleRepository
{
    private readonly AppDbContext _appDbContext;

    public PeopleRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public List<Person> GetAll()
    {
        return _appDbContext.People.ToList();
    }

    public Person FindById(int id)
    {
        return _appDbContext.People.Find(id);
    }
}