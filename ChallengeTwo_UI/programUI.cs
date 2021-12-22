using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2_Poco;
using ChallengeTwo_Repo;

namespace ChallengeTwo_UI
{
    class programUI
    {

        private  ClaimRepo _AllClaims = new ClaimRepo();
        public void run()
        {
            
            menu();
        }
        public void menu()
        {
            bool isRunning = true;
            while(isRunning == true)
            {
                Console.WriteLine("Welcome to the Komodo Claim Insurance App");
                Console.WriteLine("Select a Project with a Letter. \n"
               + "a. See Claims \n"
               + "b. Take care of next claim \n"
               + "c. Enter a new claim \n"
               + "d.Go back"
               );
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "a":
                        seeClaims();
                        break;
                    case "b":
                        //call repo
                        takeCareOfClaim();
                        break;
                    case "c":
                        makeClaim();
                        break;

                }
            }         
        }
        private void seeClaims()
        {
            Console.Clear();
            Console.WriteLine("Let's view all Insurance Claims");

            Queue< ClaimPoco> FindClaim = _AllClaims.ReadAllClaim();
            foreach (ClaimPoco items in FindClaim)
            {
                Console.WriteLine($"Insurance Id: {items.ClaimId}| Claim Type: {items.ClaimType} | Description: {items.ClaimDescription} | Claim Amount: {items.ClaimAmount}|DDI: {items.DateOfIncindent}|DOC: {items.DateOfClaim}|Valid?: {items.IsValid} ");
                
             }
           
            }


        private void takeCareOfClaim()
        {
            // delete claim
            Console.Clear();
            Console.WriteLine("Do you want to see the next claim?(y/n)");
            string answer = Console.ReadLine();
            if(answer == "y"| answer == "Y")
            {
               
                
            }
           
        }
        private void makeClaim()
        {
            Console.Clear();
            Console.WriteLine("Whats the type of Claim is it?\n" +
                " 1.Car, 2.House, 3.Theft ");
            string claimType = Console.ReadLine();
            if (claimType == "1")
            {
                Console.WriteLine("Car");
               
            }
            else if (claimType == "2")
              
            {
                Console.WriteLine("House");
                
            }
            else if (claimType == "3")
            {
                Console.WriteLine("Theft");
            }
            else
            {
                Console.WriteLine("Need Answer try again");
                

            }

            Console.WriteLine("Whats the Description?");
            string claimdescription = Console.ReadLine();

            Console.WriteLine("Whats the Amount?");
            double claimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a date of incident  Ex. 1/1/2022: ");
            DateTime dateOfIncindent = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter a date of incident  Ex. 1/1/2022: ");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());

           
            

            ClaimPoco newClaim = new ClaimPoco(claimType, claimdescription, claimAmount, dateOfIncindent, dateOfClaim);
            _AllClaims.CreateClaim(newClaim);
        }
        
        }

    }
    
       
    

