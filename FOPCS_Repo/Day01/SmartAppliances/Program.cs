using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppliances
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rn = new Random();
			int num = rn.Next(1, 30);
			Appliances ap = new Lamp("Lamp_A", "Lamp");

		}
	}
}
