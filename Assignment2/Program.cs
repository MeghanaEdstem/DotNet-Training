//Declare 3 variables a, b and c. Get the input from the user for these variables. Implement the equation (((a + b) / c) * a)


double a = 0.0;
double b = 0.0;
double c = 0.0;

Console.WriteLine("Enter a value for a,b,c: ");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" {(((a + b) / c) * a)} ");
