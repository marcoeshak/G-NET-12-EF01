namespace G_NET_12_EF01
{
    internal class Program
    {

        static void Main()
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                Console.WriteLine("Database Created Successfully!");
            }
        }
    }
}
