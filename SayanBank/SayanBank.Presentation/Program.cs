using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayanBank.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //display title
            Console.WriteLine("******************Sayan Bank*******************");
            Console.WriteLine("::Login Page::");

            //declare variables to store username and password
            string userName = null, password = null;

            //read userName from keyboard
            Console.Write("Username: ");
            userName = Console.ReadLine();

            //read password from keyboard only if username is entered
            if (userName != "")
            {
                
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            //check username and password
            if(userName == "system" && password == "manager")
            {
                //declare variable to store menu choice
                int mainMenuChoice = -1;

                do
                {

                    Console.WriteLine("\n:::Main menu:::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());


                    //switch-case to check menu choice
                    switch (mainMenuChoice)
                    {
                        case 1:
                            CustomersMenu();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;

                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid user or password!");
            }
            //about to exit
            Console.WriteLine("Thank you!Visit again.");
            Console.ReadKey();
        }

        static void CustomersMenu()
        {
            //variable to store customers menu choice
            int customerMenuChoice = 1;

            //do-while loop starts
            do
            {
                //print customers menu
                Console.WriteLine("\n:::Customers menu:::");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer");
                Console.WriteLine("3.Update Customer");
                Console.WriteLine("4.View Customer");
                Console.WriteLine("0.Back to Main Menu");

                //accept customers menu choice
                Console.Write("Enter choice: ");
                customerMenuChoice = Convert.ToInt32(Console.ReadLine());

            } while (customerMenuChoice != 0);
        }
    }
}
