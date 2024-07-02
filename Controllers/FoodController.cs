using FA.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {

        private readonly FoodService _foodService;
        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("GetFoodItems")]
        public IActionResult Get()
        {
            return Ok(_foodService.GetAll().ToArray());
        }


        [HttpPost("PostFoodItems")]
        public IActionResult Post(Food food)
        {
            if (_foodService.GetById(food.Id) is null)
            {
                _foodService.Add(food);
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
            _foodService.Update(id, f);
            return Ok();

        }

        [HttpDelete("DeleteFoodItems")]
        public IActionResult Delete(int id)
        {
            _foodService.Delete(id);
            return Ok();
        }



    }
}
