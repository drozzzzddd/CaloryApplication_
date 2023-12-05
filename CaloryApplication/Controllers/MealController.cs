using CaloryApplication.Models;
using CaloryApplication.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;


namespace CaloryApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class MealController : ControllerBase
    {
        private IMealRepository _mealRepository;

        public MealController(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        [HttpGet("/get/meal")]

        public ActionResult<List<Meal>> GetAllMeals()
        {
            var meals = _mealRepository.GetAllMeals();
            return Ok(meals);
        }

        [HttpGet("/get/meal/id")]
        public ActionResult<List<Meal>> GetMealById(int id)
        {
            var meal = _mealRepository.GetMealById(id);
            if (meal == null) return NotFound();
            return Ok(meal);
        }


        [HttpPost("/post/meal")]

      public ActionResult Post(MealViewModel meall)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _mealRepository.AddMeal(new Meal()
            {
                ProductId = meall.ProductId,
                Quantity = meall.Quantity,
                ConsumeCalories = meall.ConsumeCalories,
                ConsumeSquirrels = meall.ConsumeSquirrels,
                ConsumeFats = meall.ConsumeFats,
                ConsumeCarbohydrates = meall.ConsumeCarbohydrates,
            });
            return Ok();
        }



        [HttpDelete("/delete/meal/{id}")]

        public ActionResult DeleteMealById(int id)
        {
            var meal = _mealRepository.GetMealById(id);

            if (meal == null)
                return NotFound();

            _mealRepository.DeleteMeal(meal);
            return Ok();
        }

    }
}

