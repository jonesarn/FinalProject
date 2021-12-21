using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.POCO
{
    public class Meal
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredience { get; set; }
        public double MealPrice { get; set; }

        public Meal( string mealName, double mealPrice)
        {
           
            this.MealName = mealName;
            this.MealPrice = mealPrice;
        }
    }
}
