using FA.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly FoodService foodService;
        public FoodController(FoodService _foodService)
        {
            foodService = _foodService;
        }

        [HttpGet("GetFoodItems")]
        public IActionResult Get()
        {
            return Ok(foodService.GetAll().ToArray());
        }

        [HttpGet("GetOddItems")]
        public IActionResult foo()
        {
            List<Food> arr = foodService.GetAll().ToList();
            arr = arr.Where(food => food.Id % 2 != 0).ToList();

            return Ok(arr.ToArray());
        }

        [HttpGet("Pages")]
        public IActionResult boo(int page, int noelements)
        {
            return Ok(foodService.returnPage(page - 1 , noelements));
        }

        [HttpPost("PostFoodItems")]
        public IActionResult Post(Food food)
        {
            if (foodService.GetById(food.Id) is null)
            {
                foodService.Add(food);
                return Ok("Food was added sucessfully");
            }
            else
            {
                return BadRequest("Foods exists already.");
            }
        }

        [HttpPut("PutFoodItems")]
        public IActionResult Put(int id, Food f)
        {
            foodService.Update(id, f);
            return Ok();

        }

        [HttpDelete("DeleteFoodItems")]
        public IActionResult Delete(int id)
        {
            foodService.Delete(id);
            return Ok();
        }

    }
}
