using System;
using Microsoft.Extensions.DependencyInjection;
namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<IDataAccess, DataAccess>();
            services.AddScoped<IBussiness, BusinessV2>();
            var provider = services.BuildServiceProvider();

            IDataAccess dataAccess = provider.GetService<IDataAccess>();

            //IBussiness bussiness = new Bussiness(dataAccess);

            //Access to BusinessV2
            IBussiness bussinessV2 = provider.GetService<IBussiness>();
            var userInterface = new UserInterface(bussinessV2);
        }
    }
}