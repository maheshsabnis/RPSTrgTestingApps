using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CS_ApplicationForTesting
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Users : List<User>
    {
        public Users()
        {
            Add(new User() {UserName = "Mahesh", Password="P@ssw0rd_" });
            Add(new User() { UserName = "Tejas", Password = "P@ssw0rd_" });
            Add(new User() { UserName = "Amit", Password = "Pass@123" });
            Add(new User() { UserName = "Mahesh", Password = "Pass@123" });

        }
    }
}
