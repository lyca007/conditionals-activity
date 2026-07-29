using System;
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter exam score: ");
    int score = int.Parse(Console.ReadLine());

    string result = score >= 50 ? "Passed": "Failed";
    Console.WriteLine(result);
  }
}
