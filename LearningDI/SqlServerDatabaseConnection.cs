namespace Problems.LearningDI
{
    public interface IDatabaseConnection
    {
        void Connect();
    }

    public class SqlServerDatabaseConnection : IDatabaseConnection
    {
        public void Connect()
        {
            // Code to connect to a SQL Server database goes here
            Console.WriteLine("test");
        }
    }
}
