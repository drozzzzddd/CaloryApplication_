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

      public ActionResult Post(Meal meall)
        {
            if (ModelState.IsValid)
            {
                // Создание нового экземпляра Meal на основе данных из mealViewModel
                var meal = new Meal
                {
                    DateTime = meall.DateTime,
                    ProductId = meall.ProductId,
                    Quantity = meall.Quantity
                };

                // Добавление meal в базу данных

                return Ok();
            }

            return BadRequest();
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

