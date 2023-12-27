namespace DependencyInjection
{
    public class Bussiness : IBussiness
    {
        public void SignUp(string userName, string password)
        {
            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }

    }
}