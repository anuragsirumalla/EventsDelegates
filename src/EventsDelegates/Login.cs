using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    public class Login
    {
        public string UserName
        {
            get;
            set;
        }
        private string Password
        {
            set;
            get;
        }
        private bool LoginStatus
        {
            set;
            get;
        }
        public Login()
        {
            LoginStatus = false;
        }

        public bool LoginStatusMethod()
        {
            return LoginStatus;
        }
        void GetLoginCustomerDetails()
        {
            Console.Write("Enter username : ");
            UserName = (Console.ReadLine());
            Console.Write("Enter password : ");
            Password = (Console.ReadLine());
        }
        public Customer GetStatus(ref Customer Customer)
        {
            GetLoginCustomerDetails();
            foreach (var LoginCustomer in Customer.customersList)
            {
                if (LoginCustomer.UserName.Equals(UserName) && LoginCustomer.Pin.Equals(Password))
                {
                    Console.WriteLine($"Login Success");
                    LoginStatus = true;
                    return LoginCustomer;
                }
            }
            return null;
        }
    }

}