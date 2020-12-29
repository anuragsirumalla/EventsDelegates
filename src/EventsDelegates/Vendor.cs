using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    public class Vendor
    {
        public Dictionary<String, Vendor> vendorsDictonary;
        public string Name
        {
            set;
            get;
        }
        public Vendor()
        {
            vendorsDictonary = new Dictionary<String, Vendor>()
            {
                {"General Store", new Vendor("InnMart General Store")},
                {"Medical Store",new Vendor("InnMart Medical Store")},
                {"Electronics",new Vendor("InnRoad Electronics")}
            };
        }
        public Vendor(string Name)
        {
            this.Name = Name;
        }
        public void Notify(object obj, EventsClass args)
        {
            Console.WriteLine("\n\n                 VENDOR DETAILS\n");
            Console.WriteLine("Vendor Name  :   {0}",args.vendor.Name);
            Console.WriteLine("Place order to shipping address   :  {0}",args.customer.Address);
            Console.WriteLine("Order Placed Time  :   {0}",DateTime.Now);
            Console.WriteLine("_____________________________________________________________________________");
        }
    }
}