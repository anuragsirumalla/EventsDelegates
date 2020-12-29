using System;
namespace EventsDelegates
{
    class Notification
    {
        public EventHandler<EventsClass> OrderEvent;
        public Customer customer
        {
            get;
            set;
        }
        public Vendor vendor
        {
            get;
            set;
        }
        public void OrderProduct(Customer customer,Vendor vendor)
        {
            OnOrderProduct(customer,vendor);
        }

        private void OnOrderProduct(Customer customer, Vendor vendor)
        {
            if(OrderEvent!=null)
            {
                this.OrderEvent(this, new EventsClass()
                {
                    vendor = vendor,
                    customer = customer
                });
            }
        }
    }
}