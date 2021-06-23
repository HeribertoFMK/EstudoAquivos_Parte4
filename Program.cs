using System;
using System.Globalization;
using exerciciofinaltryecatch.Entities;
using exerciciofinaltryecatch.Entities.Exceptions;




namespace exerciciofinaltryecatch
{
    class Program
    {
        static void Main(string[] args)
        {


           

            Console.WriteLine("Enter account data");
            System.Console.WriteLine();
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());            
            System.Console.Write("Holder: ");
            string holder = Console.ReadLine();            
            System.Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Width Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number,holder,balance,withdrawLimit);
            System.Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try{

           
            account.Withdraw(amount);

            System.Console.WriteLine("new Balance:  " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));

            }
         
            catch(DomainException e){


                System.Console.WriteLine("Saldo Insuficiente para saque" +e.Message);

            }
            

        }
    }
}
