using LinqPractice1.PracticePools;
using System;

namespace LinqPractice1
{
  class Program
  {
    static void Main(string[] args)
    {
      LinqSolns1.MultiplesOf5();
      LinqSolns1.WordsReverse();
      LinqSolns1.EmployeeIdGreaterthan101();
      LinqSolns1.GreaterThanAvgofAll();
      LinqSolns1.FrequencyofNumber();
      LinqSolns1.FactorialofNumber();
      LinqSolns1.FrequencyofCharacterButNoSpaces();
      LinqSolns1.FrequencyofWord();
      //Action<string> log = new Action<string>(LogInfo);
      //log("Action:- Hi ALL");
      //Console.ReadLine();

      //Func<int, int, int> addFunc = new Func<int, int, int>(Add);
      //int result = addFunc(3, 4);
      //Console.WriteLine("Func Add(3, 4):-" + result);
      //Console.ReadLine();

      //Predicate<int> IsEven = new(IsEvenNumber);
      //Console.WriteLine("Predicate IsEven(10):-" + IsEven(10));
      //Console.WriteLine("Predicate IsEven:-(1567)" + IsEven(1567));
      //Console.ReadLine();

      //BaseClass bc = new BaseClass();
      //DerivedClass dc = new DerivedClass();
      //BaseClass bcdc = new DerivedClass();

      //bc.Method1();
      //dc.Method1();
      //dc.Method2();
      //bcdc.Method1();
    }
    static bool IsEvenNumber(int number)
    {
      return number % 2 == 0;
    }
    static int Add(int a, int b)
    {
      return a + b;
    }
    static void LogInfo(string message)
    {
      Console.WriteLine(message);
    }
    class BaseClass
    {
      public virtual void Method1()
      {
        Console.WriteLine("Base - Method1");
      }
      public void Method10()
      {
        Console.WriteLine("Base - Method1");
      }
    }
    abstract class B:BaseClass
    {
      public abstract override void Method1();
    }

    class DerivedClass : B
    {
      public override void Method1()
      {
        Console.WriteLine("Derived - Method2");
      }
      public void Method2()
      {
        Console.WriteLine("Derived - Method2");
      }
      public void Method3()
      {
        Console.WriteLine("Derived - Method1");
      }
    }
  }
}
