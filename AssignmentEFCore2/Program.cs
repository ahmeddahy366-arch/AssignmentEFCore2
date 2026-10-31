namespace AssignmentEFCore2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var db = new AppContext();
            db.Database.EnsureCreated();
            Console.WriteLine("Database created");
        }
    }
}
