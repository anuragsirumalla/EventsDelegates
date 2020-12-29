using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\n*********************\nWelcome to InnMart");
            Console.WriteLine("*********************");
            String entrace = "yes";
            Customer Customers = new Customer();
            while (entrace.Equals("yes"))
            {
                Console.WriteLine("\n\n1. Are you a New Customer? please, Sign Up.       2. Sign in.         3. Exit.");
                Console.Write("Please, Enter your choice : ");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Customers.setCustomerDetails();
                        break;
                    case 2:
                        Login login = new Login();
                        Customer LoginCustomer = new Customer();
                        LoginCustomer = login.GetStatus(ref Customers);
                        if (object.ReferenceEquals(LoginCustomer, null))
                        {
                            Console.WriteLine("Sorry you are not registered, please Sign-Up ");
                        }
                        else
                        {
                            EventOperations eventOperations = new EventOperations(ref LoginCustomer);
                            eventOperations.Operations();
                            Console.WriteLine("you are Logged out");
                            Console.WriteLine("To run application, please type 'yes'  ");
                            entrace = (Console.ReadLine());
                        }
                        break;
                    case 3:
                        entrace = "no";
                        Console.WriteLine("Application Stopped ");
                        break;
                    default: break;
                }

            }

        }
    }
}

