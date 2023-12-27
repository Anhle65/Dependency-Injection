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
}