using System;
using Challenge1.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Challenge1.REPO
{
    public class Challenge1Repo
    {

       
           
          
        public readonly Dictionary<int, Meal> _NewItem = new Dictionary<int, Meal>();

    private int _count = 0;

    //create new menu items
    public bool CreateItem(Meal meal)
    {
        if (meal == null)
        {
            return false;
        }
        else
        {
            _count++;
            meal.MealNumber = _count;
            _NewItem.Add(meal.MealNumber, meal);
            return true;
        }
    }
    // read all items presented
    public Dictionary<int, Meal> GetItems()
    {
        return _NewItem;
    }
    // read one item

    public Meal GetItemsByMealNumber(int mealNumber)
    {

        foreach (KeyValuePair<int, Meal> meal in _NewItem)
        {
            if (meal.Key == mealNumber)
            {
                return meal.Value;
            }
            else if (meal.Key != mealNumber)
            {

                return null;
            }
        }
        return null;
    }

    //update items
    public bool UpdatePlayer(int mealNumber, Meal NewMealInfo)
    {
        Meal OldMealInfo = GetItemsByMealNumber(mealNumber);
        if (OldMealInfo != NewMealInfo)
        {
            OldMealInfo.MealName = NewMealInfo.MealName;
            OldMealInfo.MealPrice = NewMealInfo.MealPrice;
            return true;
        }
        else
        {
            return false;
        }
    }

    //Delete Items

    public bool DeleteItem(int mealNumber)
    {
        bool wasDeleted = _NewItem.Remove(mealNumber);
        return wasDeleted;
    }
}
}




