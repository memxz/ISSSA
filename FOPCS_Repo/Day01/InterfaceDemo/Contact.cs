using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo {
    public class Contact : OutlookItem, ISync
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }

        public Contact(string firstName, string lastName, string contactNo)
            : base()
        {
            FirstName = firstName;
            LastName = lastName;
            ContactNo = contactNo;
        }

        public string Sync()
        {
            return String.Format("C|{0}|{1}|{2}|{3}",
                uuid, FirstName, LastName, ContactNo);
        }
    }
}


