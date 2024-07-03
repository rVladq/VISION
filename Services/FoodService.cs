using FA;
using FA.Models;
using Microsoft.OpenApi.Validations;

public class FoodService
{
    private MyDbContext _dbContext;
    public FoodService(MyDbContext context) {
        _dbContext = context;
    }

    public List<Food> GetAll()
    {
        return _dbContext.Set<Food>().ToList();
    }

    public Food? GetById(int id)
    {
        return _dbContext.Set<Food>().FirstOrDefault(food => food.Id == id);
    }

    public void Add(Food f)
    {
        _dbContext.Set<Food>().Add(f);
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {

        if (id > _dbContext.Set<Food>().Count() || id < 1) { return; }
        var set = _dbContext.Set<Food>();
        Food toModify = set.FirstOrDefault(x => x.Id == id);
        if (toModify != null)
            set.Remove(toModify);
        _dbContext.SaveChanges();

    }

    public List<Food> FindByName(string name)
    {
        List<Food> foundItems = new List<Food>();

        foreach (var item in _dbContext.Set<Food>())
        {
            if (item.Name == name)
            {
                foundItems.Add(item);
            }
        }
        return foundItems;
    }

    public void Update(int id, Food f)
    {
        Food toModify = _dbContext.Set<Food>().FirstOrDefault(x => x.Id == id);
        if (toModify != null)
        {
            _dbContext.Remove(toModify);
            _dbContext.SaveChanges();
        }
    }

    public List<Food> returnPage(int page, int elements)
    {
        return _dbContext.Set<Food>().Skip<Food>(page*elements).Take<Food>(elements).ToList<Food>();
    }

/*    public Food getRandom()
    {
        var set = _dbContext.Set<Food>();
        int rnd = new Random().Next(1, set.Count());

        Food randomItem = context.Find(x => x.Id == rnd);
        if (randomItem != null)
            return randomItem;

        return null;

    }*/

}