//Methods
//returnType MethodName(paramType parmName,......){}

//With no return types
/*
using System.Globalization;

Console.Write("Enter the number 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition : {a + b}");
}

Add(num1, num2);
Add(1, 3);

//with return types
int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if(b > largest)
    {
        largest = b;
    }
    if (c > largest)
    {
        largest = c;
    }
    return largest;
}

int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is {largest}");
*/
//String manipulation
//Concatination
string firstName = "meghana";
string lastName = "karayapath";

string fullName = firstName + " " + lastName;

//Length of a string
int length = firstName.Length;
Console.WriteLine($"First name has {length} letters");

//Replace string parts
string newFirstName = firstName.Replace("na", " ");
Console.WriteLine($"New first name is {newFirstName}");

//Split
//spilt
string toSplit = "parvathi, jenu, asif, megu";
string[] names = toSplit.Split(',');
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

//Compare
string nullString = null;
string emptystring = "";
string whiteSpaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("null string is empty or null");
}

if(string.IsNullOrWhiteSpace(whiteSpaceString))
{

}

//int res = firstName.CompareTo(lastName);
if(firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstname and lastname are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}
if (string.Equals(lastName,lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}
/*
//DateTime related functionality
// Empty DateTime
DateTime date = new DateTime();

// Create DateTime from data
DateTime dateOfBirth = new DateTime(1998, 1, 25);
Console.WriteLine($"Date of Birth is {dateOfBirth}:");

//Create DteTime from string
DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");


// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Current time is {now.Ticks}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

// Dateonly
DateOnly dob = DateOnly.FromDateTime(dateOfBirth);

// TimeOnly
TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);


Console.WriteLine(tob);
Console.Write("Enter the number 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotient = num1 / num2;
    Console.WriteLine($"The result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Excited the program");
}

// Arrays
// initialised a fixed size array
int[] marks = new int[5]; // 0 besed index (0-4)

// iterate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks :");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}


//print an array of elements
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
string[] usernames = new string[] { "John", "Jake", "jobe" };


// Lists
List<string> devs = new List<string>();
string dev = string.Empty;
while (!dev.Equals("-1"))
{
    Console.Write("Enter the name of the develepor: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}
foreach (string name in devs)
{
    Console.WriteLine(name);
}

//api documentations
*/