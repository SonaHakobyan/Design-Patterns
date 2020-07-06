namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = MongoDB.GetInstance();
        }
    }
}



