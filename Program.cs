using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assessment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            int attempts = 0;

            {
                while (attempts < 3)
                {

                    Console.Write("Input a username: ");
                    username = Console.ReadLine();

                    Console.Write("Input a password: ");
                    password = Console.ReadLine();
                    if (username == "john" && password == "pass123")
                    {
                        var result = (username == "john" && password == "pass123") ? " Login Success" : "Login failed";

                        Console.WriteLine(result);
                    }
                    else if (username != "john" && password == "pass123")
                    {
                        var result1 = (username != "john") ? "Invalid Username" : "Valid Username";

                        Console.WriteLine(result1);
                    }
                    else if (username == "john" && password != "pass123")
                    {
                        var result2 = (password != "pass123") ? "Invalid password" : "Valid password";

                        Console.WriteLine(result2);

                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Login failed");
                    }
                    else
                    {
                        Console.WriteLine("invalid credentials");
                    }
                    attempts++;
                }

                if (attempts == 3)
                {
                    Console.WriteLine("Login failed.");
                }
                Console.ReadKey();

            }
        }
    }
}
