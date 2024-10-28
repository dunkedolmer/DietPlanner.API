using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DietPlannerAPI.Recipes
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        // GET: api/meal
        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetRecipes()
        {
            return Ok(_recipeService.GetAllRecipes());
        }

        // GET: api/meal/{id}
        [HttpGet("{id}")]
        public ActionResult<Recipe> GetRecipeByID(int id)
        {
            var recipe = _recipeService.GetRecipeByID(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }
    }
}