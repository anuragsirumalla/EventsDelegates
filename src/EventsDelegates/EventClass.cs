using System;

namespace EventsDelegates
{
    public class EventsClass : EventArgs
    {
        public Customer  customer
        {
            get;
            set;
        }
        public Vendor vendor
        {
            get;
            set;
        }
    }
}