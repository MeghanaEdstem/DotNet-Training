string firstName = string.Empty;
string lastName = string.Empty;
string middleName = string.Empty;
int age = 0;
double salary = 0.0;


Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your middle name: ");
middleName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

//instance of a perticular class named Person

Person person = new Person(); //mutable
person.FirstName = firstName;
person.LastName = lastName;
person.Age = age;
person.SetSalary(salary);

//or

Person person = new Person()
{
    FirstName = firstName,
    LastName = lastName,
    Age = age
};

//or

Person person = new Person(firstName, lastName, age, salary);  // for immutable objects

Console.WriteLine($"The name entered is {person.FirstName + " " + person.LastName}"); //accessed a property
//or
Console.WriteLine($"The name entered is {person.GetFullName()}");
Console.WriteLine($"The age entered is {person.Age}");
Console.WriteLine($"The salary entered is {person.GetSalary()}"); //accessed a method


if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"The name entered is {person.GetFullName()}");
}
else
{
    Console.WriteLine($"The name entered is {person.GetFullName(middleName)}");
}


Triangle triangle= new Triangle() { Height = 10, Width = 5 };
Shape s = new Triangle() { Height = 10, Width = 5 };

Rectangle rectangle = new Rectangle() { Height = 10, Width = 5 };
Rectangle squre = new Rectangle() { Height = 5, Width = 5 };
