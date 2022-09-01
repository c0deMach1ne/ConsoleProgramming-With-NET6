Console.Write("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length);

var triangle = new Triangle();
var triangle2 = new Triangle() { Height = height, Length = length, Hypotenuese = 10 };
var triangle3 = new Triangle(10);
var triangle4 = new Triangle(height, length, 10);

var rectangle = new Rectangle() { Width = width, Height = height, Length = length };

Console.WriteLine("Cube area is: " + cube.GetArea());
Console.WriteLine("Cube area is: " + cube.GetVolume());

Console.WriteLine("Triangle area is: " + triangle.GetArea());
Console.WriteLine("Triangle area is: " + triangle2.GetArea());
Console.WriteLine("Triangle area is: " + triangle3.GetArea());
Console.WriteLine("Triangle area is: " + triangle4.GetArea());


Console.WriteLine("Rectangle area is: " + rectangle.GetArea());