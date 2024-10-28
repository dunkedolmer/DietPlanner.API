namespace DietPlannerAPI.Ingredients
{
    public class Nutrition
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbohydrates { get; set; }
        public float Fats { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }

        public Nutrition(float calories, float protein, float carbohydrates, float fats, float fiber, float sugar)
        {
            Calories = calories;
            Protein = protein;
            Carbohydrates = carbohydrates;
            Fats = fats;
            Fiber = fiber;
            Sugar = sugar;
        }

        public Nutrition() { }
    }
}
