
using Day1.Models;
using System.Collections.Immutable;

namespace Day1.Services


{

    public class DrinkService
    {
        private List<Drink> context = new List<Drink> {
        new Drink{Id=1, Name="Drink1", Description="Sweet", Price=10},
        new Drink{Id=2, Name="Drink2", Description="Sour", Price = 12},
        new Drink{Id=3, Name="Drink3", Description="Sweet&Sour", Price = 6},
        new Drink{Id=4, Name="Drink4", Description="Sparkling", Price = 8},
        new Drink{Id=5, Name="Drink5", Description="Coffee", Price = 4},
        new Drink{Id=6, Name="Drink6", Description="Water", Price = 3},
        new Drink{Id=7, Name="Drink7", Description="Lemonade", Price=10}
        };

        public DrinkService() { }

        public List<Drink> GetAll()
        {
            return context;
        }

        public Drink? GetById(int id)
        {
            return context.FirstOrDefault(d =>  d.Id == id);

        }

        public void Add(Drink drink)
        {
            context.Add(drink);   
        }

        public void Delete(int id)
        {
            var drink = context.FirstOrDefault(d => d.Id == id);
            context.Remove(drink);
        }
        public List<Drink> FindByName(string name)
        {
            List<Drink> list = new List<Drink> ();
            foreach (Drink drink in context)
            {
                if(drink.Name == name)
                    list.Add(drink);
            }
            return list;
        }
        public void Update(int id, Drink drink)
        {
            var check = context.FirstOrDefault(u => u.Id == id);
            if (check != null)
            {
                check.Name = drink.Name;
                check.Description = drink.Description;
                check.Price = drink.Price;
            }
        }
        public Drink GetRandom()
        {
            Random random = new Random();
            return context[random.Next(context.Count)];
        }

    }

}