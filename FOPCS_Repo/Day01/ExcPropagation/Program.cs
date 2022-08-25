//#define section1
#define section2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcPropagation
{
	class Program
	{
        public static void Main()
        {
            #region section1
#if section1
            Console.WriteLine("Enter Main.");
            ExcPropagation mc = new ExcPropagation();
            try
            {
                mc.M1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter catch block of Main.");
                Console.WriteLine("Exception from: {0}",
                           e.TargetSite);
                Console.WriteLine("Exit catch block of Main.");
            }
            Console.WriteLine("Exit Main.");
#endif
#endregion

			#region section2
            #if section2
            Console.WriteLine("Enter Main.");
            ExcPropagation mc = new ExcPropagation();
              try
              {
                 mc.M1();
              }
              catch (Exception e)
              {
                 Console.WriteLine("Enter catch block of Main.");
                 Console.WriteLine("Exception from: {0}",
            		        e.TargetSite);
                 Console.WriteLine("Exit catch block of Main.");
              }
              Console.WriteLine("Exit Main.");

            #endif
			#endregion
		}

	}
}
