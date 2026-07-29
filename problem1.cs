using System;
class Program
{
  static void Main(string[] args)
  {
    //Integer
    Console.Write("Enter first whole number: ");
    Console.Write("Enter second whole number: ");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Sum: " + (num1 + num2));

    //Float
    Console.Write("\nFirst score: ");
    Console.Write("Second score: ");
    Console.Write("Third score: ");
    float s1 = float.Parse(Console.ReadLine());
    float s2 = float.Parse(Console.ReadLine());
    float s3 = float.Parse(Console.ReadLine());
    Console.WriteLine("Average: " + ((s1+s2+s3)/3).ToString("F2"));

    //Double
    Console.Write("\nRadius: ");
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine("Area: " + (Math.PI * r * r));

    //String
    Console.Write("\nFirst name: ");
    Console.Write("Last name: ");
    string fn = Console.Readline();
    string ln = Console.Readline();
    Console.WriteLine("Full name: " + fn + " " + ln);
  }
}
