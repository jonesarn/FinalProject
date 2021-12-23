using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    class ProgramUi
    {
        public void run()
        {

            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("Hello Security Admin, What would you like to do?");
                Console.WriteLine("Select a Project with a Letter. \n"
                + "a. Add Badge \n"
                + "b.Edit Badge \n"
                + "c.List All badges \n"
                + "d.Go back"
                );
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "a":
                        CreateBadge();
                        break;

                    case "b":
                        UpdateBadge();
                        break;

                    case "c":
                        ListAllBadges();
                        break;
                }
                
            }
        }
        private void CreateBadge()
        {

            Console.WriteLine("What is the badge number?");
            string BadgeId = Console.ReadLine();
            string answer = Console.ReadLine();
            do { 
                Console.WriteLine("Do you want to add a door?(y/n)");
           
                if (answer == "y")
            {
               
                    Console.WriteLine("List a door that it needs access to: ");
                    string ListOfDoorNames = Console.ReadLine();
                } 
                    
            } while (answer == "n");
        }
        private void UpdateBadge()
        {

        }
        private void ListAllBadges()
        {

        }
    }
}
