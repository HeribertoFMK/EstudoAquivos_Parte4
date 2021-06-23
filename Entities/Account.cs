using exerciciofinaltryecatch.Entities.Exceptions;
using System;

namespace exerciciofinaltryecatch.Entities

{
    public class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public Double Balance { get; set; }
        public Double WithdrawLimit { get; set; }
        public Account(int number, string holder, Double balance, Double withdrawLimit)
        {

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;

        }

        public void Deposit(double amount)
        {



            Balance += amount;

        }

        public void Withdraw(double amount)
        {

            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");



            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");



            }

            Balance -= amount;







        }

    }
}
