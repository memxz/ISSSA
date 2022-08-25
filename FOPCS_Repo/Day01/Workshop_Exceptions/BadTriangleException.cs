using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Exceptions
{
	class BadTriangleException:Exception
	{
		public BadTriangleException(string message) : base(message)
		{
		}
	}
}
