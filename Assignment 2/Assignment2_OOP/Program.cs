using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    class Program
    { 
        static void Main(string[] args)
        {
            Guest g = new Guest("Guest");

            Editor e = new Editor("Editor","rotide");

            Admin a = new Admin("Admin", "Adminnimda", "123Admin456");

            Environment.users.Add("Guest", g);
            Environment.users.Add("Editor", e);
            Environment.users.Add("Admin", a);

            while (true)
            {
                User user = Authorizator.Authorization();
                if (user == null)
                {
                    continue;
                }

                while (true)
                {
                    Console.Write(user.UserName + " > ");
                    String input = Console.ReadLine();

                    if (input == Environment.Commands.Exit)
                    {
                        Authorizator.Logout(user);

                        break;
                    }

                    if (input.StartsWith(Environment.Commands.Print + " "))
                    {
                        Console.WriteLine(input.Substring(Environment.Commands.Print.Length + 1));
                    }
                    else
                    {
                        Console.WriteLine("Unknown command.");
                    }
                }
            }

        }
    }
}
