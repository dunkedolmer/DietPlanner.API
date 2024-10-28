using DietPlannerAPI.Ingredients;
using System.Collections;

namespace DietPlannerAPI.Recipes
{
    public class Recipe
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public string Procedure { get; set; }

        public int Servings { get; set; }  

        public string Source { get; set; } // e.g. the URL to the recipe

        public Recipe(int id, string name, List<Ingredient> ingredients, string procedure, int servings, string source)
        {
            ID = id;
            Name = name;
            Ingredients = ingredients ?? new List<Ingredient>(); // Initialize with an empty list if ingredients is null
            Procedure = procedure;
            Servings = servings;
            Source = source;
        }

        public void scaleRecipe(int servings)
        {

        }

        public List<Ingredient> getIngredientList()
        {
            return Ingredients;
        }
    }
}