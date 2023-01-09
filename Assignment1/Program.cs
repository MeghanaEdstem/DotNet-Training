//Ask the user to enter two numbers and print their sum and product on screen


Console.Write("Enter the first number : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the second number : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Addition : {firstNumber + secondNumber}");
Console.WriteLine($"Multiplication : {firstNumber * secondNumber}");
