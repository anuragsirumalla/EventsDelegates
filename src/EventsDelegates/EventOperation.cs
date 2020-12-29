using System;
using System.Collections.Generic;

namespace EventsDelegates
{
    class EventOperations
    {
        Customer customer;
        Vendor vendor;
        Orders orders;
        Notification notify = new Notification();
        public EventOperations(ref Customer customer)
        {
            this.customer = customer;
            vendor = new Vendor();
            orders = new Orders();

        }
        public void Operations()
        {
            notify.OrderEvent += customer.Notify;
            notify.OrderEvent += vendor.Notify;
            char finalStatus = 'y';
            while (finalStatus == 'y')
            {
                orders.SetOrders();
                List<string> ordersList = orders.ordersList;
                Vendor orderToVendor;
                foreach (string orderType in ordersList)
                {
                    foreach (string productType in vendor.vendorsDictonary.Keys)
                    {
                        if (orderType.Trim().Equals(productType.Trim()))
                        {
                            orderToVendor = vendor.vendorsDictonary[orderType.Trim()];
                            notify.OrderProduct(customer, orderToVendor);
                        }
                    }
                }
                Console.WriteLine("\nplace orders, y/n");
                finalStatus = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}