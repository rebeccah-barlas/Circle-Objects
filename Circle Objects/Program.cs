using Circle_Objects;

Console.WriteLine("Welcome to the Circle Tester!");
Console.WriteLine("Please enter a radius - you may enter a decimal if desired");
double userRadius = 0;
bool validNumber = false;
while (validNumber == false)
{
    try
    {
        userRadius = double.Parse(Console.ReadLine());
        validNumber = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid number");
    }
}

Circle circle = new Circle(userRadius);
DisplayCircleProperties(circle);

bool agreeToGrow = true;
while (agreeToGrow == true)
{
    Console.WriteLine("Should the circle grow? (y/n)");
    string userGrow = Console.ReadLine();
    if (userGrow == "y")
    {
        Console.WriteLine("The circle is magically growing!");
        circle.Grow();
        DisplayCircleProperties(circle);
    }
    else if (userGrow == "n")
    {
        agreeToGrow = false;
        double finalRadius = circle.GetRadius();
        Console.WriteLine($"The final radius is: {finalRadius}. Goodbye!");
    }
}
static void DisplayCircleProperties(Circle circle)
{
    Console.WriteLine($"The diameter is: {circle.CalculateDiameter()}");
    Console.WriteLine($"The circumference is: {circle.CalculateCircumfrence()}");
    Console.WriteLine($"The area is: {circle.CalculateArea()}");
}