using System;
using Challenge1.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.POCO;


namespace Challenge1.REPO
{
    public class Challenge1Repo
    {
      
        Meal[] MenuItems = {
            new Meal("Chicken Sandwhich",5.99),
            new Meal("Club Sandwhich",2.99),
            new Meal("Pork Sandwhich",8.99),
            new Meal("Beef Sandwhich",7.99),
            };
        private readonly Dictionary<int, Meal> _NewItem = new Dictionary<int, Meal>();
        private int _count = 0;
       
        //create new menu items
        public bool CreateItem(Meal meal){
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
        public Dictionary<int,Meal> GetItems()
        {
            return _NewItem;
        }
        // read one item
        public Dictionary<int, Meal> GetItemsByMealNumber(VisableMealNumber)
        {
          foreach (Meal meal in _NewItem)
            {
                if(VisableMealNumber == meal.MealNumber)
                {
                    return _NewItem;
                }
            }
        }
    }


    //update items

    //Delete Items
}



