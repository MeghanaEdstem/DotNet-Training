/*
 * Create a game called "Fortune"
The player will be given 5 turns to guess a number x (0 - 100)
After each attempt your program will do the following.
If player's entered number is less than  x print "Guessed number is less than x" and show remaining turns
If player's entered number is greater than  x print "Guessed number is greater than x" and show remaining turns
If no more turns are available print "You lost" and exit
If guessed correctly print "You win" and exit 
*/


int turns = 5;
int number = 0;
Random rnd = new Random();
int rand_num = rnd.Next(0, 100);
Console.WriteLine($"You have {turns} chances here");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please enter a number: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < rand_num)
    {
        Console.WriteLine($"Guessed number is less than number x");
    }
    else if (number > rand_num)
    {
        Console.WriteLine($"Guessed number is greater than number x");
    }
    else if (rand_num == number)
    {
        Console.WriteLine($"You win");
    }
    turns--;
    Console.WriteLine($"Remaining turns {turns}");
    if (turns == 0)
    {
        Console.WriteLine($"You lost");
    }
}
Console.WriteLine();
Console.WriteLine("For loop exited");