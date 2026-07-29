using System;
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter age: ");
    Console.Write("Enter monthly income: ");
    int age = int.Parse(Console.ReadLine());
    int income = int.Parse(Console.ReadLine());

    if (age >= 25 && age <= 35 && income > 50000)
    {
      Console.WriteLine("Young Professional");
    }
    else if (age >= 36 && age <= 55 && income > 70000)
    {
      Console.WriteLine("Middle-Aged Professional");
    }
    else if (age >= 56 && income < 30000)
    {
      Console.WriteLine("Senior Citizen");
    }
    else
    {
      Console.WriteLine("Other");
    }
  }
}
