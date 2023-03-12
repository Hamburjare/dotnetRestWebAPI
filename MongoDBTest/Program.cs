using MongoDB.Driver;
using dotenv.net;

namespace MongoDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Load();
            var mongodbUrl = Environment.GetEnvironmentVariable("MONGODB_URL");

            var client = new MongoClient(mongodbUrl);

            var dbList = client.ListDatabases().ToList();

            Console.WriteLine("Databases:");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

    }
}
