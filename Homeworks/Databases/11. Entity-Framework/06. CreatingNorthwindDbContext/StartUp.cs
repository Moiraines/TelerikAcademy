namespace _06.CreatingNorthwindDbContext
{
    using System ;
    using _01.CreatingNorthwindDbContext;

    public class StartUp
    {
        static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                /*06. Write a method that finds all the sales by specified region and period(start / end dates).*/
                var result = db.Database.CreateIfNotExists();

                if (result)
                {
                    Console.WriteLine("Database NorthWindTwin is created!");
                }
                else
                {
                    Console.WriteLine("This Database is already exist!");
                }

            }
        }
    }
}
