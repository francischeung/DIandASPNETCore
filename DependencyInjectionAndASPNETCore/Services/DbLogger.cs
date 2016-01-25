namespace DependencyInjectionAndASPNETCore.Services
{
    public class DbSimpleLogger : ISimpleLogger
    {
        private readonly string _dataBaseConnectionString;

        public DbSimpleLogger(string dataBaseConnectionString)
        {
            _dataBaseConnectionString = dataBaseConnectionString;
        }

        public void Log(string message)
        {
        }
    }
}
