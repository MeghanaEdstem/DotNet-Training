// Conditional
// if else (==, >, <, >=, <=, !=)
Console.Write("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("There are more apples than oranges");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("There are more oranges than apples");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("apples and oranges are equals");
}
else
{
    Console.WriteLine("Invalid");
}


//switch
Console.Write("Enter your mark: ");
int marks = Convert.ToInt32(Console.ReadLine());
switch (marks)
{
    case int n when (n < 50):
        Console.WriteLine("You are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("You are passed");
        break;
    default:
        Console.WriteLine("Invalid input for mark");
        break;
}

/*
switch(marks)
{
    case 10:
        Console.WriteLine("You are failed");
        break;
    case 60:
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Invalid input for mark");
        break;
}
*/


//ternary - <condition> ? true action : false action
var message = numberOfApples > numberOfOranges ? "we have more apples" : "we have less apples";
Console.WriteLine(message);
