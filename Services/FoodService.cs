using FA;
using FA.Models;
using Microsoft.OpenApi.Validations;

public class FoodService
{
    private MyDbContext dbContext;
    public FoodService(MyDbContext _dbContext) {
        dbContext = _dbContext;
    }

    public List<Food> GetAll()
    {
        return dbContext.Set<Food>().ToList();
    }

    public Food? GetById(int id)
    {   
        return dbContext.Set<Food>().FirstOrDefault(food => food.Id == id);
    }

    public void Add(Food f)
    {
        dbContext.Set<Food>().Add(f);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {

        if (id > dbContext.Set<Food>().Count() || id < 1) { return; }
        var set = dbContext.Set<Food>();
        Food toModify = set.FirstOrDefault(x => x.Id == id);
        if (toModify != null)
            set.Remove(toModify);
        dbContext.SaveChanges();

    }

    public List<Food> FindByName(string name)
    {
        List<Food> foundItems = new List<Food>();

        foreach (var item in dbContext.Set<Food>())
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
        Food toModify = dbContext.Set<Food>().FirstOrDefault(x => x.Id == id);
        if (toModify != null)
        {
            dbContext.Remove(toModify);
            dbContext.SaveChanges();
        }
    }

    public List<Food> returnPage(int page, int elements)
    {
        return dbContext.Set<Food>().Skip<Food>(page*elements).Take<Food>(elements).ToList<Food>();
    }

/*    public Food getRandom()
    {
        var set = dbContext.Set<Food>();
        int rnd = new Random().Next(1, set.Count());

        Food randomItem = context.Find(x => x.Id == rnd);
        if (randomItem != null)
            return randomItem;

        return null;

    }*/

}