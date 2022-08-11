using System;

namespace TaskForUsernamePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            
            Console.WriteLine("Input your username: ");
            string username = Console.ReadLine();
            user._userName = username;

            Console.WriteLine("Input you password: ");
            string password = Console.ReadLine();
            user._userName = password;

            user.showInfo();
            
        }
    }
}
