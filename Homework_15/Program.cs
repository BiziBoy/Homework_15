using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//написать рекурсию по выводу элементов массива
namespace Homework_15
{
  class Program
  {
   static void Print(in int[] array, int i = 0)
    {
      if (i != array.Length)
      {
        Console.WriteLine(array[i]);
        i++;
        Print(array);
      }
    }

    static void Main(string[] args)
    {
      int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
      Print(myArray);
      
      Console.ReadLine();
    }
  }
}
