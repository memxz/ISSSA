using System;

namespace InterfaceDemo {
    public class Event : OutlookItem, ISync
    {
        public string Title { get; set; }
        public string Postal { get; set; }
        public uint Day { get; set; }
        public uint Month { get; set; }
        public uint Year { get; set; }

        public Event(string title, string postal, uint day, uint month, uint year)
            : base()
        {
            Title = title;
            Postal = postal;
            Day = day;
            Month = month;
            Year = year;
        }

        public string Sync()
        {
            return String.Format("E|{0}|{1}|{2}|{3}|{4}|{5}",
                uuid, Title, Postal, Day, Month, Year);
        }
    }
}

