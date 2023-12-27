namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = new DataAccess();
            IBussiness bussiness = new Bussiness(dataAccess);
            var userInterface = new UserInterface(bussiness);
        }
    }
}