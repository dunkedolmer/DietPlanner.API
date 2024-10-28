using DietPlannerAPI.Recipes;

namespace DietPlannerAPI.DietPlan
{
    public class DietPlan
    {
        public int ID { get; set; } 
        public string Name { get; set; }  
        public List<Recipe> Recipes { get; set; }

        public DietPlan(int id, string name, List<Recipe> recipes = null)
        {
            ID = id;
            Name = name;
            Recipes = recipes ?? new List<Recipe>();  // Initialize with an empty list if recipes is null
        }

        public void generatePlan()
        {
            // TODO: Generate a dietplan based on user preferences (this will be an input parameter)
        }
    }
}
