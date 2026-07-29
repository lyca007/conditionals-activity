using System;
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter radius of the circle: ");
    double radius = double.Parse(Console.ReadLine());
    Console.WriteLine("\nChoose an option: ");
    Console.WriteLine("A - Compute Area");
    Console.WriteLine("P - Compute Perimeter");
    Console.WriteLine("X - Exit");
    Console.Write("Enter your choice: ");
    
    char choice = char.ToUpper(Console.ReadKey(true).KeyChar);
    Cosole.WriteLine("\n");

    if (choice == 'A')
    {
      double area = Math.PI * radius * radius;
      Console.WriteLine("Area: " + area);
    }
    else if (choice == 'P')
    {
      double perimeter = 2 * Math.PI * radius;
      Console.WriteLine("Perimeter: " + perimeter);
    }
    else if (choice == 'X')
    {
      Console.WriteLine("Exiting...");
    }
    else
    {
      Console.WriteLine("Invalid choice.");
    }
  }
}
