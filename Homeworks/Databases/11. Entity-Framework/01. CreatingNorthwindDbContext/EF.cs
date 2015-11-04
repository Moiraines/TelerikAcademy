namespace _01.CreatingNorthwindDbContext
{
    using System;
    using System.Linq;

    internal class EF
    {
        private static NorthwindEntities db;

        internal static void Main()
        {


            /*01 Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database*/
            using (db = new NorthwindEntities())
            {
                //var employees = db.Employees.Select(e => e.FirstName).ToList();
                //Console.WriteLine("TASK 1");
                //employees.ForEach(Console.WriteLine);
                //Console.WriteLine();
            }   //

            /* 02. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting 
            customers. Write a testing class. */
            using (db = new NorthwindEntities())
            {
                InsertNewEmployee();
                UpdateEmployee();
                //DeleteEmployee();
                Console.WriteLine();
            }

            /* 03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.*/

            using (db = new NorthwindEntities())
            {
                Console.WriteLine("TASK 3");
                AllCustomersOrderedIn1997AndShippedToCanada();
                Console.WriteLine();
            }

            /* 04. Implement previous by using native SQL query and executing it through the DbContext.*/
            string nativeSQLQuery = @"SELECT c.ContactName AS ContactName
                                        FROM Customers c
                                        JOIN Orders o
                                        ON c.CustomerID = o.CustomerID
                                        WHERE YEAR (o.OrderDate) = 1997
                                        AND o.ShipCountry = 'Canada'";

            using (db = new NorthwindEntities())
            {
                Console.WriteLine("TASK 4");
                var customers = db.Database.SqlQuery<string>(nativeSQLQuery).ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }

            Console.WriteLine();

            /*05. Write a method that finds all the sales by specified region and period(start / end dates).*/
            const string region = "RJ";
            var startDate = new DateTime(1995, 5, 10);
            var endDate = new DateTime(1996, 12, 4);
            Console.WriteLine("TASK 5");
            GiveSalesByRegionAndPeriod(region, startDate, endDate);


            /*07. Try to open two different data contexts and perform concurrent changes on the same records.
                    What will happen at SaveChanges()?
                    How to deal with it?*/

            // Problem solved by only using only one connection or introducing transactions isolation levels
            var firstConection = new NorthwindEntities();
            var secondConection = new NorthwindEntities();

            var customerFromFirstCon = firstConection.Customers.First();
            var customerFromSecondCon = secondConection.Customers.First();

            Console.WriteLine("\nTASK 7");
            Console.WriteLine("Inital Name FisrtCon: {0} - SecondCon {1}", customerFromFirstCon.CompanyName, customerFromSecondCon.CompanyName);

            customerFromFirstCon.CompanyName = "Mercedes";

            // Second name will win.
            customerFromSecondCon.CompanyName = "Jaguar";

            firstConection.SaveChanges();
            secondConection.SaveChanges();

            var result = new NorthwindEntities().Customers.First();
            Console.WriteLine("Name After Change {0}", result.CompanyName);


        }

        private static void GiveSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (db = new NorthwindEntities())
            {
                var sales = db.Orders
                    .Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .ToList();

                foreach (var sale in sales)
                {
                    Console.WriteLine(sale.OrderID + " " + sale.ShipRegion + " " + sale.OrderDate);
                }
            }
        }

        private static void AllCustomersOrderedIn1997AndShippedToCanada()
            {
                var customers = db.Customers
                    .Join(db.Orders,
                        (c => c.CustomerID),
                        (o => o.CustomerID),
                        (c, o) => new
                        {
                            CustomerName = c.ContactName,
                            OrderYear = o.OrderDate.Value.Year,
                            o.ShipCountry
                        })
                    .Where(c => c.OrderYear == 1997 && c.ShipCountry == "Canada")
                    .ToList();
                    

                db.SaveChanges();
                customers.ForEach(Console.WriteLine);
            }

        private static void InsertNewEmployee()
        {
            var newEmployee = new Employee
            {
                EmployeeID = 1111,
                LastName = "Goshov",
                FirstName =  "Pesho",
                City = "Sofia"
            };

            db.Employees.Add(newEmployee);
            db.SaveChanges();
        }

        private static void UpdateEmployee()
        {
            var employee = db.Employees.First();
            employee.Country = "Bulgaria";
            employee.City = "Plovdiv";
            db.SaveChanges();
        }

        private static void DeleteEmployee()
        {
            var employee = db.Employees.Where(e => e.EmployeeID == 1111);
            db.Employees.Remove(employee.First());
            db.SaveChanges();
        }
    }
}
