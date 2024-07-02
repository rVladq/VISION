using FA.Models;
using System.ComponentModel.Design;
using System.Reflection;

public class FoodService
{
    private List<Food> context = new List<Food> {
            new Food { Id = 0, Name = "Burger", Description = ".", Recipe = "meat" },
            new Food { Id = 1, Name = "Cheesburger", Description = "..", Recipe = "meat, cheese" },
            new Food { Id = 2, Name = "Chicken", Description = "...", Recipe = "meat" },
            new Food { Id = 3, Name = "Scrambled Eggs", Description = "....", Recipe = "eggs" }
        };

    public FoodService() { }

    public List<Food> GetAll()
    {
        return context;
    }

    public Food? GetById(int id)
    {
        return context.FirstOrDefault(food => food.Id == id);
    }

    public void Add( Food f )
    {
        context.Add(f);
    }

    public void Delete(int id)
    {

        if (id > context.Count || id < 1) { return; }
        Food toModify = context.FirstOrDefault(x => x.Id == id);
        if (toModify != null)
            context.Remove(toModify);
    
    }

    public List<Food> FindByName(string name)
    {
        List<Food> foundItems = new List<Food>();

        foreach (var item in context)
        {
            if(item.Name == name)
            {
                foundItems.Add(item);
            }
        }
        return foundItems;
    }

    public void Update(int id, Food f)
    {
        Food toModify = context.FirstOrDefault(x => x.Id == id);
        if (toModify != null)
        {
            context.Remove(toModify );
            context.Add(f);
        }
    }

    public Food getRandom()
    {
        int rnd = new Random().Next(1, context.Count);
        
        Food randomItem = context.Find(x => x.Id == rnd);
        if (randomItem != null)
            return randomItem;

        return null; 

    }

}