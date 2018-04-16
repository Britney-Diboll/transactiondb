using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tranactionsDB.DataContext;
using System.Data.Entity;

namespace tranactionsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Data();

            //insert new item into table

            /*
            var t1 = new Transactions
            {
                TimeStamp = DateTime.Now,
                Action = "Deposit",
                AccountNumber = "1234",
                AmountChanged = 100.00m,
                NewAmount = 150.00m
            };
            dbContext.Transactions.Add(t1);

            var t2 = new Transactions
            {
                TimeStamp = DateTime.Now,
                Action = "Transfer",
                AccountNumber = "1234",
                AmountChanged = 10.00m,
                NewAmount = 140.00m
            };
            dbContext.Transactions.Add(t2);

            var t3 = new Transactions
            {
                TimeStamp = DateTime.Now,
                Action = "Deposit",
                AccountNumber = "666",
                AmountChanged = 1000.00m,
                NewAmount = 2000.00m
            };
            dbContext.Transactions.Add(t3);

            var t4 = new Transactions
            {
                TimeStamp = DateTime.Now,
                Action = "Withdrawl",
                AccountNumber = "666",
                AmountChanged = 100.00m,
                NewAmount = 1900.00m
            };
            dbContext.Transactions.Add(t4);

            var t5 = new Transactions
            {
                TimeStamp = DateTime.Now,
                Action = "Transfer",
                AccountNumber = "666",
                AmountChanged = 100.00m,
                NewAmount = 50.00m
            };
            dbContext.Transactions.Add(t5);
            */
            dbContext.SaveChanges();

            //find all tranactions from today

            var show = dbContext.Transactions.Where(w => w.TimeStamp >= DateTime.Today);
            Console.WriteLine("The transactions from today are listed below:");
            foreach(var thing in show)
            {
                Console.WriteLine(thing.TimeStamp);
            }
            //find 10 most recent tranactions

            var top10 = dbContext.Transactions.OrderByDescending(o => o.ID).Take(10);
            Console.WriteLine("10 (or total) Most recent transactions:");
            foreach(var number in top10)
            {
                Console.WriteLine(number.ID.ToString() + " " + number.Action + " " + number.AccountNumber + " " + number.AmountChanged + " " + number.NewAmount + " " + number.TimeStamp.ToString());
                
            }

            //count all tranactions for a user and day
            var count = dbContext.Transactions.Where(w => w.TimeStamp == DateTime.Today).GroupBy(g => g.AccountNumber);
            foreach(var account in count)
            {
                Console.WriteLine(account.ToString());
            }

            Console.ReadLine();

        }
    }
}
