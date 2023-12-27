using System;
using System.Runtime.CompilerServices;
namespace DependencyInjection
{
    public class UserInterface
    {
        private readonly IBussiness _bussiness;
        public UserInterface(IBussiness bussiness)
        {
            _bussiness = bussiness;
        }
        public void GetData()
        {
            Console.WriteLine("Username: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Password:");
            var password = Console.ReadLine();
            _bussiness.SignUp(userName, password);
        }
    }
}