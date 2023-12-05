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
    public class TotalCaloriesController : ControllerBase
    {
        private ITotalCaloriesRepository _totalCaloriesRepository;

        public TotalCaloriesController(ITotalCaloriesRepository totalCaloriesRepository)
        {
            _totalCaloriesRepository = totalCaloriesRepository;
        }

        [HttpGet("/get/totalCalories")]

        public ActionResult<List<TotalCalories>> GetAllTotalCalories()
        {
            var totalCalories = _totalCaloriesRepository.GetAllTotalCalories();
            return Ok(totalCalories);
        }


        [HttpGet("/get/totalCalories/{id}")]
        public ActionResult<TotalCalories> GetTotalCaloriesById(int id)
        {
            var totalCalories = _totalCaloriesRepository.GetTotalCaloriesById(id);
            if (totalCalories == null)
                return NotFound();

            return Ok(totalCalories);
        }

        [HttpPost("/post/totalCalories")]

        public ActionResult Post(TotalCaloriesViewModel totcal)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _totalCaloriesRepository.AddTotalCalories(new TotalCalories()
            {
                Date = totcal.Date,
                TotalConsumedCalories = totcal.TotalConsumedCalories,
            });
            return Ok();
        }

        [HttpDelete("/delete/product/{id}")]

        public ActionResult DeleteTotalCalories(int id)
        {
            var totalCalories = _totalCaloriesRepository.GetTotalCaloriesById(id);

            if (totalCalories == null)
                return NotFound();

            _totalCaloriesRepository.DeleteTotalCalories(totalCalories);
            return Ok();
        }
    }
}

