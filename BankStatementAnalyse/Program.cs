﻿var statement = new Statements();


try
{
    statement.BankStatement();
    statement.PrintBankTransactions();
    Console.WriteLine($"NET BALANCE OF YOUR ACCOUNT IS : {statement.BankBalance()}");

    Console.WriteLine("ENTER THE MONTH : ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"NET BALANCE OF THE MONTH IS : {statement.NetBalance(month)}");
}
catch (Exception ex)
{
    Console.WriteLine("INVALID DATA");
}
