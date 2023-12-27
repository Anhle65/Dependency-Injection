using System;
using Microsoft.Extensions.DependencyInjection;
namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = new DataAccess();
            IBussiness bussiness = new Bussiness(dataAccess);

            //Access to BusinessV2
            IBussiness bussinessV2 = new BusinessV2(dataAccess);
            var userInterface = new UserInterface(bussinessV2);
        }
    }
}