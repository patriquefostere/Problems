namespace Problems.LearningDI
{
    public static class DependencyInjectionContainer
    {
        private static IDatabaseConnection _databaseConnection;

        public static void SetDatabaseConnection(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public static IDatabaseConnection GetDatabaseConnection()
        {
            return _databaseConnection;
        }
    }
}

