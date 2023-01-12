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



double amount = 0.0;
double balance = 0.0;
int choice = 0;


void Balance()
{
    Console.WriteLine($"YOUR CURRENT BALANCE IS {balance}");
}

void Deposit()
{
    Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT : ");
    amount = Convert.ToDouble(Console.ReadLine());
    balance += amount;
    Console.WriteLine($"YOUR AMOUNT {amount} DEPOSITED SUCCESSFULLY");
}

void Withdraw()
{
    Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW : ");
    amount = Convert.ToDouble(Console.ReadLine());
    balance -= amount;
    if (amount > balance)
    {
        Console.WriteLine(" INSUFFICENT BALANCE");
    }
    else
    {
        Console.WriteLine(" PLEASE COLLECT CASH");
    }
}

void Quit()
{
    Console.WriteLine("THANK U USING ATM");
}

void Menu()
{
    Console.WriteLine("WELCOME TO ATM SERVICE");
    Console.WriteLine("1. CHECK BALANCE ");
    Console.WriteLine("2. DEPOSITE CASH ");
    Console.WriteLine("3. WITHDRAW CASH ");
    Console.WriteLine("4. QUIT");
    Console.WriteLine("ENTER YOUR CHOICE: ");
}
    

try
{
    Console.Write("ENTER YOUR  CARD NUMBER:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("ENTER YOUR PIN NUMBER:  ");
    int pin = Convert.ToInt32(Console.ReadLine());

    if (pin == 1234 && number == 12345)
    {
        while(!choice.Equals(4))
        {
            Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Balance();
                    break;
                case 2:
                    Deposit();
                    Balance();
                    break;
                case 3:
                    Withdraw();
                    Balance();
                    break;
                case 4:
                    Quit();
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("THANKS FOR USING OUT ATM SERVICE");
    }
}
catch (Exception ex)
{
    Console.WriteLine("EXCITED THE PROGRAM");
}



