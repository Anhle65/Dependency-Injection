using System;
using System.Runtime.CompilerServices;
namespace DependencyInjection
{
    public class UserInterface
    {
        public void GetData()
        {
            Console.WriteLine("Username: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Password:");
            var password = Console.ReadLine();
            var bussiness = new Bussiness();
            bussiness.SignUp(userName, password);
        }
    }
}