using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1
            GenieLamp led = new GenieLamp("red");
            while (true)
            {
                Console.WriteLine("\n========================\n");
                Console.WriteLine("1. Turn on the light \n2. Turn off the light. \n3. what is the color of the light \n4. Is the lamp ON? ");
                Console.Write("Pls enter your selection: ");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    led.turnOn();
                }
                else if (input == 2)
                {
                    if (led.isOn)
                    {
                        led.lightOff();
                    }
                    else
                    {
                        led.turnOff();
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine(">>>" + led.Color + "<<<");
                }
                else if (input == 4)
                {
                    Console.WriteLine(">>>" + (led.isLEDOn() ? "ON" : "OFF") + "<<<");
                }
                else
                {
                    Console.WriteLine("Pls enter a valid number");
                }
            }



        }
    }
}
