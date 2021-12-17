using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.REPO;

namespace FinalProject.UI
{
    class programUI
    {
        public void run()
        {
            menu();
        }
        public void menu()
        {
            Console.WriteLine("Welcome to my Final Project!");
             Console.WriteLine("Select a Project with a humber. \n"
                    + "1. Cafe \n"
                    + "2.Claims\n"
                    + "3.Badge \n"
                    + "4.Company Outing \n"
                    + "5.Greeting\n"
                    + "6.Green Plan \n"
                    + "7.BBQ\n "
                    + "8.Smart Insurance\n"
                    + "10. End program"
                    );
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Welcome to Komodo Cafe");
                    Console.WriteLine("Select a Project with a Letter. \n"
                    + "a. Add Item \n"
                    + "b.Delete Item \n"
                    + "c. Look at Items \n"
                    );
                    
                    switch (answer)
                    {
                        case "a":
                            Console.Clear();
                            CreatedMenuItem();
                            break;
                        case "b":
                            Console.Clear();
                            DeleteMenuItem();
                            break;
                        case "c":
                            Console.Clear();
                            ViewMenuItems();
                            break;
                    }
                    break;
            }
        }
        void CreatedMenuItem()
        {
            Console.WriteLine("Let's create an item on menu.");
            Console.Clear();

        }
        void DeleteMenuItem()
        {
            Console.WriteLine("Let's Delete an item off the menu.");
            Console.Clear();
        }
        void ViewMenuItems()
        {
            Console.WriteLine("Let's view the items on menu.");
            Console.Clear();
            Console.WriteLine(GetItems());
        }
    }
}
