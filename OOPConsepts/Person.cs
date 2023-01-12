//Encapsulation
class Person
{
    //construction
    public Person(string firstName, string lastName, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        _salary = salary;
    }

    //properties
    public string FirstName { get;} //immtable class property
    public string LastName { get;}
    public int Age { get;}

    public string FirstName { get; set; } //get-retrive that peoperty and set-setting that property value
    public string LastName { get; set; }  //mutable property 
    public int Age { get; set; }

    //Fields
    private double _salary;

    //Methods
    public void SetSalary(double salary)
    {
        _salary = salary;
    }
    public double GetSalary() //this method intern maintaining a field 
    {
        return _salary;
    }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
    //method overloading
    public string GetFullName(string middleName)
    {
        return FirstName + " " + middleName + " " + LastName;
    }
}

