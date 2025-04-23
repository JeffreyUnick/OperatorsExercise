namespace OperatorsExercise;

class Program
{
    static double AreaOfCircle(double radius)
    {
        return Math.PI * Math.Pow (radius, 2);
    }

    static void Main(string[] args)
    {
        int a = 17;
        int b = 4;
        int sum = a + b;
        int product = a * b;
        int subtraction = a - b;
        int quotien = a / b;
        int remainder = a % b;
        Console.WriteLine($"{a}/{b} is {quotien} and the remainder is {remainder}\n");
        Console.WriteLine("Now I would like you to give me the radius of your circle and I will calculate his area");
        double radius = double.Parse(Console.ReadLine());
        double area = AreaOfCircle(radius);
        Console.WriteLine($"Thank you, the area of your circle is {area}");
    }
}