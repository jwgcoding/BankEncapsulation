// See https://aka.ms/new-console-template for more information
//name it BankEncapsulation
//Create a new public class named BankAccount
//In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//Once finished save, commit, and push back to Github

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using BankEncapsulation;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("What is the amount you are depositing?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            Console.WriteLine($"The amount you are deposting is {amountToDeposit}.");
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your new balance is now {account.GetBalance()}");

            Console.WriteLine("Enter an amount to withdraw?");
            

            var amountToWithdraw = double.Parse(Console.ReadLine());
            Console.WriteLine($"The amount you are withdrawing is {amountToWithdraw}.");
            account.Withdraw(amountToWithdraw);
            Console.WriteLine($"Thank you! Your new balance is now {account.GetBalance()}");





        }


    }

}