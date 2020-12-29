using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    public class Customer
    {
        public string Pin
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public Customer()
        {
            customersList = new List<Customer>();
        }
        public Customer(String UserName,string pin,string Address)
        {
            this.UserName = UserName;
            this.Pin = pin;
            this.Address = Address;
        }
        public void setCustomerDetails()
        {
            Console.Write("Hello! Please your Details");
            Console.Write("\nEnter your name : ");
            UserName = Console.ReadLine();
            Console.Write("password : ");
            Pin = (Console.ReadLine());
            Console.Write("Address  : ");
            Address = Console.ReadLine();
            customersList.Add(new Customer(UserName,Pin, Address));
            Console.WriteLine("Your Details Succesfully added ");
        }
        public void ShowCustomer()
        {
            foreach (var customer in customersList)
            {
                Console.WriteLine(customer.UserName + "    " + customer.Address);
            }
        }
        public List<Customer> customersList = new List<Customer>();
        public void Notify(object obj, EventsClass args)
        {
            Console.WriteLine("\n\n                 CUSTOMER DETAILS\n");
            Console.WriteLine("Hey! {0}",args.customer.UserName);
            Console.WriteLine("Order placed Time  :  {0}",DateTime.Now);
            Console.WriteLine("Shipping Address   :  {0}",args.customer.Address);
            Console.WriteLine("Shipping Date      :  {0}",DateTime.Now.Date.AddDays(3).Date.ToString("MM/dd/yyyy"));
        }
    }
}