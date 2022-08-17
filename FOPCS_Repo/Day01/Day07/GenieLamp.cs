using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class GenieLamp
    {
        public bool isOn;
        private string color;
        public string Color { get => color; set => color = value; }
        public GenieLamp(string color)
        {
            isOn = false;
            this.color = color;
        }
        public bool isLEDOn()
        {
            return isOn;
        }
        public void turnOn()
        {
            if (!isLEDOn())
            {
                isOn = true;
            }
        }
        public void turnOff()
        {
            if (isLEDOn())
            {
                isOn = false;
            }
        }
        public void lightOff()
        {
            turnOff();
            if (this.Color == "red")
            {
                this.Color = "green";
            }
            else if (this.Color == "green")
            {
               this.Color = "blue";
            }
            else if (this.Color == "blue")
            {
                this.Color = "red";
            }
        }
    }
}
