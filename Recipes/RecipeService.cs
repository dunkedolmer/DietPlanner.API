using MongoDB.Driver;
using System.Runtime.CompilerServices;

namespace DietPlannerAPI.Recipes
{
    public class RecipeService
    {
        private readonly MongoDbContext _context;

        public RecipeService(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            return await _context.Recipes.Find(_ => true).ToListAsync();
        }

        public async Task AddRecipeAsync(Recipe recipe)
        {
            await _context.Recipes.InsertOneAsync(recipe);
        }
    }
}
