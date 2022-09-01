// See https://aka.ms/new-console-template for more information

Person person = new(); //Person person = new Person();
string middleName = string.Empty;

Console.Write("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Middle Name: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
	Console.WriteLine("Full Name is: " + person.GetFullName());
}
else
{
	Console.WriteLine("Middle Full Name is: " + person.GetFullName(middleName));
}

person.GiveSalary(salary);

//Console.WriteLine("First Name is: " + person.FirstName);
//Console.WriteLine("Last Name is: " + person.LastName);

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Year of Birth is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Salary is: " + person.GetSalary());

Console.WriteLine("Ekstra prim vermek istiyor musunuz?");
string answer = Console.ReadLine().ToLower();

switch (answer)
{
	case "evet":
		Console.Write("Vermek istediğiniz prim tutarı: ");		
		person.GiveExtraSalary(Convert.ToDouble(Console.ReadLine()));
		Console.WriteLine("Ekstra prim verildi.");
        Console.WriteLine("Total Salary is: " + person.GetSalary());
        break;
	default:
		Console.WriteLine("Ekstra prim verilmedi.");
		break;
}