//Create a game called "Fortune"
//The player will be given 5 turns to guess a number x (0 - 100)
//After each attempt your program will do the following.
//If player's entered number is less than  x print "Guessed number is less than x" and show remaining turns
//If player's entered number is greater than  x print "Guessed number is greater than x" and show remaining turns
//If no more turns are available print "You lost" and exit
//If guessed correctly print "You win" and exit 


//int turns = 5;
//int number = 0;
//Random rnd = new Random();
//int rand_num = rnd.Next(0, 100);
//Console.WriteLine($"You have {turns} chances here");
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Please enter a number: ");
//    number = Convert.ToInt32(Console.ReadLine());
//    if (number < rand_num)
//    {
//        Console.WriteLine($"Guessed number is less than number x");
//    }
//    else if (number > rand_num)
//    {
//        Console.WriteLine($"Guessed number is greater than number x");
//    }
//    else if (rand_num == number)
//    {
//        Console.WriteLine($"You win");
//    }
//    turns--;
//    Console.WriteLine($"Remaining turns {turns}");
//    if (turns == 0)
//    {
//        Console.WriteLine($"You lost");
//    }
//}
//Console.WriteLine();
//Console.WriteLine("For loop exited");


//or
//int num = 0;

//Random rnd = new Random();
//int x = rnd.Next(0, 100);

//Console.WriteLine("You have 5 chances her");

//for (int i = 4; i >= 0; i--)
//{
//    Console.Write("Please enter a number: ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (i > 0)
//    {
//        if (num > x)
//        {
//            Console.WriteLine("Guessed number is greater than number x");
//        }
//        else if (num < x)
//        {
//            Console.WriteLine("Guessed number is less than number x");
//        }
//        else
//        {
//            Console.WriteLine($"You win");
//            break;
//        }
//    }
//    else
//    {
//        Console.WriteLine($"You lost");
//    }
//    Console.WriteLine($"Remaining chances : {i}");
//}

//Console.WriteLine();
//Console.WriteLine("For loop exited");

//or 
int n = 0;
Random rnd = new Random();
int x = rnd.Next(0, 100);

Console.WriteLine(" YOU HAVE 5 TURNS TO GUESS THE NUMBER x WHERE 0 < x < 100 ");

for (int i = 0; i <= 4; i++)
{
    Console.Write("ENTER YOUT NUMBER  : ");
    n = Convert.ToInt32(Console.ReadLine());

    if (i >= 4)
    {
        Console.WriteLine("YOU LOST !!!!!"); 
    }
    else
    {
        if (n < x)
        {
            Console.WriteLine("GUESSED NUMBER IS LESS THAN x ");
        }
        else if (n > x)
        {
            Console.WriteLine("GUESSED NUMBER IS GREATER THAN x ");
        }
        else
        {
            Console.WriteLine("YOU WIN !!!!!");
        }
    }
    Console.WriteLine($"REMAINING CHANCES = {4 - i}");
}
Console.WriteLine();
Console.WriteLine("FOR LOOP EXITED");