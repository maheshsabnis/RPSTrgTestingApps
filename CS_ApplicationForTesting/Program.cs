using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ApplicationForTesting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
        }

        public static bool CheckValue(int x)
        {
            if (x < 0) return false;
            return true;
        }
    }
}
