/*
We are writing a program for an ATM machine.
Ask the user to enter the 5 digit card number
Ask the user to enter the 4 digit pin
If the user provides the credentials correctly prompt him with the following options
Check balance
Withdraw the amount
Deposit the amount
Quit the program
*/

using System;
using System.ComponentModel.DataAnnotations;



double amount = 0.0;
double balance = 0.0;
int choice = 0;
int pinNumber = 1234;
int cardNumber = 12345;

void Balance()
{
    Console.WriteLine($"YOUR CURRENT BALANCE IS {balance}");
}

void Deposit()
{
    Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT : ");
    amount = Convert.ToDouble(Console.ReadLine());
    balance += amount;
}

void Withdraw()
{
    balance -= amount;
}

void Menu()
{
    Console.WriteLine("WELCOME TO ATM SERVICE");
    Console.WriteLine("1. CHECK BALANCE ");
    Console.WriteLine("2. WITHDRAW CASH ");
    Console.WriteLine("3. DEPOSITE CASH ");
    Console.WriteLine("4. QUIT");
    Console.WriteLine("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
}
    

try
{
    Console.Write("Enter Your Pin Number:  ");
    int pin = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Your 5 digit Card Number:  ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (pin == pinNumber && number == cardNumber)
    {
        while(!choice.Equals(4))
        {
            Menu();

            switch (choice)
            {
                case 1:
                    Balance();
                    break;
                case 2:
                    Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine(" INSUFFICENT BALANCE");
                    }
                    else
                    {   
                        Withdraw();
                        Console.WriteLine(" PLEASE COLLECT CASH");
                        Balance();
                    }
                    break;
                case 3:
                    Deposit();
                    Console.WriteLine($"Your amount {amount} deposited successfully");
                    Balance();
                    break;
                default:
                    Console.WriteLine("THANK U USING ATM");
                    break;
            }
        }
        Console.WriteLine("THANKS FOR USING OUT ATM SERVICE");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Excited the program");
}



