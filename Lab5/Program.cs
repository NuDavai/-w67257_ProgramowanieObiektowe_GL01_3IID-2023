using Lab5.Bank;
using Lab5.Shapes;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
        }

        static void Zad1()
        {
            Shape shape = new Circle(5);

            shape = new Square() { X = 2 };

            Console.WriteLine(shape.CalulateArea());
        }

        private static void Zad2()
        {
            var account = new Account();

            account.Add(new IncomeTransaction() { Amount = 400 });
            account.Add(new IncomeTransaction() { Amount = 500 });
            account.Add(new IncomeTransaction() { Amount = 600 });
            account.Add(new ExpenseTransaction() { Amount = 600 });
            account.Add(new ExpenseTransaction() { Amount = 400 });
            account.Add(new ExpenseTransaction() { Amount = 200 });

            account.DisplaySummary();
        }
    }
}
