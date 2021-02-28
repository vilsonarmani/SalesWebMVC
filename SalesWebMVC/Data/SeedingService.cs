using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            //Seller ja tem dados
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;// o banco de dados ja foi populado
            }

            //instanciando e salvando no bd

            Department department1 = new Department(1, "Computers");
            Department department2 = new Department { Id = 2, Name = "Electronics" };
            Department department3 = new Department(3, "Fashion");
            Department department4 = new Department(4, "Books");

            Seller seller1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, department1);
            Seller seller2 = new Seller(2, "Elisa Samúdio", "bob@gmail.com", new DateTime(1998, 4, 21), 1500.0, department1);
            Seller seller3 = new Seller(3, "Bob Dylan", "bob@gmail.com", new DateTime(1978, 4, 21), 3000.0, department1);
            Seller seller4 = new Seller(4, "Carlinhos Brown", "bob@gmail.com", new DateTime(1965, 4, 21), 1400.0, department2);
            Seller seller5 = new Seller(5, "Charlie Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1566.0, department2);
            Seller seller6 = new Seller(6, "Eva &Adão", "bob@gmail.com", new DateTime(1998, 4, 21), 900.0, department3);
            Seller seller7 = new Seller(7, "Mun Ha", "eterno@gmail.com", new DateTime(1985, 4, 21), 850.0, department4);
            Seller seller8 = new Seller(8, "Bob Brown", "bob@gmail.com", new DateTime(1989, 4, 21), 1060.0, department4);
            Seller seller9 = new Seller(9, "Guilherme Dias", "guilhermedias@gmail.com", new DateTime(2000, 4, 21), 1054.0, department4);

            Random rand = new Random();

            SalesRecord salesRecord1 = new SalesRecord(1, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller1);
            SalesRecord salesRecord2 = new SalesRecord(2, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);
            SalesRecord salesRecord3 = new SalesRecord(3, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller8);
            SalesRecord salesRecord4 = new SalesRecord(4, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller5);
            SalesRecord salesRecord5 = new SalesRecord(5, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller6);
            SalesRecord salesRecord6 = new SalesRecord(6, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller4);
            SalesRecord salesRecord7 = new SalesRecord(7, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller9);
            SalesRecord salesRecord8 = new SalesRecord(8, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller8);
            SalesRecord salesRecord9 = new SalesRecord(9, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller7);
            SalesRecord salesRecord10 = new SalesRecord(10, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller5);
            SalesRecord salesRecord11 = new SalesRecord(11, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);
            SalesRecord salesRecord12 = new SalesRecord(12, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller1);
            SalesRecord salesRecord13 = new SalesRecord(13, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller8);
            SalesRecord salesRecord14 = new SalesRecord(14, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller5);
            SalesRecord salesRecord15 = new SalesRecord(15, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller6);
            SalesRecord salesRecord16 = new SalesRecord(16, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller3);
            SalesRecord salesRecord17 = new SalesRecord(17, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller1);
            SalesRecord salesRecord18 = new SalesRecord(18, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller5);
            SalesRecord salesRecord19 = new SalesRecord(19, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);
            SalesRecord salesRecord20 = new SalesRecord(20, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller1);
            SalesRecord salesRecord21 = new SalesRecord(21, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller3);
            SalesRecord salesRecord22 = new SalesRecord(22, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller4);
            SalesRecord salesRecord23 = new SalesRecord(23, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller7);
            SalesRecord salesRecord24 = new SalesRecord(24, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller8);
            SalesRecord salesRecord25 = new SalesRecord(25, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller5);
            SalesRecord salesRecord26 = new SalesRecord(26, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller7);
            SalesRecord salesRecord27 = new SalesRecord(27, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller9);
            SalesRecord salesRecord28 = new SalesRecord(28, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller6);
            SalesRecord salesRecord29 = new SalesRecord(29, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);
            SalesRecord salesRecord30 = new SalesRecord(30, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller4);
            SalesRecord salesRecord31 = new SalesRecord(31, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Pending, seller6);
            SalesRecord salesRecord32 = new SalesRecord(32, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);
            SalesRecord salesRecord33 = new SalesRecord(33, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller1);
            SalesRecord salesRecord34 = new SalesRecord(34, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller3);
            SalesRecord salesRecord35 = new SalesRecord(35, new DateTime(2018, rand.Next(5, 7), rand.Next(1, 28)), (rand.NextDouble() * 2.0) - 1.0, SalesStatus.Billed, seller2);


            _context.Department.AddRange(department1, department2, department3, department4);

            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6, seller7, seller8, seller9);

            _context.SalesRecord.AddRange(
                salesRecord1, salesRecord2, salesRecord3, salesRecord4, salesRecord5, salesRecord6, salesRecord7, salesRecord8, salesRecord9,
                salesRecord10, salesRecord11, salesRecord12, salesRecord13, salesRecord14, salesRecord15, salesRecord16, salesRecord17,
                salesRecord18, salesRecord19, salesRecord20, salesRecord21, salesRecord22, salesRecord23, salesRecord24, salesRecord25,
                salesRecord26, salesRecord27, salesRecord28, salesRecord29, salesRecord30, salesRecord31, salesRecord32, salesRecord33,
                salesRecord34, salesRecord35
             );

            _context.SaveChanges();
        }
    }
}
