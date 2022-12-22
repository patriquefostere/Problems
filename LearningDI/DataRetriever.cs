namespace Problems.LearningDI
{
    public class DataRetriever
    {
        private readonly IDatabaseConnection _databaseConnection;

        public DataRetriever(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public void RetrieveData()
        {
            _databaseConnection.Connect();
            // Code to retrieve data from the database goes here
        }
    }
}
