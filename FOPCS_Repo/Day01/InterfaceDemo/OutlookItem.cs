using System;

namespace InterfaceDemo {
    public class OutlookItem
    {
        protected string uuid;

        public OutlookItem()
        {
            uuid = Guid.NewGuid().ToString();
        }
    }
}


