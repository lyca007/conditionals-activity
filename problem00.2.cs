using System;
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter Principal amount: ");
    Console.Write("Enter Rate of interest (%): ");
    Console.Write("Enter Time (in years): ");
    double principal = double.Parse(Console.ReadLine());
    double rate = double.Parse(Console.ReadLine());
    double time = double.Parse(Console.ReadLine());
    double interest = (principal * rate * time) / 100;
    Console.WriteLine("Simple Interest: " + interest);
  }
}
