using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppliances
{
	class Lamp:Appliances
	{
		bool isOn;
		public Lamp(string name, string type) : base(name,type) { }

		public override bool ON_Open()
		{
			if (!isOn) {
				this.Count++;
				return base.ON_Open();
			}
				
			else
				return false;
		}
		public override bool OFF_Close()
		{
			if (!isOn)
				return false;
			else
				return base.OFF_Close();
		}

	}
}
