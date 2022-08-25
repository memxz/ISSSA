using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating contacts
            Contact c1 = new Contact("John", "Lee", "90010002");
            Contact c2 = new Contact("Sally", "Wong", "90310018");
            Contact c3 = new Contact("James", "Chong", "90310018");

            // creating events
            Event e1 = new Event("House Warming", "787112", 7, 9, 2022);
            Event e2 = new Event("Badminton Game", "401288", 8, 10, 2022);

            // every item in the arr can be sync-ed
            ISync[] arr = new ISync[] {
    c1, c2, c3, e1, e2
};

            // sync each item in arr
            foreach (ISync item in arr)
            {
                string sync = item.Sync();
                Console.WriteLine(sync);
            }
            Console.Read();
        }

    }
}

