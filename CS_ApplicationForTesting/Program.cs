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

        public static Test AddTest()
        {
            Test t1 = new Test() 
            {
               Id =101, Name="Data Test"
            };
            return t1;
        }
    }


    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
