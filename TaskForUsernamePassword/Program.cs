using System;

namespace TaskForUsernamePassword
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Input your username: ");
            string username = Console.ReadLine();


            Console.WriteLine("Input you password: ");
            string password = Console.ReadLine();

            User user = new User(username,password);

            
        }
    }
}
