//Task 2
//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
namespace BankAccounts
{
    using System;
    class BankAccountsMain
    {
        static void Main()
        {
            //most boring part of the code :)))

            Individual niki = new Individual("Nokolay Kostov", 020456432, "Sofia, ul. Gyueshevo", "8243567823");
            Company telerik = new Company("Telerik", 010454378, "Sofia, Mladost", "845234087");

            Loan loanAcc = new Loan(1500M, 4.5M, niki);
            Deposit depositAcc = new Deposit(160000, 10000, telerik);

            loanAcc.DepositTrans(100);
            Console.WriteLine(loanAcc.Balance);

            depositAcc.WithdrawTrans(5000);
            Console.WriteLine(depositAcc.Balance);

            Console.WriteLine(depositAcc.Interest(12));
        }
    }
}
