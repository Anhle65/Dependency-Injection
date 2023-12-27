using System.Security.Cryptography.X509Certificates;

namespace DependencyInjection
{
    public class Bussiness : IBussiness
    {
        private readonly IDataAccess _dataAccess;
        public Bussiness(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SignUp(string userName, string password)
        {
            _dataAccess.Store(userName, password);
        }

    }
    public class BusinessV2 : IBussiness
    {
        private readonly IDataAccess _dataAccess;
        public BusinessV2(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void SignUp(string username, string password)
        {
            _dataAccess.Store(username, password);
            Console.WriteLine("This is BusinessV2");
        }
    }
}