using MongoDB.Driver;

namespace Singleton
{
    public sealed class MongoDB
    {
        private static MongoDB instance;

        const string connectionString = "mongodb://localhost";
        private static MongoDatabase db;

        private MongoDB()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("");
            var server = client.GetServer();
            server.Connect();
            client.StartSession();
            db = server.GetDatabase("SchoolDB");
        }

        public static MongoDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new MongoDB();
            }

            return db;
        }
    }
}
