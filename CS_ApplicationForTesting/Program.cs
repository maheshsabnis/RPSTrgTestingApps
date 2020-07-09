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

            Banking bank = new Banking(20000);
            EventListener evt = new EventListener(bank);
            bank.Deposit(90000);
            Console.WriteLine($"Banlance after Deposit is {bank.ShowBalance()}");
            bank.Withdrawal(108000);
            Console.WriteLine($"Banlance after Withdrawal is {bank.ShowBalance()}");

            Console.WriteLine("Hello World");
            Console.ReadLine();
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

        public static bool Login(string userName, string password)
        {
            var users = new Users();

            bool isLoginSuccess = false;
            foreach (var user in users)
            {
                if (userName == user.UserName && password == user.Password)
                {
                    isLoginSuccess = true;
                    break;
                }
            }
            
          
            return isLoginSuccess;
        }
    }


    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
