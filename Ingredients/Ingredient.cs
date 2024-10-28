namespace DietPlannerAPI.Ingredients
{
    public class Ingredient
    {
        public int ID { get; }
        public string Name { get; set; }
        public float Quantity { get; set; }  
        public string Unit { get; set; }
        public Nutrition Nutrition { get; set; } 
        
        public Ingredient(string name, float quantity, string unit, Nutrition nutrition)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Nutrition = nutrition;
        }

        /// <summary>
        /// Calculates the nutritional content of the ingredient based on a specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity of the ingredient to calculate nutrition for.</param>
        /// <returns>A <see cref="Nutrition"/> object representing the scaled nutritional content for the specified quantity.</returns>
        public Nutrition GetNutrition(float quantity)
        {
            float factor = quantity / Quantity;  // Calculate the scaling factor based on input quantity
            return new Nutrition
            {
                Calories = Nutrition.Calories * factor,
                Protein = Nutrition.Protein * factor,
                Carbohydrates = Nutrition.Carbohydrates * factor,
                Fats = Nutrition.Fats * factor,
                Fiber = Nutrition.Fiber * factor,
                Sugar = Nutrition.Sugar * factor
            };
        }

        /// <summary>
        /// Returns a string representation of the ingredient, displaying its name, amount, and unit.
        /// </summary>
        /// <returns>A string in the format of "Name - Amount Unit".</returns>
        public override string ToString()
        {
            return $"{Name} - {Quantity} {Unit}";
        }
    }
}
