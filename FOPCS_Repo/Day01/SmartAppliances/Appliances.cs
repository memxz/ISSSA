using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppliances
{
	class Appliances
	{
		private string name;
		private string type;
		private int count;
		private bool condition;

		public Appliances(string name, string type)
		{
			this.name = name;
			this.type = type;
		}

		public string Name { get => name; set => name = value; }
		public string Type { get => type; set => type = value; }
		public int Count { get => count; set => count = value; }
		public bool Condition { get => condition; set => condition = value; }

		public virtual bool ON_Open() {
			return true;
		}
		public virtual bool OFF_Close() {
			return true;
		}
		public void initial() {
			this.Count = 0;
			this.Condition = true;
		}
		public override string ToString()
		{
			return string.Format("Name: {0}\tType: {1}\tCount: {2}\tStatus:{3}", this.Name, this.Type, this.Count,this.Condition?"Normal":"Unnormal");
		}
	}
}
