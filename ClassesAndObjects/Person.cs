// See https://aka.ms/new-console-template for more information
// Primitive DataTypes
// int, string, char, bool

// Object Oriented Programming - Creating your own datatype
// class - blueprint

// Single Responsibility Priniciple

public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; } = 0;

    // Fields
    private double _salary { get; set; }

    public void GiveSalary(double amount)
    {
        _salary = amount;
    }

    public void GiveExtraSalary(double amount)
    {
        _salary += amount;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}