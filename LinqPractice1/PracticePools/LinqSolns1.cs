using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice1.PracticePools
{
  public static class LinqSolns1
  {
    public static void MultiplesOf5()
    {
      Console.WriteLine("..... MultiplesOf5.. ");
      IEnumerable<int> Numbers = ParallelEnumerable.Range(1, 30)
          .Where(num => num % 5 == 0)
          .ToArray();

      foreach (int num in Numbers)
      {
        Console.WriteLine(num);
      }
      Console.ReadKey();
    }
    public static void GreaterThanAvgofAll()
    {
      Console.WriteLine("..... Greater than average of all numbers.. ");
      int[] intArr = { 123, 456, 789, 012, 345, 567, 890 };

      var nums = intArr.Where(x => x > (intArr.Sum() / intArr.Length)).ToList();
      Console.WriteLine("Numbers are :");
      nums.ForEach((n) =>
      {
        Console.Write("{0} ", n);
      });
      Console.WriteLine();
      Console.ReadKey();
    }
    public static void FrequencyofNumber()
    {
      int[] intArr = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
      Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
      Console.Write("---------------------------------------------------------------------\n");
      Console.Write("The numbers in the array  are : \n");
      Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

      var nums = intArr.GroupBy(x => x);


      Console.WriteLine("Numbers are :");
      foreach (var n in nums)
      {
        Console.WriteLine("numbers {0}, frequency {1} ", n.Key, n.Count());
      }
      Console.ReadKey();
    }
    public static void FactorialofNumber()
    {
      int[] intArr = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
      Console.Write("\nLINQ : Display the number and factorial of number: \n");
      Console.Write("---------------------------------------------------------------------\n");
      static int Factorial(int x) => x <= 1 ? 1 : x * Factorial(x - 1);
      int numberFactorail = int.Parse(Console.ReadLine()); 
      Console.Write($"\n Factorail of {numberFactorail} is: {Factorial(numberFactorail)}");
      Console.ReadKey();
    }
    public static void FrequencyofCharacterButNoSpaces()
    {
      string str;

      Console.Write("\nLINQ : Display the characters and frequency of character from given string : ");
      Console.Write("\n----------------------------------------------------------------------------\n");
      Console.Write("Input the string : ");
      str = Console.ReadLine();
      Console.Write("\n");

      var chrFrequency = str.ToUpper().Where(x => x != ' ').GroupBy(y => y);

      Console.WriteLine("Frequencies are :");
      foreach (var c in chrFrequency)
      {
        Console.WriteLine("numbers {0}, frequency {1} ", c.Key, c.Count());
      }
      Console.ReadKey();
    }
    public static void FrequencyofWord()
    {
      string str;

      Console.Write("\nLINQ : Display the characters and frequency of word from given string : ");
      Console.Write("\n----------------------------------------------------------------------------\n");
      Console.Write("Input the string : ");
      str = Console.ReadLine();
      Console.Write("\n");

      var wordFrequency = str.Split(' ').ToArray().GroupBy(x => x);


      Console.WriteLine("Freqs are :");
      foreach (var c in wordFrequency)
      {
        Console.WriteLine("numbers {0}, frequency {1} ", c.Key, c.Count());
      }
      Console.ReadKey();
    
    }
    public static void WordsReverse()
    {
      Console.WriteLine("..... Reverse words in stream.. ");

      string input = "one two three";
      string revisedInput = string.Join(" ",
        input.Split(" ").Select(x => new string(x.Reverse().ToArray()))
        );

      Console.WriteLine(revisedInput);
      Console.ReadKey();
    }
    public static void EmployeeIdGreaterthan101()
    {
      Console.WriteLine("..... EmployeeIdGreaterthan101.. ");

      List<EmployeeChild> employees = new List<EmployeeChild>()
      {
        new EmployeeChild { ID = 101, Name = "Amit" },
        new EmployeeChild { ID = 102, Name = "Gautam" },
        new EmployeeChild { ID = 103, Name = "Salman" },
        new EmployeeChild { ID = 104, Name = "Ram" },
      };

      IEnumerable<EmployeeChild> Query = employees.
        Where(emp => emp.ID > 101).ToList();

      Console.WriteLine("ID  Name");
      Console.WriteLine("==============");
      foreach (Employee s in Query)
      {
        Console.WriteLine(s.ToString());
      }
      Console.WriteLine("==============");
      Console.ReadKey();
    }
  }
}
