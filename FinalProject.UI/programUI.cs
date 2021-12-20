using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.POCO;
using Challenge1.REPO;


namespace FinalProject.UI
{

    class programUI
    {
        private readonly Challenge1Repo _cafeRepo = new Challenge1Repo();
        public void run()
        {
            Seed();
            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("Welcome to Komodo Cafe");
                Console.WriteLine("Select a Project with a Letter. \n"
                + "a. Add Item \n"
                + "b.Delete Item \n"
                + "c. Look at Items \n"
                + "d.Go back"
                );

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "a":
                        CreatedMenuItem();
                        break;
                    case "b":
                        DeleteMenuItem();
                        break;
                    case "c":
                        ViewMenuItems();
                        break;
                    case "d":
                        isRunning = false;
                        break;
                }
            }
        }
        private void CreatedMenuItem()
        {


            // Get Meal Name
            Console.WriteLine("Whats the name of Item?");
            string MealName = Console.ReadLine();

            // Get Meal Price
            Console.WriteLine("Whats the price of Item?");
            Double MealPrice = double.Parse(Console.ReadLine());

            Meal newMeal = new Meal(MealName, MealPrice);
            _cafeRepo.CreateItem(newMeal);

        }
        private void DeleteMenuItem()
        {
            Console.WriteLine("Write the item number you want to delete");
            int MealNumber = int.Parse(Console.ReadLine());
            _cafeRepo.DeleteItem(MealNumber);

        }
        private void ViewMenuItems()
        {
            Console.Clear();
            Console.WriteLine("Let's view the items on menu.");

            Dictionary<int, Meal> FindItems = _cafeRepo.GetItems();
            foreach(var items in FindItems.Values)
            {
                Console.WriteLine($"{items.MealNumber}|{items.MealName} | {items.MealPrice}");
            }



            Console.ReadLine();
        }


        private void Seed()
        {
            Meal one = new Meal("Chicken Sandwhich", 5.99);
            Meal two = new Meal("Club Sandwhich", 2.99);
            Meal three = new Meal("Pork Sandwhich", 8.99);
            Meal four = new Meal("Beef Sandwhich", 7.99);
            _cafeRepo.CreateItem(one);
            _cafeRepo.CreateItem(two);
            _cafeRepo.CreateItem(three);
            _cafeRepo.CreateItem(four);

        }
    }
}


