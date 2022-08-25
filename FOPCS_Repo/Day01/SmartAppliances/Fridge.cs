using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppliances
{
	class Fridge:Appliances
	{
		public bool isOpen;
		public Fridge(string name, string type) : base(name, type) { }

		public override bool ON_Open()
		{
			if (isOpen)
				return base.ON_Open();
			else
				return false;
		}
		public override bool OFF_Close()
		{
			if (isOpen)
				return false;
			else
				return base.OFF_Close();
		}
		
	}
}
