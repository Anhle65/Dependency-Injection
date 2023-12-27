namespace DependencyInjection
{
    public interface IDataAccess
    {
        void Store(string userName, string password);
    }
}