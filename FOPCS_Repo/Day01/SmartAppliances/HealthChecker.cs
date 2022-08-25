using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppliances
{
	class HealthChecker:ICheck
	{
		public bool health(Appliances ap) {
			if (ap.Type == "Lamp") {
				if (ap.Count > 15) { ap.Condition = false; }
				else {ap.Condition = true; }
			}
			if (ap.Type == "Fridge") {
				if (ap.Count > 15) {  ap.Condition = false; }
				else { ap.Condition = true; }
			}

			return ap.Condition;
		}
	}
}
