using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    class Orders
    {
        public List<String> ordersList;
        public Orders()
        {
            ordersList = new List<string>();
        }
        public void SetOrders()
        {
            String status = "yes";
            while (status.Equals("yes"))
            {
                Console.WriteLine("\n             Place your Order \n");
                Console.WriteLine("1.General Store   2.Medical Store   3.Electronics   4.Exit");
                Console.Write("Please, enter your choice :  ");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ordersList.Add("General Store");
                        break;
                    case 2:
                        ordersList.Add("Medical Store");
                        break;
                    case 3:
                        ordersList.Add("Electronics");
                        break;
                    case 4:
                        status = "no";
                        break;
                    default: break;
                }
            }
        }

    }
}